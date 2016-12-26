using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar;
using gregn6Lib;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupMaterialChoice: Office2007Form
    {
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        Expression<Func<TA_PART, bool>> where ;
        public string ChoicePartCode;

        public PopupMaterialChoice()
        {
            InitializeComponent();
        }

        public PopupMaterialChoice(VW_BILL bill)
        {
            InitializeComponent();          
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            ChoicePartCode = "";
            FilterDataSource(); 
        }

        private void FilterDataSource()
        {           
            Expression<Func<TA_PART, dynamic>> select =c => c;
            Expression<Func<TA_PART, long>> order = c => c.UID;
            where = c => 1 == 1;
            if (tbName.Text != "")
            {
                if (tbModel.Text != "")
                {
                    where = c => c.PartDesc1.Contains(tbName.Text) && c.PartDesc2.Contains(tbModel.Text);
                }
                else
                {
                    where = c => c.PartDesc1.Contains(tbName.Text);
                }
            }
            else
            {
                if (tbModel.Text != "")
                {
                    where = c => c.PartDesc2.Contains(tbModel.Text);
                }
            }
            int count;
            var _list = EniitiesHelper.GetData(_db,
                @select,
                @where,
                order,
                out count);
            grid.PrimaryGrid.DataSource = _list;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChoicePartCode == "")
                {
                    MessageHelper.ShowError("请选择备件！");
                    return;
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.ToString());
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterDataSource();
        }

        private void grid_CellActivated(object sender, DevComponents.DotNetBar.SuperGrid.GridCellActivatedEventArgs e)
        {
            ChoicePartCode = e.NewActiveCell.GridRow[gcPartCode].Value.ToString();
        }

        private void grid_CellDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs e)
        {
            Close();
        }
    }
}
