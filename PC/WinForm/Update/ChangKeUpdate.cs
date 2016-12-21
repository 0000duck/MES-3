using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangKeTec.Wms.WinForm.Update
{
    [Serializable]
    public class UpdateItem
    {
        public string FileName { get; set; }
        public string FullName { get; set; }
        public long FileSize { get; set; }
        public DateTime ModifyDate { get; set; }
    }

    [Serializable]
    public class Updates : CollectionBase
    {
        public void Add(UpdateItem Item)
        {
            List.Add(Item);
        }

        public void Remove(int Index)
        {
            if (Index > Count - 1 || Index < 0)
            {
                throw new Exception("Index is not valid!");
            }
            else
            {
                List.RemoveAt(Index);
            }
        }

        public int Find(string sFileName)
        {
            int iReturn = -1;
            for (int i = 0; i < List.Count; i++)
            {
                if ((List[i] as UpdateItem).FileName == sFileName)
                {
                    iReturn = i;
                    break;
                }
            }
            return iReturn;
        }

        public virtual UpdateItem this[int Index]
        {
            get
            {
                return (UpdateItem)this.List[Index];
            }
        }

        public virtual UpdateItem this[string sFileName]
        {
            get
            {
                foreach (UpdateItem item in this.List)
                {
                    if (item.FileName == sFileName)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public class grdRecord
        {
            public bool Check { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }
            public string lModifyDate { get; set; }
            public string sModifyDate { get; set; }
            public string lFileSize { get; set; }
            public string sFileSize { get; set; }
            public grdRecord(string sFileName, string slModifyDate, string ssModifyDate, string slFileSize, string ssFileSize, string sFullName)
            {
                Check = false;
                FileName = sFileName;
                lModifyDate = slModifyDate;
                sModifyDate = ssModifyDate;
                lFileSize = slFileSize;
                sFileName = ssFileSize;
                FullName = sFullName;
            }
        }

    }
}
