using System;
using System.Windows.Forms;
using BLL.BillBase;
using BLMSystem;
using Entity;
using Entity.Enum;
using WinForm.PopUpForm;
using WinForm.QueryBaseData;

namespace WinForm.UserControls
{
    public partial class UcPart : UserControl
    {
        public string Title
        {
            get { return groupPanel1.Text; }
            set { groupPanel1.Text = value; }
        }

        public TA_PART Part { get; set; }

        public string PartCode { get { return txtPartCode.Text; } private set { txtPartCode.Text = value; } }
        public string PartName { get { return txtPartName.Text; } private set { txtPartName.Text = value; } }
        public string ErpCode { get { return txtErpCode.Text; } set { txtErpCode.Text = value; } }
        public decimal UsableQty { get { return InputUsableStock.Value; } private set { InputUsableStock.Value = value; } }
        public string Batch { get { return txtBatch.Text; }set { txtBatch.Text = value; }}
        public string LocCode{get { return txtLocCode.Text; }set { txtLocCode.Text = value; }}
        public decimal Qty { get { return InputQty.Value; } set { InputQty.Value = value; } }
        public decimal StdBoxQty { get; set; }
        
        public event EventHandler BtnClick;

        public bool QtyVisible
        {
            get
            {
                return InputBillQty.Visible && InputClosedQty.Visible && InputOpenQty.Visible; 
                
            }
           set
            {
                InputBillQty.Visible = value;
                InputClosedQty.Visible = value;
                InputOpenQty.Visible = value;
            }
        }

        public bool ReadOnly
        {
            get { return txtPartCode.ReadOnly; }
            set
            {
                txtPartCode.ReadOnly = value;
                txtBatch.ReadOnly = value;
                InputQty.ReadOnly = value;
                txtLocCode.ReadOnly = value;
            }
        }

        public DateTime EndTime { get; set; }

        public UcPart()
        {
            InitializeComponent();
            
            txtPartCode.ReadOnly = false;
            QtyVisible = false;
        }

        private void txtPartCode_BtnClick(object sender, EventArgs e)
        {
            var frm = new FrmQryPart();
            frm.ShowDialog();
            var part = frm.SelectedValue;
            SetValues(part);
        }

        private void txtPartCode_TxtKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                SetValues(txtPartCode.Text);
            }
            catch (Exception ex)
            {

                BLMUtils.ShowError(ex.Message);
            }
        }


        private void InputQty_ButtonCustomClick(object sender, EventArgs e)
        {
             try
            {
                var frm = new FrmGetQty(Part.dStdBoxQty);
                frm.ShowDialog();
                if(frm.DialogResult!=DialogResult.OK)return;
                InputQty.Text = frm.Qty.ToString();
            }
            catch (Exception ex)
            {

                BLMUtils.ShowError(ex.Message);
            }
        }

        private void txtLocCode_BtnClick(object sender, EventArgs e)
        {
            var frm = new QueryBaseData.FrmQryStoreLocation();
            frm.ShowDialog();
            LocCode = frm.SelectedValue.cLocCode;
        }

        public void SetValues(string partCode)
        {
            var part = BLL.PartController.GetPart(partCode);
            SetValues(part);
        }

        public void SetValues(TA_PART part)
        {
            var stockM = BLL.StockController.GetStockMasterByMaterialCode(part.cPartCode);
            Part = part;
            PartCode = part.cPartCode;
            PartName = part.cPartName;
            ErpCode = part.cErpCode;
            UsableQty = stockM.dUsableQty;
            Qty = part.dStdBoxQty;
            EndTime = DateTime.Now.AddMinutes(part.nPreMinutes);
            StdBoxQty = part.dStdBoxQty;
            if (BtnClick != null)
                BtnClick(this, null);
        }

        public void SetValues(string partCode,string batch,BillType billType)
        {

            SetValues(partCode);
            Batch = batch;
            if (BtnClick != null)
                BtnClick(this, null);
        }
        
    }
}
