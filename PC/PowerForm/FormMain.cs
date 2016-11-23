using System;
using System.Linq;
using System.Windows.Forms;
using ChangKeTec.PowerForm.Manage;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using FormDept = ChangKeTec.PowerForm.Manage.FormDept;
using FormMenu = ChangKeTec.PowerForm.Manage.FormMenu;

namespace ChangKeTec.PowerForm
{
    public partial class FormMain : RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
//            lblVer.Text = @"Ver " + Application.ProductVersion;
            timerNotify.Enabled = true;
            superTabControlMain.Tabs.Clear();
            InitMenu();

        }


        private void InitMenu()
        {
            CloseAllTabs();
            SetMdiForm("默认页", typeof(FormDefault));         
//            lblOperName.Text = @"当前用户：" + GlobalVar.Oper.OperName;
        }

        public void SetMdiForm(string caption, Type formType,object[] objArgs = null)
        {
            var tab = superTabControlMain.Tabs.Cast<SuperTabItem>().FirstOrDefault(x => x.Text == caption && x.AttachedControl.GetType() == formType);

            if (tab == null)
            {
                var form = Activator.CreateInstance(formType, objArgs) as Form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.Fixed3D;
                form.Dock = DockStyle.Fill;
                //form.Visible = true;
                tab = new SuperTabItem
                {
                    Name = caption,
                    Text = caption,
                    AttachedControl = form
                };
                superTabControlMain.Tabs.Add(tab);
                superTabControlMain.SelectedTab = tab;
                superTabControlPanelMain.Controls.Add(form);
            }
            superTabControlMain.SelectedTab = tab;

        }

        #region TAB页关闭


        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        private void CloseTab()
        {
            if (ActiveMdiChild == null) return;
            Type formType = ActiveMdiChild.GetType();
            for (int i = superTabControlMain.Tabs.Count; i >= 0; i--)
            {
                SuperTabItem tabitem = superTabControlMain.Tabs[i] as SuperTabItem;
                if (tabitem == null || formType != tabitem.AttachedControl.Controls[0].GetType()) continue;
                tabitem.Close();
                break;
            }
        }

        private void 全部关闭AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
        }

        private void CloseAllTabs()
        {
            for (int i = superTabControlMain.Tabs.Count - 1; i >= 0; i--)
            {
                SuperTabItem tabitem = superTabControlMain.Tabs[i] as SuperTabItem;
                tabitem?.Close();
            }
        }

        private void 关闭其他OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherTabs();
        }

        private void CloseOtherTabs()
        {
            if (ActiveMdiChild == null) return;
            Type formType = ActiveMdiChild.GetType();
            for (int i = superTabControlMain.Tabs.Count - 1; i >= 0; i--)
            {
                SuperTabItem tabitem = superTabControlMain.Tabs[i] as SuperTabItem;
                if (tabitem != null && formType != tabitem.AttachedControl.Controls[0].GetType())
                {
                    tabitem.Close();
                }
            }
        }

        #endregion

        
        #region 工具栏按钮

        private void btnDept_Click(object sender, EventArgs e)
        {
            SetMdiForm("组织架构", typeof (FormDept));
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            SetMdiForm("角色管理", typeof (FormRole));
        }

        private void btnOper_Click(object sender, EventArgs e)
        {
            SetMdiForm("操作员管理", typeof(FormOperator));
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            SetMdiForm("菜单管理", typeof(FormMenu));
        }


        private void btnPortal_Click(object sender, EventArgs e)
        {
            SetMdiForm("系统管理", typeof(FormPortal));

        }



        #endregion

        private void btnMobilePass_Click(object sender, EventArgs e)
        {
            FormModifyPassword form = new FormModifyPassword();
            form.ShowDialog();
        }
    }
}

