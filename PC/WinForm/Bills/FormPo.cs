using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using gregn6Lib;

namespace ChangKeTec.Wms.WinForm.Bills
{
    public partial class FormPo: Office2007Form
    {
        private BillType _billType = BillType.PuchaseOrder;
        private readonly GridppReport _report;
        private readonly TA_BILLTYPE _taBilltype;

        private TB_BILL _bill = null;
        private readonly string DetailTableName = "TB_PO";
        private readonly string IndexColumnName = "BillNum";
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public FormPo()
        {
            InitializeComponent();
            _taBilltype = GlobalBuffer.BillTypeList.Single(p => p.BillType == (int)_billType);

            _report = ReportHelper.InitReport(_billType);
            _report.Initialize += () => ReportHelper._report_Initialize(_report, _bill, DetailTableName, IndexColumnName);

        }


        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            SetMasterDataSource(grid.PageSize);
        }

        
        
        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewHelper.DgvToTable(grid.MasterPrimaryGrid, EnumHelper.GetDescription(_billType));
            ExcelWriter.Write(dt);
        }

        

        private void SetMasterDataSource(int pageSize)
        {
            Expression<Func<TB_BILL, dynamic>> select =c => c;
            Expression<Func<TB_BILL, bool>> where = c => true;
            Expression<Func<TB_BILL, long>> order = c => c.UID;

            int total;
            grid.MasterDataSource =EniitiesHelper.GetPagedDataDesc(_db,
                select,
                where,
                order,
                grid.PageIndex, 
                grid.PageSize,
                out total);
            if (grid.Total != total )
                grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }

        private int SetDetailDataSource(string billNum)
        {
            int count;
            Expression<Func<VIEW_PO, dynamic>> select = c => c;
            Expression<Func<VIEW_PO, bool>> where = c => c.单据号 == billNum;
            Expression<Func<VIEW_PO, long>> order = c => c.UID;

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

        private void ItemBtnPrint_Click(object sender, EventArgs e)
        {
            if (_bill == null || _bill.BillNum == null)
            {
                MessageHelper.ShowInfo("请选择单据！");
                return;
            }
            ReportHelper.Print(_report);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bill.State != (int)BillState.New)
                {
                    throw new WmsException(ResultCode.DataStateError, _bill.BillNum, "状态错误,不应为：" + _bill.State);
                }
                PoController.UpdateState(_db, _bill, BillState.Cancelled); //更新状态为：取消

                EntitiesFactory.SaveDb(_db);
                SetMasterDataSource(grid.PageSize);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex.ToString());

            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var dt = DataGridViewHelper.ImportFileToDataTable();
            if (dt.Rows.Count == 0) return;

            try
            {
                GetDataList(dt);
           SetMasterDataSource(grid.PageSize);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo("Excel文件格式错误" + ex.Message);
            }
       
        }

        private void GetDataList(DataTable dt)
        {
            var billList = new List<TB_BILL>();
            var detailList = new List<TB_PO>();
            foreach (DataRow dr in dt.Rows)

            {
                string billNum = dr[0].ToString();
                if (billList.All(p => p.BillNum != billNum))
                {
                    billList.Add(new TB_BILL
                    {
                        BillNum = billNum,
                        BillType = (int) _billType,
                        SplyId = dr[6].ToString(),
                        BillTime = Convert.ToDateTime(dr[7]),
                        OperName = GlobalVar.Oper.OperName,
                        State = (int) BillState.New,
                    });
                }
                detailList.Add(new TB_PO
                {
                    BillNum = billNum,
                    LineNum = Convert.ToInt32(dr[1]),
                    PartCode = dr[2].ToString(),
                    BillQty = Convert.ToDecimal(dr[3]),
                    OpenQty = Convert.ToDecimal(dr[3]),
                    ClosedQty = 0,
                    Unit = dr[4].ToString(),
                    Price = Convert.ToDecimal(dr[5]),
                    State = 0,
                    Remark = dr[10].ToString(),
                });
            }

            try
            {
                PoController.AddPoList(_db, billList, detailList);
                EntitiesFactory.SaveDb(_db);
                MessageHelper.ShowInfo("数据导入成功");

            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());

            }


        }


        private void btnOpenImportTemplete_Click(object sender, EventArgs e)
        {
            string vOpenFilePath = IoHelper.GetDllPath() + GlobalVar.ImportTemplatePath + _taBilltype.ImportTemplateFileName;

            //先判断文件是否存在，不存在则提示
            if (!System.IO.File.Exists(vOpenFilePath))
            {
                MessageHelper.ShowError("销售订单导入模板文件不存在！");
                return;
            }
            //存在则打开
            System.Diagnostics.Process.Start(vOpenFilePath);
        }
    }
}
