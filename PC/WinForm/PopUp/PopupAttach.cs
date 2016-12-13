    using System;
using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
using System.Linq.Expressions;
    using System.Windows.Forms;
    using ChangKeTec.Wms.Common.ComboBox;
    using ChangKeTec.Wms.Controllers.BaseData;
    using ChangKeTec.Wms.Models;
    using ChangKeTec.Wms.Utils;
    using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.WinForm.PopUp
{
    public partial class PopupAttach : Office2007Form
    {
        public string TableName { get; set; }
        public int TablePKID { get; set; }

        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        private GridRow _selectrow;
        public PopupAttach()
        {
            InitializeComponent();
        }

        private void PopupAttach_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "文件(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var attach = new TA_Attach()
                {
                    TableName = TableName,
                    TablePKID = TablePKID,
                    CreateDate = DateTime.Now,
                    CreatorName = GlobalVar.Oper.OperName,
                    FileName = Path.GetFileName(dlg.FileName)
                };
                FileStream fs = File.OpenRead(dlg.FileName);
                fs.Position = 0;
                byte[] blobdata = new Byte[fs.Length];
                fs.Read(blobdata, 0, (int)fs.Length);
                attach.FileData = blobdata;               
                fs.Close();
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                AttachController.AddOrUpdate(db,attach,GlobalVar.Oper);               
                EntitiesFactory.SaveDb(db);
                MessageHelper.ShowInfo("保存成功！");
                RefreshData();
            }
        }

        private void grid_CellActivated(object sender, GridCellActivatedEventArgs e)
        {
            int rowindex = e.NewActiveCell.RowIndex;
            _selectrow = (GridRow)grid.PrimaryGrid.Rows[rowindex];

        }

        private void grid_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            ViewFile();
        }

        private void grid_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_selectrow == null)
            {
                MessageHelper.ShowError("请选择要删除的附件！");
                return;
            }
            if (MessageHelper.ShowQuestion("确认要删除选中的附件吗？") == DialogResult.Yes)
            {
                SpareEntities db = EntitiesFactory.CreateSpareInstance();
                var attach = AttachController.GetList(_db).FirstOrDefault(p => p.UID == (int) _selectrow[gcUID].Value);
                AttachController.Delete(db, attach, GlobalVar.Oper);
                EntitiesFactory.SaveDb(db);
                MessageHelper.ShowInfo("删除成功！");
                RefreshData();
            }
        }

        private void ItemBtnExport_Click(object sender, EventArgs e)
        {
            if (_selectrow == null)
            {
                MessageHelper.ShowError("请选择要导出的附件！");
                return;
            }
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = _selectrow[gcFileName].Value.ToString();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                byte[] blobdata = (byte[])(_selectrow[gcFileData].Value);
                if (blobdata.Length == 0)
                {
                    return;
                }
                FileStream fs = File.Create(dlg.FileName);
                fs.Write(blobdata, 0, blobdata.Length);
                fs.Position = 0;
                fs.Close();
                MessageHelper.ShowInfo("完成!");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewFile();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var _attachlist =
                AttachController.GetList(_db).Where(p => p.TableName == TableName && p.TablePKID == TablePKID).ToList();
            grid.PrimaryGrid.DataSource = _attachlist;
        }

        private void ViewFile()
        {
            if (_selectrow == null)
            {
                MessageHelper.ShowError("请选择要查看的附件！");
                return;
            }
            SaveFileDialog dlg = new SaveFileDialog();
            string tmpfile = System.IO.Path.GetTempPath() + @"\" + _selectrow[gcFileName].Value.ToString();
            byte[] blobdata = (byte[])_selectrow[gcFileData].Value;
            if (blobdata.Length == 0)
            {
                return;
            }
            FileStream fs = File.Create(tmpfile);
            fs.Write(blobdata, 0, blobdata.Length);
            fs.Position = 0;
            fs.Close();
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(tmpfile);
            System.Diagnostics.Process Pro = System.Diagnostics.Process.Start(Info);
        }
    }
}
