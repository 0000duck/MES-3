using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.PopUp;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace ChangKeTec.Wms.WinForm
{
    public partial class FormMain : RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
//            timerNotify.Interval = 1000;
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblVer.Text = @"Ver " + Application.ProductVersion;
                timerNow_Tick(null,null);
                timerNotify.Start();
                superTabControlMain.Tabs.Clear();
                try
                {
                    Init();
                }
                catch (Exception ex)
                {
                    MessageHelper.ShowError(ex);
                }
              
               
            }
            catch(Exception ex)
            {
                this.Close();
            }
        }

        private void Init()
        {
            CloseAllTabs();
           

            t1g2b2.Enabled = true;
            t1g2b3.Enabled = true;
            lblOperName.Text = @"当前用户：" + GlobalVar.Oper.OperName;


//            InitPower();
            InitMenu();
            RibbonMain.SelectFirstVisibleRibbonTab();
        }

        private void InitMenu()
        {
            var menuList = GlobalVar.PowerMenuList.Where(p=>p.IsVisible).ToList();
            RibbonMain.Items.Clear();
            RibbonMain.Items.Add(t1);
            
            foreach (var menuTab in menuList.Where(p=>p.ControlType == "Tab"))
            {
                string menuName = menuTab.ControlType + menuTab.MenuCode;
                var tab = new RibbonTabItem
                {
                    Text = menuTab.MenuText,
                    Name = menuName,
                };
                var panel = new RibbonPanel();
                panel.Dock = DockStyle.Fill;
                panel.Name = panel + menuName;
                panel.Visible = false;

                foreach (var menuGrp in menuList.Where(p => p.ParentCode == menuTab.MenuCode))
                {
                    var grp = new RibbonBar
                    {
                        Text = menuGrp.MenuText,
                        Name = menuGrp.ControlType+menuGrp.MenuCode,
                    };
                    foreach (var menuItm in menuList.Where(p => p.ParentCode == menuGrp.MenuCode))
                    {
                        var itm = new ButtonItem()
                        {
                            Text = menuItm.MenuText,
                            Name = menuItm.ControlType+menuItm.MenuCode,
                        };
                        itm.Image =
                            (Image) Common.Properties.Resources.ResourceManager.GetObject(menuItm.ImageName ?? "") ??
                            (Image) Common.Properties.Resources.ResourceManager.GetObject("DefaultButton");
                        itm.ImageFixedSize = new Size(50,50);
                        itm.ButtonStyle = eButtonStyle.ImageAndText;
                        itm.ImagePosition = eImagePosition.Top;
                        if (string.IsNullOrEmpty(menuItm.Params))
                        {
                            itm.Click +=
                                delegate
                                {
                                    SetMdiForm(menuItm.MenuText,
                                        Type.GetType(menuItm.NameSpace + "." + menuItm.ClassName));
                                };
                        }
                        else
                        {
                            itm.Click +=
                               delegate
                               {
                                   object[] strParams = menuItm.Params.Split(',');
                                   SetMdiForm(menuItm.MenuText,Type.GetType(menuItm.NameSpace + "." + menuItm.ClassName), strParams);
                               };
                        }
                        grp.Items.Add(itm);
                    }
                    panel.Controls.Add(grp);
                }
                panel.LayoutRibbons();
                tab.Panel = panel;
                RibbonMain.Controls.Add(panel);
                panel.ResumeLayout(false);
                RibbonMain.Items.Add(tab);
                
            }
            
        }



        private DialogResult ShowLoginForm()
        {

//            timerNotify.Stop();
            FormLogin login = new FormLogin();
            login.ShowDialog(this);
            var dr = login.DialogResult;
            if (dr != DialogResult.OK) return dr;
            Init();

            return dr;
        }


        public void SetMdiForm(string caption, Type formType,object[] objArgs = null)
        {
            var tab = superTabControlMain.Tabs.Cast<SuperTabItem>().FirstOrDefault(x => x.Text == caption && x.AttachedControl.GetType() == formType);
            //如果在现有Tab页面中没有找到，那么就要初始化了Tab页面了
            if (tab == null)
            {
                if (formType == null) return;
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
            SetMdiForm("默认页", typeof(FormDefault));
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

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            var dr = ShowLoginForm();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormModifyPassword form = new FormModifyPassword();
            form.ShowDialog();
        }

        private void btnRefreshConfig_Click(object sender, EventArgs e)
        {
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                GlobalVar.InitGlobalVar(db, GlobalVar.Oper);
                MessageHelper.ShowInfo("系统参数已刷新！");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            PopupAbout about = new PopupAbout();
            about.ShowDialog();
        }


        #endregion

        private int _n = 5 * 60 * 1000;
        private void timerNow_Tick(object sender, EventArgs e)
        {
            lblNow.Text = @"系统时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            if (_n < 5*60*1000)
            {
                _n+=timerNotify.Interval;
            }
            else
            {
                ShowNotifyAlertWindow();
                _n = 0;
            }
        }

        private void ShowNotifyAlertWindow()
        {
            using (SpareEntities db = EntitiesFactory.CreateSpareInstance())
            {
                var list = NotifyController.GetNewList(db, GlobalVar.NotifytypeList);
                if (list.Count == 0) return;
                list = list.Where(p => p.State == (int) BillState.New).ToList();
                if (list.Count == 0) return;
                lblNotify.Text = $"待处理提示数量:{list.Count}";
                lblNotify.Visible = true;
                try
                {
                    var alertWindow = new DesktopAlertWindow
                    {
                        CloseButtonVisible = true,
                        AlertPosition = eAlertPosition.BottomRight,
                        BackColor = Color.DarkOrange,
                        ForeColor = Color.White,
                        Symbol = "\uf005",
                        SymbolColor = Color.White,
                        AutoCloseTimeOut = 60,
                        Text = $"您有 {list.Count} 个待处理的提示信息，点击查看...",
                        AlertId = 0
                    };
                    alertWindow.Click += AlertWindow_Click;
                    alertWindow.Show();
                }
                catch (Exception ex)
                {
                    MessageHelper.ShowError(ex);
                }
            }
        }

        private void AlertWindow_Click(object sender, EventArgs e)
        {
            try
            {
                var win = (DesktopAlertWindow)sender;
                SetMdiForm("提示信息", Type.GetType("ChangKeTec.Wms.WinForm.Manage.FormNotify"));
                win.Close();
            }
            catch (Exception)
            {
            }
        }
        
    }
}

