using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChangKeTec.Wms.Utils
{
    public class ProcessOperator
    {
        private readonly BackgroundWorker _backgroundWorker;//后台线程
        private readonly FormProcess _processForm;//进度条窗体
        private readonly BackgroundWorkerEventArgs _eventArgs;//异常参数
        public ProcessOperator()
        {
            _backgroundWorker = new BackgroundWorker();
            _processForm = new FormProcess();
            _eventArgs = new BackgroundWorkerEventArgs();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
        }

        //操作进行完毕后关闭进度条窗体
        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_processForm.Visible == true)
            {
                _processForm.Close();
            }
            if (this.BackgroundWorkerCompleted != null)
            {
                this.BackgroundWorkerCompleted(null, _eventArgs);
            }
        }

        //后台执行的操作
        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (BackgroundWork == null) return;
            try
            {
                BackgroundWork();
            }
            catch (Exception ex)
            {
                _eventArgs.BackGroundException = ex;
                MessageBox.Show(ex.ToString());
            }
        }

        #region 公共方法、属性、事件

        /// <summary>
        /// 后台执行的操作
        /// </summary>
        public Action BackgroundWork { get; set; }

        /// <summary>
        /// 设置进度条显示的提示信息
        /// </summary>
        public string MessageInfo
        {
            set { _processForm.MessageInfo = value; }
        }

        /// <summary>
        /// 后台任务执行完毕后事件
        /// </summary>
        public event EventHandler<BackgroundWorkerEventArgs> BackgroundWorkerCompleted;

        /// <summary>
        /// 开始执行
        /// </summary>
        public void Start()
        {
            _backgroundWorker.RunWorkerAsync();
            _processForm.ShowDialog();
        }

        #endregion
    }
}


/*
        private void CreateWorksheet(Application excel, Worksheet sheet, DataTable dt, string fileName)
        {
            Range r = null;
            int rIdx = RStartIndex;
            int cIdx = CStartIndex;
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
                r.Interior.ColorIndex = 37;
            }

            //因为第一行已经写了表头，所以所有数据都应该从a2开始
            r = sheet.Range[excel.Cells[rIdx, cIdx], excel.Cells[rIdx, cIdx]];

            WriteData(dt, sheet);

            int rSumIdx = dt.Rows.Count + 1;
            int cSumIdx = CStartIndex + 1;


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


            r = sheet.Range[excel.Cells[0, 0], null];

            //
            //显示效果
            //
            excel.Visible = false;
            excel.DisplayAlerts = false;
            excel.AlertBeforeOverwriting = false;
        }

        private void AddWorksheet(Application excel, Worksheet sheet, DataTable dt, string fileName)
        {
            Range r = null;
            int rIdx = RStartIndex;
            int cIdx = CStartIndex;
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
                r.Interior.ColorIndex = 37;
            }

            //因为第一行已经写了表头，所以所有数据都应该从a2开始
            r = sheet.Range[excel.Cells[rIdx, cIdx], excel.Cells[rIdx, cIdx]];
            WriteData(dt, sheet);


            int rSumIdx = dt.Rows.Count + 1;
            int cSumIdx = CStartIndex + 1;
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
            //
            //显示效果
            //
            r = sheet.Range[excel.Cells[0, 0], null];
            excel.Visible = false;
            excel.DisplayAlerts = false;
            excel.AlertBeforeOverwriting = false;
        }

*/


//1、全表自动列宽

//  mysheet.Cells.Select();

//  mysheet.Cells.Columns.AutoFit();

// 2、合并   

//  excelRangeParm.Merge(Missing.Value);   

// 3、粗体设置   

//  excelRangeParm.Font.Bold   =   true;   

// 4、字体大小设置   

//  excelRangeParm.Font.Size   =   12;   

// 5、水平对齐设置   

//  excelRangeParm.HorizontalAlignment   =   Excel.XlHAlign.xlHAlignCenter;   

// 6、垂直对齐设置   

//  excelRangeParm.VerticalAlignment   =   Excel.XlVAlign.xlVAlignCenter;   

// 7、公式设置   

//  excelRangeParm.FormulaR1C1   =   公式;   

// 8、列宽设置   

//  excelRange.ColumnWidth   =   宽度;   

// 9、行高   

//  excelRange.RowHeight   =   行高;

// 10、设置列格式   

//  Excel.Range   myrange=mysheet.get_Range(mysheet.Cells[1,1],mysheet.Cells[5,1]);   

// 11、文本格式

//  myrange.NumberFormatLocal="@";

// 12、通用格式

//  style.NumberFormatLocal = "[DBNum2][$-804]G/通用格式";  

//  或

//  range.NumberFormatLocal = "G/通用格式";

//  xlsheet.Cells[1,1]="''+txtKey.Text;

// 13、添加行

//  ((Excel.Range)mysheet.Cells[15,3]).EntireRow.Insert(0);        

// 14、设置第10行为红色   

//  mysheet.get_Range((Excel.Range)mysheet.Cells[10,1],(Excel.Range)mysheet.Cells[10,200]).Select();   

//  mysheet.get_Range((Excel.Range)mysheet.Cells[10,1],(Excel.Range)mysheet.Cells[10,200]).Interior.ColorIndex=3; 

//15、单元格自动换行

//myrange.WrapText = true; 

//16、单元格行高自动调整

//myrange.EntireRow.AutoFit();