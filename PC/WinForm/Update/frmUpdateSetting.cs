using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using ChangKeTec.Wms.Common;
using ChangKeTec.Wms.Controllers;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using ChangKeTec.Wms.WinForm.Util;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using gregn6Lib;
using System.Windows.Forms;


namespace ChangKeTec.Wms.WinForm.Update
{
    public partial class frmUpdateSetting : Office2007Form
    {
        private SpareEntities _db = EntitiesFactory.CreateSpareInstance();
        Updates locals = new Updates();
        Updates servers = null;
        Updates.grdRecord[] gr = null;
        public frmUpdateSetting()
        {
            InitializeComponent();       
        }

        private void frmUpdateSetting_Load(object sender, EventArgs e)
        {
            RefreshData();
            IniColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                btnSave.Enabled = false;
                SaveData();
            }
            finally
            {
                btnSave.Enabled = true;
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void RefreshData()
        {
            locals.Clear();
            UpdateControl.GetLocalFilesInfo(locals, new System.IO.DirectoryInfo(Application.StartupPath));

            servers = UpdateControl.GetServerFilesInfo();
            if (servers == null)
            {
                servers = new Updates();
            }
            gr = new Updates.grdRecord[locals.Count];
            for (int i = 0; i < locals.Count; i++)
            {
                gr[i] = new Updates.grdRecord(locals[i].FileName, locals[i].ModifyDate.ToString(), "", locals[i].FileSize.ToString(), "", locals[i].FullName);
            }
            foreach (UpdateItem item in servers)
            {
                for (int i = 0; i < gr.Length; i++)
                {
                    if (gr[i].FileName == item.FileName)
                    {
                        gr[i].sFileSize = item.FileSize.ToString();
                        gr[i].sModifyDate = item.ModifyDate.ToString();
                        break;
                    }
                }
            }
            for (int i = 0; i < gr.Length; i++)
            {
                if (gr[i].sFileSize == "" || gr[i].sModifyDate == "" || DateTime.Parse(gr[i].sModifyDate) < DateTime.Parse(gr[i].lModifyDate))
                {
                    gr[i].Check = true;
                }
                if (gr[i].FileName.ToUpper() == System.IO.Path.GetFileName(Application.ExecutablePath).ToUpper())
                {
                    gr[i].Check = true;
                }
            }
            grid.PrimaryGrid.DataSource = gr;
        }

        protected void IniColumns()
        {
            GridColumnCollection columns = grid.PrimaryGrid.Columns;
            ColumnGroupHeader cghFile = new ColumnGroupHeader();
            cghFile.Name = "cghFile";
            cghFile.HeaderText = "文件";
            cghFile.MinRowHeight = 40;
            cghFile.StartDisplayIndex = columns.GetDisplayIndex(columns[0]);
            cghFile.EndDisplayIndex = columns.GetDisplayIndex(columns[1]);
            grid.PrimaryGrid.ColumnHeader.GroupHeaders.Add(cghFile);

            var cghLoc = new ColumnGroupHeader();
            cghLoc.Name = "cghLoc";
            cghLoc.HeaderText = "本地版本";
            cghLoc.MinRowHeight = 40;
            cghLoc.StartDisplayIndex = columns.GetDisplayIndex(columns[2]);
            cghLoc.EndDisplayIndex = columns.GetDisplayIndex(columns[3]);
            grid.PrimaryGrid.ColumnHeader.GroupHeaders.Add(cghLoc);

            var cghSer = new ColumnGroupHeader();
            cghSer.Name = "cghLoc";
            cghSer.HeaderText = "服务器版本";
            cghSer.MinRowHeight = 40;
            cghSer.StartDisplayIndex = columns.GetDisplayIndex(columns[4]);
            cghSer.EndDisplayIndex = columns.GetDisplayIndex(columns[5]);
            grid.PrimaryGrid.ColumnHeader.GroupHeaders.Add(cghSer);
        }

        private void SaveData()
        {
            int iFind = -1;
            SpareEntities db = EntitiesFactory.CreateSpareInstance(); 
            for (int i = 0; i < gr.Length; i++)
            {
                if (gr[i].Check)
                {
                    FileStream fs = new FileStream(gr[i].FullName, FileMode.Open, FileAccess.Read);
                    UpdateControl.SaveFile2DB(db,"Update", gr[i].FileName, fs);
                    iFind = servers.Find(gr[i].FileName);
                    if (iFind >= 0)
                    {
                        if (servers[iFind].ModifyDate < DateTime.Parse(gr[i].lModifyDate))
                        {
                            servers[iFind].ModifyDate = DateTime.Parse(gr[i].lModifyDate);
                            servers[iFind].FileSize = long.Parse(gr[i].lFileSize);
                        }
                    }
                    else
                    {
                        UpdateItem item = new UpdateItem();
                        item.FileName = gr[i].FileName;
                        item.FileSize = long.Parse(gr[i].lFileSize);
                        item.ModifyDate = DateTime.Parse(gr[i].lModifyDate);
                        servers.Add(item);
                    }
                }
            }
            UpdateControl.SaveObj(db,"Updates", "Updates", servers);
            EntitiesFactory.SaveDb(db);
            MessageHelper.ShowInfo("保存成功!");
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var row in grid.PrimaryGrid.Rows)
            {
                var gridrow = (GridRow)row;
                gridrow[gcCheck].Value = true;
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var row in grid.PrimaryGrid.Rows)
            {
                var gridrow = (GridRow)row;
                gridrow[gcCheck].Value = false;
                if (String.Equals(gridrow[gclFile].Value.ToString(), Path.GetFileName(Application.ExecutablePath),
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    gridrow[gcCheck].Value = true;
                }
            }
        }
    }
}
