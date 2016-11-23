using System;
using System.Text;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.Models
{
  /*
    public class ReturnResult
    {
        private const string SP = ";";
        public ResultCode ResultCode { get; set; }
        public string IndexString { get; set; }
        public string ResultString { get; set; }

        public ReturnResult()
        {
            ResultCode = Enums.ResultCode.Success;
            IndexString = "";
            ResultString = "";

        }

        public ReturnResult(ResultCode code,string index,string text)
        {
            ResultCode = code;
            IndexString = index;
            ResultString = text;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(EnumHelper.GetDescription(ResultCode)+SP);
            sb.Append(IndexString+SP);
            sb.Append(ResultString+SP);
            return sb.ToString();
        }
    }
*/
    [Serializable] //声明为可序列化的 因为要写入文件中  
    public class WmsException : ApplicationException//由用户程序引发，用于派生自定义的异常类型  
    {
        private const string SP = ";";
//        private ResultCode _code;
//        private string _indexString;
        public ResultCode Code { get; set; }
        public string IndexString { get; set; }

        /// <summary>  
        /// 默认构造函数  
        /// </summary>  
        public WmsException()
        {
        }

        public WmsException(ResultCode code, string indexString = null,string message=null, Exception inner = null)
            : base(message, inner)
        {
            Code = code;
            IndexString = indexString;
        }

//        public WmsException(System.Runtime.Serialization.SerializationInfo info,
//            System.Runtime.Serialization.StreamingContext context) : base(info, context)
//        {
//            _indexString = info.GetString(IndexString);
//        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(EnumHelper.GetDescription(Code) + SP);
            sb.Append(IndexString + SP);
            sb.Append(Message + SP);
            return sb.ToString();
        }
    }
}