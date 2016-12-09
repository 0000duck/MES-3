using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;

namespace ChangKeTec.Wms.Common
{
    public static class DataGridViewHelper
    {
        public static void FormatRow(DataGridViewX dgv, DataGridViewCellPaintingEventArgs e,string colName)
        {
            if (e.RowIndex < 0||e.ColumnIndex<0) return;
            if (dgv.Rows.Count == 0) return;
            var obj = dgv.Rows[e.RowIndex].Cells[colName];
            if(obj==null) return;
            string strState = obj.Value.ToString();
            BillState state;
            if (Enum.TryParse(strState, true, out state))
            {
                Color rowBackColor;
                switch (state)
                {
                    case BillState.New:
                        rowBackColor = Color.LightGreen;
                        break;
                    case BillState.Handling:
                        rowBackColor = Color.Khaki;
                        break;
                    case BillState.Cancelled:
                        rowBackColor = Color.Pink;
                        break;
                    case BillState.Finished:
                        rowBackColor = Color.LightGray;
                        break;
                    default:
                        rowBackColor = Color.White;
                        break;
                }
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowBackColor;
            }
        }

        public static void FormatDetail(DataGridViewX dgv, DataGridViewCellPaintingEventArgs e, string colName)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgv.Rows.Count == 0) return;
            DataGridViewCell obj=null;
            if (dgv.Columns.Contains("PartDesc1"))
            {
                obj = dgv.Rows[e.RowIndex].Cells["PartDesc1"];
            }
            else if (dgv.Columns.Contains("dcPartName"))
            {
                obj = dgv.Rows[e.RowIndex].Cells["dcPartName"];
            }
            if (obj?.Value == null) return;
            string partName = obj.Value.ToString();
            if (partName==string.Empty) return;
            var cell = dgv.Rows[e.RowIndex].Cells[colName];
            if (cell == null) return;
            Color cellColor;
            if (partName.Contains("黑"))
            {
                cellColor = Color.Black;
            }
            else if (partName.Contains("灰"))
            {
                cellColor = Color.LightGray;
            }
            else if (partName.Contains("米"))
            {
                cellColor = Color.SeaShell;
            }
            else if (partName.Contains("棕"))
            {
                cellColor = Color.SaddleBrown;
            }
            else
            {
                cellColor = Color.White;
            }
            cell.Style.BackColor = cellColor;
        }

        public static DataTable DgvToTable(DataGridView dgv,string name)
        {
            DataTable dt = new DataTable {TableName = name};
            // 列强制转换
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if(!column.Visible)continue;
                DataColumn dc = new DataColumn(column.HeaderText);
                dt.Columns.Add(dc);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var dr = dt.NewRow();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    if (!column.Visible) continue;
                    dr[column.HeaderText] = Convert.ToString(row.Cells[column.Index].Value);
                }
                dt.Rows.Add(dr);
            }

//            for (int i = 0; i < dgv.Columns.Count; i++)
//            {
//                if (!dgv.Columns[i].Visible)
//                {
//                    continue;
//                }
//                DataColumn dc = new DataColumn(dgv.Columns[i].HeaderText);
//                dt.Columns.AddOrUpdate(dc);
//            }

            // 循环行
//            for (int row = 0; row < dgv.Rows.Count; row++)
//            {
//                DataRow dr = dt.NewRow();
//                for (int col = 0; col < dgv.Columns.Count; col++)
//                {
//                    if (!dgv.Columns[col].Visible)
//                    {
//                        continue;
//                    }
//                    dr[col] = Convert.ToString(dgv.Rows[row].Cells[col].Value);
//                }
//                dt.Rows.AddOrUpdate(dr);
//            }
            return dt;
        }

        public static DataTable DgvToTable(SuperGridControl dgv, string name)
        {
            DataTable dt = new DataTable { TableName = name };
            // 列强制转换
            foreach (GridColumn column in dgv.PrimaryGrid.Columns)
            {
                if (!column.Visible) continue;
                DataColumn dc = new DataColumn(column.Name);
                dt.Columns.Add(dc);
            }

            foreach (GridRow row in dgv.PrimaryGrid.Rows)
            {
                var dr = dt.NewRow();
                foreach (GridColumn column in dgv.PrimaryGrid.Columns)
                {
                    if (!column.Visible) continue;
                    dr[column.Name] = Convert.ToString(row.Cells[column].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public static DataTable DgvToTable(GridPanel dgv, string name)
        {
            DataTable dt = new DataTable {TableName = name};
            // 列强制转换
            foreach (GridColumn column in dgv.Columns)
            {
                if (!column.Visible) continue;
                DataColumn dc = new DataColumn(column.DataPropertyName);
                dt.Columns.Add(dc);
            }

            foreach (var gridElement in dgv.Rows)
            {
                var row = (GridRow) gridElement;

                var dr = dt.NewRow();
                foreach (GridColumn column in dgv.Columns)
                {
                    if (!column.Visible) continue;
                    dr[column.DataPropertyName] = Convert.ToString(row.Cells[column.ColumnIndex].Value);
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }


        public static DataTable ImportFileToDataTable()
        {
            var dt= new DataTable();
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Execl files (*.xls,*.xlsx)|*.xls;*.xlsx",
                RestoreDirectory = true
            };
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (openFileDialog.ShowDialog() != DialogResult.OK) return dt;
            var excelFile = openFileDialog.FileName;
            ExcelReader excelReader = new ExcelReader();
            dt = excelReader.ReturnDataTable(excelFile, "");
            if (dt.Rows.Count==0)
            {
                MessageHelper.ShowInfo("Excel文件无数据！");
                return dt;
            }

            return dt;
        }
    }
}