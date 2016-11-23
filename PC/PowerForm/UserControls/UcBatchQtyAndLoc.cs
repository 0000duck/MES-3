using System;
using System.Windows.Forms;

namespace WinForm.UserControls
{
    public partial class UcBatchQtyAndLoc : UserControl
    {
        public string Title
        {
            get { return groupPanel1.Text; }
            set { groupPanel1.Text = value; }
        }

        public string Batch
        {
            get { return txtBatch.Text; }
            set { txtBatch.Text = value; }
        }

        public string LocCode
        {
            get { return txtLocCode.Text; }
            set { txtLocCode.Text = value; }
        }

        public string Qty
        {
            get { return txtQty.Text; }
            set { txtQty.Text = value; }
        }

        public bool BatchReadOnly
        {
            get { return txtBatch.ReadOnly; }
            set { txtBatch.ReadOnly = value; }
        }

        public bool QtyReadOnly
        {
            get { return txtQty.ReadOnly; }
            set { txtQty.ReadOnly = value; }
        }

        public bool LocCodeReadOnly
        {
            get { return txtLocCode.ReadOnly; }
            set { txtLocCode.ReadOnly = value; }
        }

        public bool AllReadOnly
        {
            get { return BatchReadOnly & QtyReadOnly & LocCodeReadOnly; }
            set
            {
                BatchReadOnly = value;
                QtyReadOnly = value;
                LocCodeReadOnly = value;
            }
        }

        public bool LocCodeVisible
        {
            get { return txtLocCode.Visible; }
            set { txtLocCode.Visible = value; }
        }


        public UcBatchQtyAndLoc()
        {
            InitializeComponent();
        }

        public void SetValues(string batch, string locCode, string qty)
        {
            Batch = batch;
            LocCode = locCode;
            Qty = qty;
        }



        private void txtLocCode_BtnClick(object sender, EventArgs e)
        {
            var frm = new QueryBaseData.FrmQryStoreLocation();
            frm.ShowDialog();
            LocCode = frm.SelectedValue.cLocCode;
        }
    }
}
