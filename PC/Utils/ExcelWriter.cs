using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace ChangKeTec.Wms.Utils
{
    public class ExcelReader

    {

        private DataSet _dsExcel;
        private DataTable _dtExcel;
        private string _fileExt;
        private string _filePath;
        private List<string> _readSheetName;
        //        private string _saveFileName;
        private string _sheetName;
        private List<string> _sheetNames;

        /// <summary>
        ///     读取Excel文件到DataSet
        /// </summary>
        /// <returns></returns>
        public DataSet ReturnDataSet()
        {
            var openFileDialog = new OpenFileDialog { Filter = "Execl files (*.xls,*.xlsx)|*.xls;*.xlsx" };
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
                _fileExt = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('.'));
                var poDv = new ProcessOperator { BackgroundWork = ReadExcelToDataSet };
                poDv.BackgroundWorkerCompleted += ReadExcel_Completed;
                poDv.Start();
            }
            return _dsExcel;
        }

        /// <summary>
        ///     读取Excel文件到DataSet
        /// </summary>
        /// <param name="filePath">Excel文件地址</param>
        /// <returns></returns>
        public DataSet ReturnDataSet(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                    return ReturnDataSet();
                _filePath = filePath;
                _fileExt = filePath.Substring(filePath.LastIndexOf('.'));

                if (_fileExt.ToUpper() == ".XLSX" || _fileExt.ToUpper() == ".XLS")
                {
                    var poDv = new ProcessOperator { BackgroundWork = ReadExcelToDataSet };
                    poDv.BackgroundWorkerCompleted += ReadExcel_Completed;
                    poDv.Start();
                }
                else
                {
                    MessageBox.Show("无法解析该后缀名的文件！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dsExcel;
        }


        /// <summary>
        ///     读取Excel文件到DataSet
        /// </summary>
        /// <param name="sheetNames">读取Excel文件工作表名称集合</param>
        /// <returns></returns>
        public DataSet ReturnDataSet(List<string> sheetNames)
        {
            var openFileDialog = new OpenFileDialog { Filter = "Execl files (*.xls,*.xlsx)|*.xls;*.xlsx" };
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _sheetNames = sheetNames;
                _filePath = openFileDialog.FileName;
                _fileExt = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('.'));
                var poDv = new ProcessOperator { BackgroundWork = ReadExcelToDataSet };
                poDv.BackgroundWorkerCompleted += ReadExcel_Completed;
                poDv.Start();
            }
            return _dsExcel;
        }

        /// <summary>
        ///     读取Excel文件到DataSet
        /// </summary>
        /// <param name="filePath">Excel文件地址</param>
        /// <param name="sheetNames">读取Excel文件表名称集合</param>
        /// <returns></returns>
        public DataSet ReturnDataSet(string filePath, List<string> sheetNames)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                    return ReturnDataSet();
                if (sheetNames == null || sheetNames.Count == 0)
                    return ReturnDataSet(filePath);

                _filePath = filePath;
                _fileExt = filePath.Substring(filePath.LastIndexOf('.'));
                _sheetNames = sheetNames;
                if (_fileExt.ToUpper() == ".XLSX" || _fileExt.ToUpper() == ".XLS")
                {
                    var poDv = new ProcessOperator { BackgroundWork = ReadExcelToDataSet };
                    poDv.BackgroundWorkerCompleted += ReadExcel_Completed;
                    poDv.Start();
                }
                else
                {
                    MessageBox.Show("无法解析该后缀名的文件！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dsExcel;
        }

        /// <summary>
        ///     读取Excel文件的sheet到DataTable
        /// </summary>
        /// <param name="sheetName">Excel文件表名称</param>
        /// <returns></returns>
        public DataTable ReturnDataTable(string sheetName)
        {
            var openFileDialog = new OpenFileDialog { Filter = "Execl files (*.xls,*.xlsx)|*.xls;*.xlsx" };
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
                _fileExt = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('.'));
                _sheetName = sheetName;
                var poDv = new ProcessOperator { BackgroundWork = ReadToDataTable };
                poDv.BackgroundWorkerCompleted += ReadExcel_Completed;
                poDv.Start();
            }
            return _dtExcel;
        }

        /// <summary>
        ///     读取Excel文件的sheet到DataTable
        /// </summary>
        /// <param name="filePath">Excel文件地址</param>
        /// <param name="sheetName">Excel文件表名称</param>
        /// <returns></returns>
        public DataTable ReturnDataTable(string filePath, string sheetName)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                    return ReturnDataTable(sheetName);
                _filePath = filePath;
                _fileExt = filePath.Substring(filePath.LastIndexOf('.'));

                if (_fileExt.ToUpper() == ".XLSX" || _fileExt.ToUpper() == ".XLS")
                {
                    _sheetName = sheetName;
                    var poDv = new ProcessOperator { BackgroundWork = ReadToDataTable };
                    poDv.BackgroundWorkerCompleted += ReadExcel_Completed;
                    poDv.Start();
                }
                else
                {
                    MessageBox.Show("无法解析该后缀名的文件！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dtExcel;
        }

        private void ReadExcel_Completed(object sender, BackgroundWorkerEventArgs e)
        {
            if (e.BackGroundException == null)
            {
                //if (readSheetName != null && readSheetName.Count > 0)
                //{
                //    //StringBuilder sb = new StringBuilder();
                //    //sb.Append("文件读取成功！\n\r已在" + filePath + "下\n\r读取了 " + readSheetName.Count.ToString() + " 张Sheet工作表\n\r分别是：\n\r");
                //    //int i = 0;
                //    //foreach (String SheetName in readSheetName)
                //    //{
                //    //    i ++;
                //    //    sb.Append(SheetName + ",");
                //    //    if (i % 3 == 0)
                //    //    {
                //    //        sb.Append("\n\r");
                //    //    }
                //    //}
                //    //String message = sb.ToString();
                //    //message = message.Substring(0, message.Length - 1);
                //    //System.Windows.Forms.MessageBox.Show(message);

                //}
                //else
                //{
                //    MessageBox.Show("文件读取成功！\n\r已在" + filePath + "下\n\r读取了 0 张Sheet工作表");
                //}
                if (_readSheetName == null || _readSheetName.Count == 0)
                {
                    MessageBox.Show("文件读失败，未找到符合的系统要求的工作表！");
                }
            }
            else
            {
                //MessageBox.Show("文件读取失败！\n\r已在" + filePath + "下\n\r读取了 0 张Sheet工作表\n\r请稍后在试！");
                MessageBox.Show("文件读取失败,请联系管理员！");
            }
        }

        private void ReadExcelToDataSet()
        {
            OleDbConnection connExcel = null;
            try
            {
                _readSheetName = new List<string>();
                _dsExcel = new DataSet();

                var connString = "";
                if (_fileExt.ToUpper() == ".XLSX")
                {
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _filePath +
                                 ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";
                }
                else
                {
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + _filePath +
                                 ";Extended Properties = 'Excel 8.0;HDR=YES;IMEX=1'";
                }
                connExcel = new OleDbConnection(connString);
                connExcel.Open();
                var dtSheetNames = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                var sqlExcel = "";
                OleDbDataAdapter myCommand = null;
                var tableName = "";
                var selectTable = "";
                if (_sheetNames != null && _sheetNames.Count > 0)
                {
                    foreach (var sheetName in _sheetNames)
                    {
                        Debug.Assert(dtSheetNames != null, "dtSheetNames != null");
                        for (var i = 0; i < dtSheetNames.Rows.Count; i++)
                        {
                            var res = 0;
                            tableName = dtSheetNames.Rows[i]["TABLE_NAME"].ToString().Replace("'", "").Replace("$", "");
                            selectTable = dtSheetNames.Rows[i]["TABLE_NAME"].ToString();
                            if (tableName.Length <= 4 || tableName.Equals("_xlnm#_FilterDatabase") ||
                                !int.TryParse(tableName.Substring(0, 4), out res) ||
                                tableName.IndexOf("_", StringComparison.Ordinal) == (tableName.Length - 1) ||
                                tableName.IndexOf("FilterDatabase", StringComparison.Ordinal) != -1) continue;
                            if (!(tableName.Replace("'", "").Replace("$", "")).Equals(sheetName)) continue;
                            sqlExcel = string.Format(" select * from  [" + selectTable + "]");
                            myCommand = new OleDbDataAdapter(sqlExcel, connString);
                            myCommand.Fill(_dsExcel, tableName);
                            RemoveEmptyRow(_dsExcel.Tables[tableName]);
                            _readSheetName.Add(tableName);
                            break;
                        }
                    }
                }
                else
                {
                    Debug.Assert(dtSheetNames != null, "dtSheetNames != null");
                    for (var i = 0; i < dtSheetNames.Rows.Count; i++)
                    {
                        var res = 0;
                        tableName = dtSheetNames.Rows[i]["TABLE_NAME"].ToString().Replace("'", "").Replace("$", "");
                        selectTable = dtSheetNames.Rows[i]["TABLE_NAME"].ToString();
                        if (tableName.Length <= 4 || tableName.Equals("_xlnm#_FilterDatabase") ||
                            !int.TryParse(tableName.Substring(0, 4), out res) ||
                            tableName.IndexOf("_", StringComparison.Ordinal) == (tableName.Length - 1) ||
                            tableName.IndexOf("FilterDatabase", StringComparison.Ordinal) != -1) continue;
                        sqlExcel = string.Format(" select * from  [" + selectTable + "]");
                        myCommand = new OleDbDataAdapter(sqlExcel, connString);
                        myCommand.Fill(_dsExcel, tableName);
                        RemoveEmptyRow(_dsExcel.Tables[tableName]);
                        _readSheetName.Add(tableName);
                    }
                }
                connExcel.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connExcel != null)
                {
                    connExcel.Close();
                }
            }
        }


        private void ReadToDataTable()
        {
            OleDbConnection connExcel = null;
            try
            {
                _readSheetName = new List<string>();
                _dsExcel = new DataSet();
                var connString = "";
                if (_fileExt.ToUpper() == ".XLSX")
                {
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _filePath +
                                 ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";
                }
                else
                {
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + _filePath +
                                 ";Extended Properties = 'Excel 8.0;HDR=YES;IMEX=1'";
                }
                connExcel = new OleDbConnection(connString);
                connExcel.Open();
                var dtSheetNames = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                var sqlExcel = "";
                OleDbDataAdapter myCommand = null;
                var tableName = "";
                var selectTable = "";
                if (string.IsNullOrEmpty(_sheetName))
                {
                    var b = true;
                    var i = 0;
                    while (b)
                    {
                        if (dtSheetNames != null)
                        {
                            tableName = dtSheetNames.Rows[i]["TABLE_NAME"].ToString().Replace("'", "").Replace("$", "");
                            selectTable = dtSheetNames.Rows[i]["TABLE_NAME"].ToString();
                        }
//                        int res;
                        if (tableName.Length <= 4 
                            || tableName.Equals("_xlnm#_FilterDatabase") 
//                            || !int.TryParse(tableName.Substring(0, 4), out res) 
                            || tableName.IndexOf("_", StringComparison.Ordinal) == (tableName.Length - 1) 
                            || tableName.IndexOf("FilterDatabase", StringComparison.Ordinal) != -1
                            )
                        {
                            if (dtSheetNames != null && i < dtSheetNames.Rows.Count)
                            {
                                i++;
                            }
                            else
                            {
                                b = false;
                            }
                        }
                        else
                        {
                            sqlExcel = string.Format(" select * from  [" + selectTable + "]");
                            myCommand = new OleDbDataAdapter(sqlExcel, connString);
                            myCommand.Fill(_dsExcel, tableName);
                            RemoveEmptyRow(_dsExcel.Tables[tableName]);
                            _dtExcel = _dsExcel.Tables[0];
                            _readSheetName.Add(tableName);
                            b = false;
                        }
                    }
                }
                else
                {
                    Debug.Assert(dtSheetNames != null, "dtSheetNames != null");
                    for (var i = 0; i < dtSheetNames.Rows.Count; i++)
                    {
                        tableName = dtSheetNames.Rows[i]["TABLE_NAME"].ToString().Replace("'", "").Replace("$", "");
                        selectTable = dtSheetNames.Rows[i]["TABLE_NAME"].ToString();
                        if (!(tableName).Equals(_sheetName)) continue;
                        sqlExcel = string.Format(" select * from  [" + selectTable + "]");
                        myCommand = new OleDbDataAdapter(sqlExcel, connString);
                        myCommand.Fill(_dsExcel, tableName);
                        RemoveEmptyRow(_dsExcel.Tables[tableName]);
                        _dtExcel = _dsExcel.Tables[_sheetName];
                        _readSheetName.Add(tableName);
                        return;
                    }
                }
                connExcel.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connExcel != null)
                {
                    connExcel.Close();
                }
            }
        }

        public static void RemoveEmptyRow(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
                return;
            var isEmpty = true;
            for (var idx = dt.Rows.Count - 1; idx >= 0; idx--)
            {
                var dr = dt.Rows[idx];
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() != string.Empty)
                    {
                        isEmpty = false;
                    }
                }
                if (isEmpty)
                    dt.Rows.Remove(dr);
            }
        }
    }



    public static class ExcelWriter
    {
        //ieachsize为每次写行的数值，可以自己设置
        private const int EachSize = 5000;
        private const int RStartIndex = 1;
        private const int CStartIndex = 0;

        public static readonly SaveFileDialog SaveFileDialog = new SaveFileDialog
        {
            Filter = "Excel 工作簿 (*.xlsx)|*.xlsx",
            CheckFileExists = false,
            CheckPathExists = false,
            FilterIndex = 0,
            RestoreDirectory = true,
            CreatePrompt = false,
            Title = "保存为Excel文件"
        };


        private static void SetWorkSheetValue(Application excel, Worksheet sheet, DataTable dt, string fileName)
        {
            Range r = null;
            var rIdx = RStartIndex;
            var cIdx = CStartIndex;
            if (!string.IsNullOrEmpty(dt.TableName))
            {
                sheet.Name = dt.TableName;
            }

            //
            //取得标题
            //
            foreach (DataColumn dc in dt.Columns)
            {
                cIdx++;
                excel.Cells[rIdx, cIdx] = dc.ColumnName;
                //设置标题格式为居中对齐
                r = sheet.Range[excel.Cells[rIdx, cIdx], excel.Cells[rIdx, cIdx]];
                r.HorizontalAlignment = XlVAlign.xlVAlignCenter;
                r.Interior.ColorIndex = 19;
            }

            //因为第一行已经写了表头，所以所有数据都应该从a2开始
            r = sheet.Range[excel.Cells[rIdx, cIdx], excel.Cells[rIdx, cIdx]];

            //irowcount为实际行数，最大行
            var irowcount = dt.Rows.Count;
            int iParstedRow = 0, iCurSize = 0;
            //ieachsize为每次写行的数值，可以自己设置

            //icolumnaccount为实际列数，最大列数
            var iColumnsCount = dt.Columns.Count;
            //在内存中声明一个ieachsize×icolumnaccount的数组，ieachsize是每次最大存储的行数，icolumnaccount就是存储的实际列数
            var objval = new object[EachSize, iColumnsCount];
            iCurSize = EachSize;
            while (iParstedRow < irowcount)
            {
                if ((irowcount - iParstedRow) < EachSize)
                    iCurSize = irowcount - iParstedRow;
                //用for循环给数组赋值
                for (var i = 0; i < iCurSize; i++)
                {
                    for (var j = 0; j < iColumnsCount; j++)
                    {
                        var s = dt.Rows[i + iParstedRow][j].ToString();
                        //////////////////
                        //格式化日期字段
                        var dc = dt.Columns[j];
                        if (dc.DataType.FullName == "System.DateTime" && s != null && s != "")
                        {
                            DateTime time;
                            DateTime.TryParse(s, out time);
                            s = time.ToString();
                        }
                        //////////////////
                        decimal d;
                        if (decimal.TryParse(s, out d))
                        {
                            if (Math.Round(d, 5) == 0)
                            {
                                objval[i, j] = string.Empty;
                                continue;
                            }
                        }
                        objval[i, j] = s;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                var X = "A" + (iParstedRow + 2);
                var col = "";
                if (iColumnsCount <= 26)
                {
                    col = ((char) ('A' + iColumnsCount - 1)) +
                          ((iParstedRow + iCurSize + 1)).ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    col = ((char) ('A' + (iColumnsCount/26 - 1))) +
                          ((char) ('A' + (iColumnsCount%26 - 1))).ToString() +
                          ((iParstedRow + iCurSize + 1));
                }
                r = sheet.Range[X, col];
                // 调用range的value2属性，把内存中的值赋给excel
                r.Value2 = objval;
                iParstedRow = iParstedRow + iCurSize;
            }

            var rSumIdx = dt.Rows.Count + 1;
            var cSumIdx = CStartIndex + 1;

            //                            //加载一个合计行
            //                            //
            //                            //excel.Cells[rowSum, 2] = "合计";
            //
            //            r = sheet.Range[excel.Cells[rSumIdx, 2], excel.Cells[rSumIdx, 2]];
            //                            r.HorizontalAlignment = XlVAlign.xlVAlignCenter;
            //            
            //                            //
            //设置选中的部分的颜色
            //
            r = sheet.Range[excel.Cells[2, cSumIdx], excel.Cells[2, cIdx]];
            r.Select();
            //设置为浅黄色，共计有56种
//            r.Interior.ColorIndex = 19;


            //
            //设置报表表格为最适应宽度
            //
            r = sheet.Range[excel.Cells[RStartIndex, cSumIdx], excel.Cells[rSumIdx, cIdx]];
            r.Select();
            r.Columns.AutoFit();


            //
            //绘制边框
            //
            r = sheet.Range[excel.Cells[RStartIndex, cSumIdx], excel.Cells[rSumIdx, cIdx]];
            r.Borders.LineStyle = 1;

            r = sheet.Range[excel.Cells[RStartIndex, cSumIdx], excel.Cells[rSumIdx, cSumIdx]];
            r.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlThick; //设置左边线加粗

            r = sheet.Range[excel.Cells[RStartIndex, cSumIdx], excel.Cells[RStartIndex, cIdx]];
            r.Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlThick; //设置上边线加粗

            r = sheet.Range[excel.Cells[RStartIndex, cIdx], excel.Cells[rSumIdx, cIdx]];
            r.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlThick; //设置右边线加粗

            r = sheet.Range[excel.Cells[rSumIdx, cSumIdx], excel.Cells[rSumIdx, cIdx]];
            r.Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlThick; //设置下边线加粗

            //r = sheet.Range[excel.Cells[0, 0], null];

            //
            //显示效果
            //
            excel.Visible = false;
            excel.DisplayAlerts = false;
            excel.AlertBeforeOverwriting = false;
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);

        private static void Kill(_Application excel)
        {
            try
            {
                var t = new IntPtr(excel.Hwnd);
                var k = 0;
                GetWindowThreadProcessId(t, out k);
                var p = Process.GetProcessById(k);
                p.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        ///     将DataTable数据写入Excel文件
        /// </summary>
        /// <param name="dt">DataTable</param>
        public static void Write(DataTable dt)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = SaveFileDialog.FileName;
                WriteDataTableToExcel(dt, fileName);
            }
        }


        /// <summary>
        ///     将DataTable数据写入Excel文件
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="fileName">Excel文件路径</param>
        public static void Write(DataTable dt, string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    Write(dt);
                }
                else
                {
                    WriteDataTableToExcel(dt, fileName);
                }
            }
            catch
            {
                MessageBox.Show("无法解析文件路径！");
            }
        }

        private static void WriteDataTableToExcel(DataTable dt, string fileName)
        {
            var fileExt = fileName.Substring(fileName.LastIndexOf('.'));
            if (fileExt.ToUpper() == ".XLSX")
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    var poDv = new ProcessOperator
                    {
                        BackgroundWork = () => WriteExcelByDataTable(dt, fileName)
                    };
                    poDv.BackgroundWorkerCompleted += WriteExcel_Completed;
                    poDv.Start();
                }
                else
                {
                    MessageBox.Show("当前表单没有任何数据");
                }
            }
            else
            {
                MessageBox.Show("无法解析该后缀名的文件！");
            }
        }

        //        /// <summary>
        //        ///     将DataSet数据写入Excel文件
        //        /// </summary>
        //        /// <param name="dsExcel">DataSet</param>
        //        public void Write(DataSet dsExcel)
        //        {
        //            if (dsExcel != null && dsExcel.Tables.Count > 0)
        //            {
        //                if (_saveFileDialog.ShowDialog() == DialogResult.OK)
        //                {
        //                    string fileName = _saveFileDialog.FileName; //得到存放路径
        //                    var poDv = new ProcessOperator
        //                        {
        //                            MessageInfo = @"正在写入" + Path.GetFileName(fileName) + "文件",
        //                            BackgroundWork = () => WriteExcelByDataSet(dsExcel, fileName)
        //                        };
        //                    poDv.BackgroundWorkerCompleted += WriteExcel_Completed;
        //                    poDv.Start();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("当前没有任何表单！");
        //            }
        //        }

        public static void Write(DataSet ds)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = SaveFileDialog.FileName;
                Write(ds, fileName);
            }
        }

        public static void Write(DataSet dsExcel, string fileName)
        {
            try
            {
                //                if (string.IsNullOrEmpty(fileName))
                //                {
                //                    Write(dsExcel);
                //                }
                //                else
                //                {
                if (dsExcel != null && dsExcel.Tables.Count > 0)
                {
                    if (File.Exists(fileName))
                        File.Delete(fileName);
                    //_saveFileDialog.FileName = fileName;
                    //if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //_writeSheetName = new List<string>();
                        foreach (DataTable dt in dsExcel.Tables)
                        {
                            if (dt == null || dt.TableName == null || dt.TableName == "") continue;
                            ExcelReader.RemoveEmptyRow(dt);
                            //string name = _saveFileDialog.FileName;
                            var dt1 = dt;
                            var poDv = new ProcessOperator
                            {
                                MessageInfo = @"正在写入" + Path.GetFileName(fileName) + "," + dt.TableName,
                                BackgroundWork = () => WriteExcelByDataTable(dt1, fileName)
                            };
                            poDv.Start();
                        }
                        WriteExcel_Completed(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("当前没有任何表单！");
                }
                //                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法解析文件路径！\n" + ex);
            }
        }

        private static void WriteExcelByDataTable(DataTable dt, string fileName)
        {
            //            if (_writeSheetName == null)
            //            {
            //                _writeSheetName = new List<string>();
            //            }

            Workbook workbook = null;
            Worksheet sheet = null;
            var excel = new Application();
            var miss = Missing.Value;
            try
            {
                if (File.Exists(fileName))
                {
                    workbook = excel.Workbooks.Open(fileName, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true,
                        false, 0, true, false, false);
                    var sheets = workbook.Sheets;
                    var existSheetName = string.Empty;
                    for (var i = 1; i <= sheets.Count; i++)
                    {
                        if (sheets[i].Name != dt.TableName) continue;
                        sheets[i].Name += "(副本)";
                        existSheetName = sheets[i].Name;
                    }
                    sheet = (Worksheet) sheets.Add(sheets[1], miss, miss, miss);

                    SetWorkSheetValue(excel, sheet, dt, fileName);

                    workbook.Save();
                    if (!string.IsNullOrEmpty(existSheetName))
                        sheets[existSheetName].Delete();
                }
                else
                {
                    workbook = excel.Workbooks.Add(true);
                    sheet = (Worksheet) workbook.ActiveSheet;
                    SetWorkSheetValue(excel, sheet, dt, fileName);
                    //                    workbook.SaveAs(fileName, XlFileFormat.xlOpenDocumentSpreadsheet, miss, miss, miss, miss,
                    //                                    XlSaveAsAccessMode.xlExclusive, miss, miss, miss, miss, miss);
                    workbook.SaveAs(fileName, miss, miss, miss, miss, miss,
                        XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss, miss);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                workbook.Close(true, Missing.Value, Missing.Value);
                excel.Quit();
                Kill(excel); //调用kill当前excel进程  
                ReleaseObject(workbook);
                ReleaseObject(sheet);
                ReleaseObject(excel);
            }
        }

        //        private void WriteExcelByDataSet(DataSet dsExcel, string fileName)
        //        {
        //            //_writeSheetName = new List<string>();
        //            foreach (DataTable dtExcel in dsExcel.Tables)
        //            {
        //                if (dtExcel == null || dtExcel.TableName == null || dtExcel.TableName == "") continue;
        //                ListHelper.RemoveEmptyRow(dtExcel);
        //                //_dtExcel = dt;
        //                WriteExcelByDataTable(dtExcel, fileName);
        //            }
        //        }

        private static void WriteExcel_Completed(object sender, BackgroundWorkerEventArgs e)
        {
            Process.Start(SaveFileDialog.FileName);
            //            MessageBox.Show("导出完成");
            //            MessageBox.Show(e.BackGroundException == null
            //                                ? Path.GetFileName(_filePath) + "文件写入成功！"
            //                                : Path.GetFileName(_filePath) + "文件写入失败,请联系管理员！");
        }
    }
}