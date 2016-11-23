using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using BLL.BillBase;
using BLMSystem;
using Entity;
using Entity.Enum;
using WinForm.QueryBill;

namespace WinForm.UserControls
{
    public partial class UcBillMaster : UserControl
    {
        public BillType BillType { get; set; }

        public string Title
        {
            get { return groupPanel1.Text; }
            set { groupPanel1.Text = value; }
        }

        public string BillNum
        {
            get { return txtBillNum.Text; }
            set { txtBillNum.Text = value; }
        }

        public string ErpBillNum
        {
            get { return txtErpBillNum.Text; }
            set { txtErpBillNum.Text = value; }
        }

        public string VenderName
        {
            get { return txtVender.Text; }
            set { txtVender.Text = value; }
        }

        public string CustomerName
        {
            get { return txtCustomer.Text; }
            set { txtCustomer.Text = value; }
        }

        public string Remark
        {
            get { return txtRemark.Text; }
            set { txtRemark.Text = value; }
        }

        private bool IsVenderVisible
        {
            get { return txtVender.Visible; }
            set
            {
                txtVender.Visible = value;
            }
        }

        private bool IsCustomerVisible
        {
            get { return txtCustomer.Visible; }
            set
            {
                txtCustomer.Visible = value;
            }
        }

        private void SetValues(SourceBillMaster sourceBillMaster)
        {
            SetVisible(BillType);
            BillNum = sourceBillMaster.BillNum;
            txtErpBillNum.Text = sourceBillMaster.ErpBillNum;
            VenderName = sourceBillMaster.VenderName;
            CustomerName = sourceBillMaster.CustomerName;
            Remark = sourceBillMaster.Remark;

        }

        public void SetVisible(BillType billType)
        {
            switch (billType)
            {
                case BillType.PurchaseOrder:
                case BillType.Asn:
                case BillType.MaterialIn:
                    IsVenderVisible = true;
                    IsCustomerVisible = false;
                    break;
                case BillType.SaleOrder:
                    IsVenderVisible = false;
                    IsCustomerVisible = true;
                    break;
                default:
                    IsVenderVisible = false;
                    IsCustomerVisible = false;
                    break;
            }
        }

        public UcBillMaster()
        {
            InitializeComponent();
        }

        public UcBillMaster(BillType billType)
        {
            InitializeComponent();
            BillType = billType;
            SetVisible(billType);
        }

        public void Reset()
        {
            txtBillNum.Text = string.Empty;
            txtErpBillNum.Text = string.Empty;
            txtCustomer.Text = string.Empty;
            txtVender.Text = string.Empty;
            txtRemark.Text = string.Empty;
        }
//
//        public void SetValues(VB_BILL_MAIN sourceBillMaster)
//        {
//            IsVenderVisible = true;
//            IsCustomerVisible = false;
//
//            BillNum = sourceBillMaster.cBillNum;
//            txtErpBillNum.Text = "";
//            VenderName = sourceBillMaster.cSourceName;
//            CustomerName = sourceBillMaster.cSourceName;
//            Remark = sourceBillMaster.cRemark;
//        }
//
//        public void SetValues(VF_PURCHASE_ORDER_M sourceBillMaster)
//        {
//            IsVenderVisible = true;
//            IsCustomerVisible = false;
//
//            BillNum = sourceBillMaster.cBillNum;
//            txtErpBillNum.Text = "";
//            VenderName = sourceBillMaster.cVendName;
//            CustomerName = "";
//            Remark = sourceBillMaster.cRemark;
//
//        }
//
//        public void SetValues(VF_PRODUCE_PLAN_M sourceBillMaster)
//        {
//            IsVenderVisible = false;
//            IsCustomerVisible = false;
//
//            BillNum = sourceBillMaster.cBillNum;
//            txtErpBillNum.Text = "";
//            VenderName = "";
//            CustomerName = "";
//            Remark = sourceBillMaster.cRemark;
//
//        }
//
//        public void SetValues(VF_SALE_ORDER_M sourceBillMaster)
//        {
//            IsVenderVisible = false;
//            IsCustomerVisible = true;
//
//            BillNum = sourceBillMaster.cBillNum;
//            txtErpBillNum.Text = "";
//            VenderName = "";
//            CustomerName = sourceBillMaster.cCustName;
//            Remark = sourceBillMaster.cRemark;
//
//        }



        public delegate void BtnClickHandler(object sender, System.EventArgs e);
        public event BtnClickHandler BtnClick;

        private void txtBillNum_BtnClick(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmQrySourceBill(BillType);
                frm.ShowDialog();
                if (frm.DialogResult != DialogResult.OK) return;
                var sourceBill = frm.SelectedSourceBill;
                SetValues(sourceBill.SourceBillMaster);
                if (BtnClick != null)
                    BtnClick(sender, e);
            }
            catch (Exception ex)
            {
                BLMUtils.ShowError(ex.Message);
            }
        }

        private void txtBillNum_TxtKeyPress(object sender, EventArgs e)
        {
            try
            {
                IsNullOrEmpty(txtBillNum.Text);
                var sourceBill = SourceBillController.GetSourceBill(BillType, txtBillNum.Text);
                SetValues(sourceBill.SourceBillMaster);
                if (BtnClick != null)
                    BtnClick(sender, e);
            }
            catch (Exception ex)
            {
               BLMUtils.ShowError(ex.Message);
            }
        }

        private static void IsNullOrEmpty(string strBarCode)
        {
            //条码不能为空
            bool isNullOrEmpty = string.IsNullOrEmpty(strBarCode);
            if (isNullOrEmpty)
            {
                throw new Exception("请扫描或输入单据编号！");
            }
        }
    }
}
