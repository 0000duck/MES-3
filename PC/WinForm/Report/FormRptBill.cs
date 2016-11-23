using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.Report
{
    public partial class FormRptBill : Office2007Form
    {
        private readonly BillType _billType;
        private DateTime _beginTime = DateTime.Now.AddDays(-GlobalVar.DefaultPreDays);
        private DateTime _endTime = DateTime.Now.AddDays(1);

        private int _beginHour=0;
        private int _endHour=24;

        private SortableBindingList<TB_BILL> _billList;
        private SortableBindingList<VS_STOCK_DETAIL> _stockList;

        private List<VS_VIN_PART> _detailList;
        private SortableBindingList<SumByPart> _sumPartList;
        private SortableBindingList<SumVinByDate> _sumVinByDateList;
        private SortableBindingList<SumPartByDate> _sumPartByDateList;

        public FormRptBill(BillType billType)
        {
            InitializeComponent();
            _billType = billType;
            Init();
        }

        private void Init()
        {
            _billList = new SortableBindingList<TB_BILL>();
            _stockList = new SortableBindingList<VS_STOCK_DETAIL>();
            _detailList = new List<VS_VIN_PART>();
            _sumPartList = new SortableBindingList<SumByPart>();
            _sumVinByDateList = new SortableBindingList<SumVinByDate>();
            _sumPartByDateList = new SortableBindingList<SumPartByDate>();
            dgvBill.AutoGenerateColumns = false;
            dgvSumPart.AutoGenerateColumns = false;
            dgvSumVinByDate.AutoGenerateColumns = false;
            dgvSumPartByDate.AutoGenerateColumns = false;
            dgvDetail.AutoGenerateColumns = false;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItem1;

        }
        private void GetList()
        {
            using (SpareEntities db = EntitiesFactory.CreateWmsInstance())
            {
//                var billList = BillController.GetList(db, _beginTime, _endTime,_beginHour,_endHour, _billType);
//                billList = billList.Where(p => p.State == BillState.Finish.ToString()).ToList();
             
                var stockList = StockDetailController.GetVList(db,_beginTime, _endTime, _beginHour, _endHour, _billType);
                List<VS_VIN_PART> detailList=new List<VS_VIN_PART>();
                List<VS_VIN_PART> sumDetailList = new List<VS_VIN_PART>();
//                foreach (TB_BILL bill in billList)
//                {
//                    var tempList = VinPartController.GetVinPartListV(db,bill.SourceBillNum,bill.ProjectId);
//                    detailList.AddRange(tempList);
//                    if (bill.State != BillState.Cancel.ToString() && bill.State != BillState.New.ToString())
//                        sumDetailList.AddRange(tempList);
//                }

                foreach (VS_STOCK_DETAIL stock in stockList)
                {
                    var tempList = VinPartController.GetVList(db, stock.BarCode.Split(',')[1], stock.ProjectId);
                    detailList.AddRange(tempList);
                    sumDetailList.AddRange(tempList);
                }

//                _billList = new SortableBindingList<TB_BILL>(billList);
                _stockList = new SortableBindingList<VS_STOCK_DETAIL>(stockList);
                _detailList = new List<VS_VIN_PART>(detailList);

//                dgvBill.DataSource = _billList;
                dgvBill.DataSource = _stockList;
                var byParts = from c in sumDetailList
                              group c by new {c.ErpPartCode,c.CustPartCode,c.PartDesc1,c.PartDesc2,c.ProjectId,c.UnitPrice}
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
                        Amount = s.Sum(a=>a.Amount)
                    };
                _sumPartList = new SortableBindingList<SumByPart>(byParts.ToList());
                dgvSumPart.DataSource = _sumPartList;
//                var dateList = billList.Select(p => p.BillTime.ToString("yyyyMMdd")).Distinct().ToList();
                var dateList = stockList.Select(p => p.UpdateTime.ToString("yyyyMMdd")).Distinct().ToList();

                var sumPartByDates = new List<SumPartByDate>();
                foreach (var date in dateList)
                {

//                    var vinList = billList.Where(p => p.BillTime.ToString("yyyyMMdd") == date).Select(p => p.SourceBillNum).ToList();
                    var vinList = stockList.Where(p => p.UpdateTime.ToString("yyyyMMdd") == date).Select(p => p.BarCode.Split('.')[0]).ToList();
                    var details =new List<VS_VIN_PART>();
                    foreach (var vincode in vinList)
                    {
                        details.AddRange(sumDetailList.Where(p=>p.VinCode==vincode).ToList());
                    }
//                    details = sumDetailList.Where(p => vinList.Contains(p.VinCode)).ToList();
                    var partByDates = GetSumPartByDay(details, date, _billType);
                    sumPartByDates.AddRange(partByDates);
                }

                _sumPartByDateList = new SortableBindingList<SumPartByDate>(sumPartByDates);
                dgvSumPartByDate.DataSource = _sumPartByDateList;

             

                List<SumVinByDate> sumVinByDates = new List<SumVinByDate>();
                foreach (string date in dateList)
                {

                    //                    var vinByDates = GetSumVinByDay(billList, date);
                    var vinByDates = GetSumVinByDay(stockList, date);
                    sumVinByDates.AddRange(vinByDates);
                }

                _sumVinByDateList = new SortableBindingList<SumVinByDate>(sumVinByDates);
                dgvSumVinByDate.DataSource = _sumVinByDateList;
            }


            superTabControl1.SelectedTab = superTabItem1;

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

        private List<SumVinByDate> GetSumVinByDay(List<VS_STOCK_DETAIL> bills, string bDate)
        {
            List<SumVinByDate> byDays = new List<SumVinByDate>();
            byDays = (from c in bills
                      group c by new { bDate, c.ProjectId, shift = GetShift(c.UpdateTime) }
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
            dt = DataGridViewHelper.DgvToTable(dgvBill,  _billType+"Bill");
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
            GetList();


        }


        private void dgvBill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            var vinCode = dgvBill.Rows[e.RowIndex].Cells["BarCode"].Value.ToString();
            var detailList = _detailList.Where(p => p.VinCode == vinCode.Split('.')[0]).ToList();
            dgvDetail.DataSource = new SortableBindingList<VS_VIN_PART>(detailList);
        }

       
    }
}
    

