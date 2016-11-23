using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.BillBase;
using BLMSystem;
using Entity.Enum;
using WinForm.QueryBill;

namespace WinForm.UserControls
{
    public partial class UcBillNum : UserControl
    {
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

        public SourceBill SourceBill { get; set; }



        [CategoryAttribute("自定义属性"), DescriptionAttribute("只读"), DefaultValue(false)]
        public bool ReadOnly
        {
            set
            {
                txtBillNum.ReadOnly = value;
                btnOK.Visible = !value;
                btnOK.Enabled = !value;
            }
        }

        private BillType _billType;
        public event EventHandler BtnClick;

        public UcBillNum()
        {
            InitializeComponent();
        }

        public UcBillNum(BillType billType)
        {
            InitializeComponent();
            _billType = billType;
        }

        public void SetValues(string billNum)
        {
            BillNum = billNum;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            ValidateBarCode();
            if (BtnClick != null)
            {
                BtnClick(sender, e);
            }

        }

        private void ValidateBarCode()
        {
            try
            {
                IsNullOrEmpty(BillNum);
            }
            catch (Exception ex)
            {

                BLMUtils.ShowError(ex.Message);
            }
        }

        public static void IsNullOrEmpty(string strBarCode)
        {
            //条码不能为空
            bool isNullOrEmpty = string.IsNullOrEmpty(strBarCode);
            if (isNullOrEmpty)
            {
                throw new Exception("请扫描或输入单据编号！");
            }
        }



        public void Reset()
        {
            txtBillNum.Text = string.Empty;
            ReadOnly = false;

        }

        private void txtBillNum_TxtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;

            ValidateBarCode();
            if (BtnClick != null)
            {
                BtnClick(sender, e);
            }
        }

        private void txtBillNum_ButtonCustomClick(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmQrySourceBill(_billType);
                frm.ShowDialog();
                if (frm.DialogResult != DialogResult.OK) return;
                SourceBill = frm.SelectedSourceBill;
                BillNum = SourceBill.SourceBillMaster.BillNum;
            }
            catch (Exception ex)
            {
                BLMUtils.ShowError(ex.Message);
            }
        }
    }
}
