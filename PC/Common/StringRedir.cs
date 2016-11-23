using System;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace ChangKeTec.Wms.Common
{
    public class StringRedir : StringWriter
    {
        private readonly TextBox _textbox;
        private ListView _listView;
        public StringRedir(ref TextBox textBox)
        {
            _textbox = textBox;
        }

        public StringRedir(ref ListView listView)
        {
            _listView = listView;
            _listView.View = View.Details;
            _listView.GridLines = true;
            var colTime = new ColumnHeader {Text = "时间",Width = 180};
            var colMessage = new ColumnHeader {Text = "内容",Width = 1000};
            _listView.Columns.Add(colTime);
            _listView.Columns.Add(colMessage);
        }


        delegate void WriteLineCallBack(string text);

//        public override void WriteLine(string value)
//        {
//            if (_textbox.InvokeRequired)
//            {
//                WriteLineCallBack writeLineCallBack = WriteLine;
//                _textbox.Invoke(writeLineCallBack, value);
//            }
//            else
//            {
//                if (_textbox.Lines.Length > 1000)
//                    _textbox.Text = string.Empty;
//                _textbox.AppendText(DateTime.Now + "\t" + value + Environment.NewLine);
//                _textbox.ScrollToCaret();
//            }
//          
//            Util.LogHelper.Write(value);
//        }

        public override void WriteLine(string value)
        {

            if (_listView.InvokeRequired)
            {
                WriteLineCallBack writeLineCallBack = WriteLine;
                if (_listView == null || _listView.IsDisposed)
                {
                    _listView = new ListView();
                    return;
                }
                _listView.BeginInvoke(writeLineCallBack, value);
            }
            else
            {
                if (_listView.Items.Count > 2000)
                {
                    _listView.Items.Clear();
                }
                var item = new ListViewItem {Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff")};
                item.SubItems.Add(value);
                _listView.Items.Add(item);
                
                item.EnsureVisible();
                //                _textbox.AppendText(DateTime.Now + "\t" + value + Environment.NewLine);
                //                _textbox.ScrollToCaret();
                Utils.LogHelper.Write(value);
            }

        }


        //        public override void Write(string value)
        //        {
        //            _textbox.Text += value;
        //        }
    }
}