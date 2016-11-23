using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BLL;
using BLMSystem;
using Entity;

namespace WinForm.UserControls
{
    public partial class UcBin : UserControl
    {
        public string Title
        {
            get { return groupPanel1.Text; }
            set { groupPanel1.Text = value; }
        }


        public TS_BIN_M BinM { get; set; }
        public List<TS_BIN_D> BinDs { get; set; }
        public UcBin()
        {
            InitializeComponent();
            Init();
        }
        public delegate void BtnClickHandler(object sender, System.EventArgs e);
        public event BtnClickHandler BtnClick;

        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                if(string.IsNullOrEmpty(txtBinCode.Text))throw new Exception("请输入器具编号!");
                BinM = BinController.GetBinM(txtBinCode.Text);
                BinDs = BinController.GetBinDs(txtBinCode.Text);
                if (BtnClick != null)
                {
                    BtnClick(sender, e);
                }
            }
            catch (Exception ex)
            {
               BLMUtils.ShowError(ex.Message);
            }
        }

        public void Init()
        {
            txtBinCode.Text = string.Empty;
            BinM = new TS_BIN_M();
            BinDs = new List<TS_BIN_D>();

        }
    }
}
