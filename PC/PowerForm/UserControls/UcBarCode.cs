using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLMSystem;

namespace WinForm.UserControls
{
    public partial class UcBarCode : UserControl
    {
        public string Title
        {
            get { return groupPanel1.Text; }
            set { groupPanel1.Text = value; }
        }

        public string BarCode {
            get { return txtBarCode.Text; }
            set { txtBarCode.Text = value; } 
        }

        [CategoryAttribute("自定义属性"),DescriptionAttribute("只读"),DefaultValue(false)]
        public bool ReadOnly
        {
            set
            {
                txtBarCode.ReadOnly = true;
                btnOK.Visible = false;
                btnOK.Enabled = false;
            }
        }

        public event EventHandler BtnClick;
       
        public UcBarCode()
        {
            InitializeComponent();
        }

        public void SetValues(string barCode)
        {
            BarCode = barCode;
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
                IsNullOrEmpty(BarCode);
                IsInBarCodeList(BarCode,true);
                IsInStockDetail(BarCode,false);
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
                throw new Exception("请扫描或输入条码！");
            }
        }

        public static void IsInBarCodeList(string strBarCode,bool needExist)
        {
            //如果是按条码入库，条码是否在流水表中
            bool inBarCodeList = BLL.BarCodeController.Any(strBarCode);
            if (needExist && !inBarCodeList)
            {
                throw new Exception("条码不在系统条码列表中！");
            }
            if (!needExist && inBarCodeList)
            {
                throw new Exception("条码已在系统条码列表中！");
            }
        }

        public static void IsInStockDetail(string strBarCode,bool needExist)
        {
            //如果是按条码入库，查看扫描的条码是否已经入库
            bool inStockDetail = BLL.StockController.Any(strBarCode);
            if (!needExist && inStockDetail)
            {
                throw new Exception("此条码已在库存中！");
            }
            if (needExist && !inStockDetail)
            {
                throw new Exception("此条码不在库存中！");
            }
        }

        private void txtBarCode_TxtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;

            ValidateBarCode();
        }

    }
}
