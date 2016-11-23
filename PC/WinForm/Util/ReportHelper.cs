using System;
using System.Linq;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;
using gregn6Lib;

namespace ChangKeTec.Wms.WinForm.Util
{
    public static class ReportHelper
    {
        public static void Print(GridppReport report)
        {
            try
            {
                
                if (GlobalVar.PrintType == PrintType.PrintPreview)
                    report.PrintPreview(true);
                else
                    report.Print(true);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowInfo(ex.Message);
            }
        }


        public static GridppReport InitReport( BillType billType)
        {
            var taBilltype = GlobalBuffer.BillTypeList.Single(p => p.BillType == (int)billType);
            var report = new GridppReport();
            try
            {
                if (string.IsNullOrEmpty(taBilltype.PrintTemplateFileName)) return report;
                report.LoadFromFile(IoHelper.GetDllPath() + GlobalVar.PrintTemplatePath + taBilltype.PrintTemplateFileName);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
            return report;
        }


        

        public static void _report_Initialize(GridppReport report,TB_BILL bill,string detailTableName,string indexColumnName)
        {
            Console.WriteLine(report.Parameters.Count);
            report.ParameterByName("BillNum").AsString = bill.BillNum;
            report.ParameterByName("SourceBillNum").AsString = bill.SourceBillNum;
            report.ParameterByName("BillType").AsString = bill.BillType.ToString();
            report.ParameterByName("SubBillType").AsString = bill.SubBillType.ToString();
            report.ParameterByName("BillTime").AsString = bill.BillTime.ToString(GlobalVar.LongTimeString);
            report.ParameterByName("StartTime").AsString = bill.StartTime;
            report.ParameterByName("FinishTime").AsString = bill.FinishTime;
            report.ParameterByName("SplyId").AsString = bill.SplyId;
            report.ParameterByName("OperName").AsString = bill.OperName;
            report.ParameterByName("State").AsString = bill.State.ToString();
            report.ParameterByName("Remark").AsString = bill.Remark;
            report.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.ConnectionString = EntitiesFactory.WmsConnectionString;
            report.DetailGrid.Recordset.QuerySQL = $"select * from {detailTableName} where {indexColumnName} = '{bill.BillNum}'";
        }
        

        

    }
}