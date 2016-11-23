using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinForm.UserControls
{
    public partial class UcDataGrid : UserControl
    {
        public string Title { get { return groupPanel1.Text; } set { groupPanel1.Text = value; } }
        public bool BarVisible {get { return bar1.Visible; } set { bar1.Visible = value; }}
        public bool AddVisible { get { return btnAdd.Visible; } set { btnAdd.Visible = value; } }
        public bool ModifyVisible { get { return btnModify.Visible; } set { btnModify.Visible = value; } }
        public bool DeleteVisible { get { return btnDelete.Visible; } set { btnDelete.Visible = value; } }
        public object DataSource { get { return GridView.DataSource; } set { GridView.DataSource = value; } }


        public UcDataGrid()
        {
            InitializeComponent();

        }

        public delegate void BtnAddHandler(object sender, System.EventArgs e);
        public event BtnAddHandler BtnAddClick;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BtnAddClick != null)
            {
                BtnAddClick(sender, e);
            }
        }

        public delegate void BtnModifyHandler(object sender, System.EventArgs e);
        public event BtnModifyHandler BtnModifyClick;
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (BtnModifyClick != null)
            {
                BtnModifyClick(sender, e);
            }
        }

        public delegate void BtnDeleteHandler(object sender, System.EventArgs e);
        public event BtnDeleteHandler BtnDeleteClick;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BtnDeleteClick != null)
            {
                BtnDeleteClick(sender, e);
            }
        }
//        public delegate void GridViewSelectionChangeHandler(object sender, System.EventArgs e);
//        public event GridViewSelectionChangeHandler GridViewSelectionChange;
//
//        private void GridView_SelectionChanged(object sender, EventArgs e)
//        {
//            
//            if (GridViewSelectionChange != null)
//            {
//                GridViewSelectionChange(sender, e);
//            }
//        }

        public delegate void GridViewCurrentCellChangeHandler(object sender, System.EventArgs e);
        public event GridViewCurrentCellChangeHandler GridViewCurrentCellChange;

        private void GridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (GridView.CurrentRow.Index < 0) return;
            if (GridViewCurrentCellChange != null)
            {
                GridViewCurrentCellChange(sender, e);
            }
        }

        public delegate void GridViewCellContentDoubleClickHandler(object sender, DataGridViewCellEventArgs e);
        public event GridViewCellContentDoubleClickHandler GridViewCellContentDoubleClick;
        private void GridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow.Index < 0) return;
            if (GridViewCellContentDoubleClick != null)
            {
                GridViewCellContentDoubleClick(sender, e);
            }
        }

        public delegate void GridViewCellValidatingHandler(object sender, DataGridViewCellValidatingEventArgs e);
        public event GridViewCellValidatingHandler GridViewCellValidating;
        private void GridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (GridViewCellValidating != null)
            {
                GridViewCellValidating(sender, e);
            }
        }
    }
}
