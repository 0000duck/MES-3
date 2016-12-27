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
    public partial class PopupStockChoice : Office2007Form
    {
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        Expression<Func<VIEW_STOCK_DETAIL, bool>> where ;
        public string ChoicePartCode;
        public string ChoicePartBatch;
        public decimal ChoiceUnitPrice;
        public string ChoiceSLoc;

        public PopupStockChoice()
        {
            InitializeComponent();
        }

        public PopupStockChoice(VW_BILL bill)
        {
            InitializeComponent();          
        }

        private void FormWhseReceive_Load(object sender, EventArgs e)
        {
            ChoicePartCode = "";
            ChoicePartBatch = "";
            ChoiceUnitPrice = 0;
            ChoiceSLoc = "";
            FilterDataSource(); 
        }

        private void FilterDataSource()
        {           
            Expression<Func<VIEW_STOCK_DETAIL, dynamic>> select =c => c;
            Expression<Func<VIEW_STOCK_DETAIL, string>> order = c => c.零件号;
            where = c => 1 == 1;
            if (tbName.Text != "")
            {
                if (tbModel.Text != "")
                {
                    if (tbKW.Text != "")
                    {
                        where = c => c.零件描述1.Contains(tbName.Text) && c.零件描述1.Contains(tbModel.Text) && c.库位.Contains(tbKW.Text);
                    }
                    else
                    {
                        where = c => c.零件描述1.Contains(tbName.Text) && c.零件描述1.Contains(tbModel.Text);
                    }
                }
                else
                {
                    if (tbKW.Text != "")
                    {
                        where = c => c.零件描述2.Contains(tbName.Text) && c.库位.Contains(tbKW.Text);
                    }
                    else
                    {
                        where = c => c.零件描述2.Contains(tbName.Text);
                    }
                }
            }
            else
            {
                if (tbModel.Text != "")
                {
                    if (tbKW.Text != "")
                    {
                        where = c => c.零件描述2.Contains(tbModel.Text) && c.库位.Contains(tbKW.Text);
                    }
                    else
                    {
                        where = c => c.零件描述2.Contains(tbModel.Text);
                    }
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
            ChoicePartBatch = e.NewActiveCell.GridRow[gcBatch].Value.ToString();
            ChoiceSLoc = e.NewActiveCell.GridRow[gcKW].Value.ToString();
            ChoiceUnitPrice = (decimal)e.NewActiveCell.GridRow[gcUnitPrice].Value;
        }

        private void grid_CellDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs e)
        {
            Close();
        }
    }
}
