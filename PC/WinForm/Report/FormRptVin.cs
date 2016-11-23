using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.Report
{
    public partial class FormRptVin : Office2007Form
    {
        private readonly BillType _billType;
        private DateTime _beginTime = DateTime.Now.AddDays(-GlobalVar.DefaultPreDays);
        private DateTime _endTime = DateTime.Now.AddDays(1);

        private int _beginHour=0;
        private int _endHour=24;

        private List<TB_BILL> _billList; 
        private TB_BILL _bill=null;
        private List<VS_VIN_PART> _detailList;
        private Common.SortableBindingList<SumByPart> _sumPartList;
        private Common.SortableBindingList<SumVinByDate> _sumVinByDateList;
        private Common.SortableBindingList<SumPartByDate> _sumPartByDateList;
        private BackgroundWorker _bgw;
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public FormRptVin(string billType)
        {
            InitializeComponent();
//            _billType = billType;
            if (!Enum.TryParse(billType, true, out _billType))
            {
                MessageHelper.ShowError("单据类型错误");
                Close();
            }
            _bgw = new BackgroundWorker {WorkerReportsProgress = true,WorkerSupportsCancellation = true};
            _bgw.DoWork += _bgw_DoWork;
            _bgw.RunWorkerCompleted += _bgw_RunWorkerCompleted;
            _bgw.ProgressChanged += _bgw_ProgressChanged;
            Init();
        }

        private void _bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProcess.Visible = true;
            labelProcess.Visible = true;
            pbProcess.Value = e.ProgressPercentage;
            labelProcess.Text = e.ProgressPercentage+"%"+ e.UserState.ToString();
        }

        private void _bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetMasterDataSource(grid.PageSize);
            dgvSumPartByDate.DataSource = _sumPartByDateList;
            dgvSumVinByDate.DataSource = _sumVinByDateList;
            dgvSumPart.DataSource = _sumPartList;
            superTabControl1.SelectedTab = superTabItem1;

            pbProcess.Value = 100;
            labelProcess.Text = "";

            Cursor = Cursors.Default;
        }

        private void _bgw_DoWork(object sender, DoWorkEventArgs e)
        {
           GetList();
        }

        private void Init()
        {
            _billList = new List<TB_BILL>();
            _detailList = new List<VS_VIN_PART>();
            _sumPartList = new Common.SortableBindingList<SumByPart>();
            _sumVinByDateList = new Common.SortableBindingList<SumVinByDate>();
            _sumPartByDateList = new Common.SortableBindingList<SumPartByDate>();
            dgvSumPart.AutoGenerateColumns = false;
            dgvSumVinByDate.AutoGenerateColumns = false;
            dgvSumPartByDate.AutoGenerateColumns = false;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItem1;

        }

        private void GetList()
        {
            List<VS_VIN_PART> detailList = new List<VS_VIN_PART>();
            using (SpareEntities db = EntitiesFactory.CreateWmsInstance())
            {
                _bgw.ReportProgress(0, "正在获取单据列表...");
                var billList = BillController.GetList(db, _beginTime, _endTime, _beginHour, _endHour, _billType);
//                _billList = billList.Where(p => p.State == (int)BillState.Finished).ToList();
                _billList = billList;

                _bgw.ReportProgress(10, "正在获取单据明细...");
                int count = 0;
                int total = _billList.Count;
                foreach (TB_BILL bill in _billList.Where(p => p.State == (int)BillState.Finished))
                {
                    detailList.AddRange(VinPartController.GetVList(db, bill.SourceBillNum, bill.ProjectId));
                    int n = 10 + count*50/total;
                    _bgw.ReportProgress(n, $"正在获取单据明细...{count}/{total}");
                    count++;
                }
                //                var list = VinPartController.GetVList(db);
                //                foreach (TB_BILL bill in _billList.Where(p => p.State == (int)BillState.Finished))
                //                {
                //                    detailList.AddRange(list.Where(p=>p.VinCode==bill.SourceBillNum&&p.ProjectId==bill.ProjectId));
                //                }
                _detailList = detailList;
            }
            _bgw.ReportProgress(60, "正在计算零件汇总...");

            var byParts = from c in _detailList
                          group c by new {c.ErpPartCode, c.CustPartCode, c.PartDesc1, c.PartDesc2, c.ProjectId, c.UnitPrice}
                into s
                select new SumByPart()
                {
                    ErpPartCode = s.Key.ErpPartCode,
                    CustPartCode = s.Key.CustPartCode,
                    PartDesc1 = s.Key.PartDesc1,
                    PartDesc2 = s.Key.PartDesc2,
                    ProjectId = s.Key.ProjectId,
                    Qty = s.Sum(a => a.Qty),
                    UnitPrice = s.Key.UnitPrice,
                    Amount = s.Sum(a => a.Amount)
                };
            _sumPartList = new Common.SortableBindingList<SumByPart>(byParts.ToList());

            _bgw.ReportProgress(70, "正在计算零件按日期班次汇总...");
            var dateList = _billList.Select(p => p.BillTime.ToString("yyyyMMdd")).Distinct().ToList();

            var sumPartByDates = new List<SumPartByDate>();
            foreach (var date in dateList)
            {

                var vinList =
                    _billList.Where(p => p.BillTime.ToString("yyyyMMdd") == date).Select(p => p.SourceBillNum).ToList();
                var details = new List<VS_VIN_PART>();
                foreach (var vincode in vinList)
                {
                    details.AddRange(_detailList.Where(p => p.VinCode == vincode).ToList());
                }
//                    details = sumDetailList.Where(p => vinList.Contains(p.VinCode)).ToList();
                var partByDates = GetSumPartByDay(details, date, _billType);
                sumPartByDates.AddRange(partByDates);
            }

            _sumPartByDateList = new Common.SortableBindingList<SumPartByDate>(sumPartByDates);


            _bgw.ReportProgress(90, "正在计算VIN按日期班次汇总...");

            List<SumVinByDate> sumVinByDates = new List<SumVinByDate>();
            foreach (string date in dateList)
            {

                //                    var vinByDates = GetSumVinByDay(billList, date);
                var vinByDates = GetSumVinByDay(_billList, date);
                sumVinByDates.AddRange(vinByDates);
            }

            _sumVinByDateList = new Common.SortableBindingList<SumVinByDate>(sumVinByDates);

        }

        private List<SumPartByDate> GetSumPartByDay(List<VS_VIN_PART> details, string bDate, BillType billType)
        {
            IEnumerable<SumPartByDate> byDays=null;
            if (billType==BillType.VinReceive)
             byDays = from c in details
                         group c by new {bDate,shift=GetShift(c.ReceiveTime), c.ErpPartCode, c.CustPartCode, c.PartDesc1,c.PartDesc2, c.ProjectId,c.UnitPrice}
                into s
                select new SumPartByDate()
                {
                    Date = bDate,
                    Shift = s.Key.shift,
                    ErpPartCode = s.Key.ErpPartCode,
                    CustPartCode = s.Key.CustPartCode,
                    PartDesc1 = s.Key.PartDesc1,
                    PartDesc2 = s.Key.PartDesc2,
                    ProjectId = s.Key.ProjectId,
                    Qty = s.Sum(a => a.Qty),
                        UnitPrice = s.Key.UnitPrice,
                    Amount = s.Sum(a => a.Amount)
                };
            else if(billType==BillType.VinDeliver)
                byDays = from c in details
                         group c by new { bDate, shift = GetShift(c.DeliverTime), c.ErpPartCode, c.CustPartCode, c.PartDesc1, c.PartDesc2, c.ProjectId,c.UnitPrice }
                     into s
                         select new SumPartByDate()
                         {
                             Date = bDate,
                             Shift = s.Key.shift,
                             ErpPartCode = s.Key.ErpPartCode,
                             CustPartCode = s.Key.CustPartCode,
                             PartDesc1 = s.Key.PartDesc1,
                             PartDesc2 = s.Key.PartDesc2,
                             ProjectId = s.Key.ProjectId,
                             Qty = s.Sum(a=>a.Qty),
                        UnitPrice = s.Key.UnitPrice,
                             Amount = s.Sum(a => a.Amount)
                         };
           
            return byDays.ToList();

        }

        private List<SumVinByDate> GetSumVinByDay(List<TB_BILL> bills, string bDate)
        {
            var byDays = (from c in bills.Where(p => p.BillTime.ToString("yyyyMMdd") == bDate)
                group c by new { bDate, c.ProjectId, shift = GetShift(c.BillTime) }
                into s
                select new SumVinByDate()
                {
                    Date = bDate,
                    Shift = s.Key.shift,
                    ProjectId = s.Key.ProjectId,
                    Qty = s.Count()
                }).ToList();


            return byDays;
        }

        static readonly List<string> ShiftList = new List<string> { "C班 (0-8)", "A班 (8-16)", "B班 (16-24)" };

        private static string GetShift(DateTime? billTime)
        {
            int idx = 1;
            if (billTime != null)
            {
                double hour = billTime.Value.Hour;
                idx = Convert.ToInt32(Math.Floor(hour/8));
            }
            var shift = ShiftList[idx];
            return shift;
        }
        

        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            dt = ListHelper.ListToDataTable(_detailList.ToList(), _billType+"Detail");
            ds.Tables.Add(dt);
            dt= DataGridViewHelper.DgvToTable(dgvSumVinByDate, _billType + "SumVinByDate");
            ds.Tables.Add(dt);
            dt = DataGridViewHelper.DgvToTable(dgvSumPartByDate, _billType + "SumPartByDate");
            ds.Tables.Add(dt);
            dt = DataGridViewHelper.DgvToTable(dgvSumPart,  _billType + "SumByPart");
            ds.Tables.Add(dt);
            dt = ListHelper.ListToDataTable(_billList.ToList(),  _billType+"Bill");
            ds.Tables.Add(dt);

            ExcelWriter.Write(ds);
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            PopupDateFilter dateFilter = new PopupDateFilter();
            DialogResult dr = dateFilter.ShowDialog();
            if (dr != DialogResult.OK) return;
            _beginTime = dateFilter.DtBegin;
            _endTime = dateFilter.DtEnd;
            _beginHour = dateFilter.BeginHour;
            _endHour = dateFilter.EndHour;

            Cursor = Cursors.WaitCursor;

            _bgw.RunWorkerAsync();


        }


        private void SetMasterDataSource(int pageSize)
        {
            Func<TB_BILL, dynamic> select =
                c =>
                    new
                    {
                        c.UID,
                        单据编号 = c.BillNum,
                        单据类型 = (BillType)c.BillType,
//                        单据子类型 = c.SubBillType,
                        VIN码 = c.SourceBillNum,
                        PlanOrderID = c.SourceBillNum2,
//                        开始时间 = c.StartTime,
//                        结束时间 = c.FinishTime,
                        //                        供应商编号 = c.SplyId,
                        //                        客户编号 = c.CustId,
                        单据时间 = c.BillTime,
                        操作员 = c.OperName,
                        状态 = ((BillState)c.State).ToString(),
                        备注 = c.Remark,
                    };
            //            Expression<Func<TS_VIN_HIS, bool>> where = c => true;

            int total = _billList.Count();
            grid.MasterDataSource =
                _billList.OrderByDescending(p=>p.UID)
                    .Select(select)
                    .Skip((grid.PageIndex - 1) * pageSize)
                    .Take(pageSize).ToList();
            if (grid.Total != total) grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }

        private int SetDetailDataSource(string billNum)
        {

            int count;

            Expression<Func<VIEW_STOCK_MOVE, dynamic>> select = c => c;
            Expression<Func<VIEW_STOCK_MOVE, bool>> where = c => c.单据号 == billNum;
            Expression<Func<VIEW_STOCK_MOVE, long>> order = c => c.UID;
            grid.Detail1DataSource = EniitiesHelper.GetData(_db,
                select,
                where,
                order,
                out count);
            return count;

        }

        private void grid_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageSize);
        }

        private void grid_GridCellActivated(object sender, GridCellActivatedEventArgs e)
        {
            //            MessageBox.Show(e.GridCell.GridRow.DataItem.ToString());
            SpareEntities db = EntitiesFactory.CreateWmsInstance();
            _bill = db.TB_BILL.SingleOrDefault(p => p.UID == grid.MasterUid);
            if (_bill == null) return;
            var billNum = _bill.BillNum;
            var count = SetDetailDataSource(billNum);
            grid.IsDetailVisible = count > 0;
        }


        private void grid_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetMasterDataSource(e.PageSize);

        }
    }
}
    

