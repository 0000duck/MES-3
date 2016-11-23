using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Common.UC;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;

namespace ChangKeTec.Wms.WinForm.Logs
{
    public partial class FormErpInterface : Office2007Form
    {
        private SpareEntities _db = EntitiesFactory.CreateWmsInstance();
        public FormErpInterface()
        {
            InitializeComponent();
        }




        private void FormLog_Load(object sender, EventArgs e)
        {
            GetLogList();
        }

        private void GetLogList()
        {
            SetInterfaceMasterDataSource(1000);
            SetInterfaceHisMasterDataSource(gridInterfaceHis.PageSize);
        }

        private void SetInterfaceMasterDataSource(int pageSize)
        {
            Expression<Func<TL_INTERFACE, dynamic>> select =
                c => 
                    new
                    {
                        c.UID,
                        接口类型=c.InterfaceType,
                        接口文本=c.InterfaceString,
                        状态=c.State,
                        备注=c.Remark,
                        创建时间=c.CreateTime,
                        执行时间=c.ProcessTime,
                        有效日期=c.BillNum,
                        单据类型=c.BillType,
                      
                    };
            Expression<Func<TL_INTERFACE, bool>> where = c => true;
            Expression<Func<TL_INTERFACE, long>> order = c => c.UID;

            int total;
            var grid = gridInterface;
            var list = EniitiesHelper.GetPagedDataAsc(_db,
                select,
                where,
                order,
                grid.PageIndex, grid.PageSize, out total);

            grid.MasterDataSource = list.Count > 0 ? list :null ;
            if (grid.Total != total) grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }

        private void SetInterfaceHisMasterDataSource(int pageSize)
        {
            Expression<Func<TS_INTERFACE_HIS, dynamic>> select =
                c =>
                    new
                    {
                        c.UID,
                        接口类型 = c.InterfaceType,
                        接口文本 = c.InterfaceString,
                        状态 = c.State,
                        备注 = c.Remark,
                        创建时间 = c.CreateTime,
                        执行时间 = c.ProcessTime,
                        有效日期 = c.BillNum,
                        单据类型 = c.BillType,

                    };
            Expression<Func<TS_INTERFACE_HIS, bool>> where = c => true;
            Expression<Func<TS_INTERFACE_HIS, long>> order = c => c.UID;

            int total;
            var grid = gridInterfaceHis;
            grid.MasterDataSource = EniitiesHelper.GetPagedDataAsc(_db,
                select,
                where,
                order,
                grid.PageIndex, grid.PageSize, out total);
            if (grid.Total != total) grid.Total = total;
            if (grid.PageSize != pageSize)
                grid.PageSize = pageSize;
        }


        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = DataGridViewHelper.DgvToTable(gridInterfaceHis.MasterPrimaryGrid, "InterfaceHis");
            ds.Tables.Add(dt);
            dt = DataGridViewHelper.DgvToTable(gridInterface.MasterPrimaryGrid, "Interface");
            ds.Tables.Add(dt);
            ExcelWriter.Write(ds);
        }

        private void gridInterfaceHis_DataRefreshed(object sender, CktMasterDetailGrid.QtyEventArgs e)
        {
            SetInterfaceHisMasterDataSource(e.PageSize);
        }

        private void gridInterfaceHis_PageSelectedIndexChanged(object sender, EventArgs e)
        {
            SetInterfaceHisMasterDataSource(gridInterfaceHis.PageSize);
        }
    }
}
