using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using ChangKeTec.Wms.Controllers.BaseData;
using ChangKeTec.Wms.Controllers.Bill;
using ChangKeTec.Wms.Controllers.Interface;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;
using ChangKeTec.Wms.Utils;

namespace ChangKeTec.Wms.ErpInterface
{
    public class QadInterface
    {

        private bool _isFtp= Convert.ToBoolean(GlobalVar.IsFtp);
        private List<string> _putFilenameList= new List<string>();
        private List<string> _getFilenameList = new List<string>();
        private string _localRootPath;
        private string _localToErp;
        private string _localFromErp;
        private string _localBackup;
        BackgroundWorker _bgwFromErp = new BackgroundWorker();
        BackgroundWorker _bgwToErp = new BackgroundWorker();

        private string _ftpFromErp;
        private string _ftpToErp;

        private FtpHelper _ftp;

        public QadInterface()
        {
            InitBgw();
        }

        public QadInterface(string localRootPath, string localFromErp, string localToErp, string localBackup)
        {
            _localRootPath = localRootPath;
            _localFromErp = localFromErp;
            _localToErp = localToErp;
            _localBackup = localBackup;
            InitBgw();
        }

        public QadInterface(string localRootPath, string localFromErp, string localToErp, string localBackup,
            string ftpServer,string ftpPort,string ftpUser,string ftpPassword,string ftpRootPath,string ftpFromErp,string ftpToErp)
        {
            _localRootPath = localRootPath;
            _localFromErp = localFromErp;
            _localToErp = localToErp;
            _localBackup = localBackup;
            _ftp = new FtpHelper(ftpServer, ftpPort, ftpRootPath, ftpUser, ftpPassword);
            _ftpFromErp = ftpFromErp;
            _ftpToErp = ftpToErp;
            InitBgw();
        }

        private void InitBgw()
        {
            _bgwFromErp.DoWork += BgwFromErpDoWork;
            _bgwFromErp.RunWorkerCompleted += BgwFromErpRunWorkerCompleted;
            _bgwToErp.DoWork += BgwToErpDoWork;
            _bgwToErp.RunWorkerCompleted += BgwToErpRunWorkerCompleted; ;

        }
        private void BgwToErpRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine(@"发送完成");
        }

        private void BgwToErpDoWork(object sender, DoWorkEventArgs e)
        {
            WriteErpFiles();

        }
        public void Send()
        {
            _bgwToErp.RunWorkerAsync();
        }

        private  void WriteErpFiles放弃()
        {
            string localPath = IoHelper.GetFullPath(_localRootPath, _localToErp);
            if (!Directory.Exists(localPath))
            {
                Console.WriteLine(@"接口文件夹 " + localPath + @" 不存在，发送失败");
                return;
            }
            Console.WriteLine(@"汇总接口数据开始");


            using (SpareEntities db = EntitiesFactory.CreateWmsInstance())
            {
                var list = ErpInterfaceController.GetNewList(db).ToList();
                if (list.Count == 0)
                {
                    Console.WriteLine(@"未发现需要汇总的接口数据");
                    return;
                }

//                var allList = list.DistinctBy(p => p.BillNum);

                var sumList = new List<TL_INTERFACE>();
                foreach (var bill in list)
                {
                    TL_INTERFACE erpInterface = null;
                    switch (bill.InterfaceType)
                    {
                        case "StockMove":
                            erpInterface = sumList.FirstOrDefault(p =>
                                p.BillType == bill.BillType.ToString()
                                && p.BillNum == bill.BillNum
                                && p.InterfaceType == bill.InterfaceType.ToString()

                                && p.p01 == bill.p01
                                    // && p.p02 == bill.p02
                                && p.p03 == bill.p03
                                && p.p04 == bill.p04
                                && p.p05 == bill.p05
                                && p.p06 == bill.p06
                                && p.p07 == bill.p07
                                && p.p08 == bill.p08
                                && p.p09 == bill.p09
                                && p.p10 == bill.p10
                                && p.p11 == bill.p11
                                && p.p12 == bill.p12
                                && p.p13 == bill.p13
                                && p.p14 == bill.p14
                                && p.p15 == bill.p15
                                && p.p16 == bill.p16
                                && p.p17 == bill.p17
                                && p.p18 == bill.p18
                                && p.p19 == bill.p19
                                && p.p20 == bill.p20
                                );
                            break;
                        case "BackFlush":
                            erpInterface = sumList.FirstOrDefault(p =>
                                p.BillType == bill.BillType.ToString()
                                && p.BillNum == bill.BillNum
                                && p.InterfaceType == bill.InterfaceType.ToString()

                                && p.p01 == bill.p01
                                && p.p02 == bill.p02
                                && p.p03 == bill.p03
                                && p.p04 == bill.p04
                                && p.p05 == bill.p05
                                && p.p06 == bill.p06
                                && p.p07 == bill.p07
                                && p.p08 == bill.p08
                                && p.p09 == bill.p09
                                && p.p10 == bill.p10
                                && p.p11 == bill.p11
                                    //&& p.p12 == bill.p12
                                && p.p13 == bill.p13
                                && p.p14 == bill.p14
                                && p.p15 == bill.p15
                                && p.p16 == bill.p16
                                && p.p17 == bill.p17
                                && p.p18 == bill.p18
                                && p.p19 == bill.p19
                                && p.p20 == bill.p20

                                );
                            break;
                        case "StockSell":
                            erpInterface = sumList.FirstOrDefault(p =>
                                p.BillType == bill.BillType.ToString()
                                && p.BillNum == bill.BillNum
                                && p.InterfaceType == bill.InterfaceType.ToString()

                                && p.p01 == bill.p01
                                && p.p02 == bill.p02
                                && p.p03 == bill.p03
                                && p.p04 == bill.p04
                                && p.p05 == bill.p05
                                    //&& p.p06 == bill.p06
                                && p.p07 == bill.p07
                                && p.p08 == bill.p08
                                && p.p09 == bill.p09
                                && p.p10 == bill.p10
                                && p.p11 == bill.p11
                                && p.p12 == bill.p12
                                && p.p13 == bill.p13
                                && p.p14 == bill.p14
                                && p.p15 == bill.p15
                                && p.p16 == bill.p16
                                && p.p17 == bill.p17
                                && p.p18 == bill.p18
                                && p.p19 == bill.p19
                                && p.p20 == bill.p20

                                );
                            break;

                    }
                    if (erpInterface == null)
                    {
                        erpInterface = new TL_INTERFACE
                        {
                            BillType = bill.BillType,
                            BillNum = bill.BillNum,
                            InterfaceType = bill.InterfaceType,
                            State = (int) BillState.New,
                            pQty = bill.pQty,
                            p01 = bill.p01,
                            p02 = bill.p02,
                            p03 = bill.p03,
                            p04 = bill.p04,
                            p05 = bill.p05,
                            p06 = bill.p06,
                            p07 = bill.p07,
                            p08 = bill.p08,
                            p09 = bill.p09,
                            p10 = bill.p10,
                            p11 = bill.p11,
                            p12 = bill.p12,
                            p13 = bill.p13,
                            p14 = bill.p14,
                            p15 = bill.p15,
                            p16 = bill.p16,
                            p17 = bill.p17,
                            p18 = bill.p18,
                            p19 = bill.p19,
                            p20 = bill.p20,
                        };
                        sumList.Add(erpInterface);
                    }
                    else
                    {
                        switch (bill.InterfaceType)
                        {
                            case "StockMove":
                                erpInterface.p02 =
                                    (Convert.ToDecimal(erpInterface.p02) + Convert.ToDecimal(bill.p02)).ToString();
                                break;
                            case "BackFlush":
                                erpInterface.p12 +=
                                    (Convert.ToDecimal(erpInterface.p12) + Convert.ToDecimal(bill.p12)).ToString();
                                break;
                            case "StockSell":
                                erpInterface.p06 +=
                                    (Convert.ToDecimal(erpInterface.p06) + Convert.ToDecimal(bill.p06)).ToString();
                                break;
                        }
                    }
                }

                var billNumList = (from c in sumList select c.BillNum).Distinct();
                foreach (var billNum in billNumList)
                {
                    var sb = new StringBuilder();
                    string prefix = string.Empty;
                    foreach (
                        TL_INTERFACE f in
                            sumList.Where(p => p.BillNum == billNum && p.InterfaceType == ErpInterfaceType.TR.ToString())
                                .OrderBy(p => p.p08))
                    {
                        f.InterfaceString = GetInterfaceString(f);
                        sb.AppendLine(f.InterfaceString);
                    }
                    prefix = "tr";
                    WriteErpFile(localPath, billNum, prefix, sb.ToString());
                    foreach (
                        TL_INTERFACE f in
                            sumList.Where(p => p.BillNum == billNum && p.InterfaceType == ErpInterfaceType.BK.ToString())
                                .OrderBy(p => p.p04))
                    {
                        f.InterfaceString = GetInterfaceString(f);
                        sb.AppendLine(f.InterfaceString);
                    }
                    prefix = "bk";
                    WriteErpFile(localPath, billNum, prefix, sb.ToString());
                    foreach (
                        TL_INTERFACE f in
                            sumList.Where(p => p.BillNum == billNum && p.InterfaceType == ErpInterfaceType.SH.ToString())
                                .OrderBy(p => p.p08))
                    {
                        f.InterfaceString = GetInterfaceString(f);
                        sb.AppendLine(f.InterfaceString);
                    }
                    prefix = "sh";
                    WriteErpFile(localPath, billNum, prefix, sb.ToString());
                }
                try
                {
                    ErpInterfaceController.AddHisList(db, sumList);
                    ErpInterfaceController.RemoveList(db, list);
                    EntitiesFactory.SaveDb(db);
                }
                catch (WmsException ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            }


            Console.WriteLine(@"汇总接口数据结束");


            Console.WriteLine(@"发送数据开始");

            var fileList = Directory.GetFiles(localPath).ToList();
            if (_isFtp)
            {
                try
                {
                    Console.WriteLine(@"上传文件开始");
                    _ftp.GotoDirectory("//" + _ftpToErp, false);
                    _ftp.UploadList(fileList);
                    Console.WriteLine(@"上传文件完成");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            foreach (string localFileName in fileList)
            {
                string txtName = Path.GetFileName(localFileName);
                string bakFileName = IoHelper.GetFullFilename(_localRootPath + _localBackup + "\\" + _localToErp,
                    txtName, false);
                if (File.Exists(bakFileName))
                    File.Delete(bakFileName);
                File.Move(localFileName, bakFileName);
                //                File.Delete(localFileName);
            }
        }

        private static string GetInterfaceString(TL_INTERFACE data)
        {
            const string sp = ",";
            var s = new StringBuilder();
            s.Append(data.pQty > 01 ? (data.p01 + sp) : "");
            s.Append(data.pQty > 02 ? (data.p02 + sp) : "");
            s.Append(data.pQty > 03 ? (data.p03 + sp) : "");
            s.Append(data.pQty > 04 ? (data.p04 + sp) : "");
            s.Append(data.pQty > 05 ? (data.p05 + sp) : "");
            s.Append(data.pQty > 06 ? (data.p06 + sp) : "");
            s.Append(data.pQty > 07 ? (data.p07 + sp) : "");
            s.Append(data.pQty > 08 ? (data.p08 + sp) : "");
            s.Append(data.pQty > 09 ? (data.p09 + sp) : "");
            s.Append(data.pQty > 10 ? (data.p10 + sp) : "");
            s.Append(data.pQty > 11 ? (data.p11 + sp) : "");
            s.Append(data.pQty > 12 ? (data.p12 + sp) : "");
            s.Append(data.pQty > 13 ? (data.p13 + sp) : "");
            s.Append(data.pQty > 14 ? (data.p14 + sp) : "");
            s.Append(data.pQty > 15 ? (data.p15 + sp) : "");
            s.Append(data.pQty > 16 ? (data.p16 + sp) : "");
            s.Append(data.pQty > 17 ? (data.p17 + sp) : "");
            s.Append(data.pQty > 18 ? (data.p18 + sp) : "");
            s.Append(data.pQty > 19 ? (data.p19 + sp) : "");
            s.Append(data.pQty > 20 ? (data.p20 + sp) : "");
            return s.ToString();
        }

        private void WriteErpFiles()
        {
            string localPath = IoHelper.GetFullPath( _localRootPath , _localToErp);
            if (!Directory.Exists(localPath))
            {
                Console.WriteLine(@"接口文件夹 " + localPath + @" 不存在，发送失败");
                return;
            }
            Console.WriteLine(@"发送数据开始");
            WriteErpFileList(localPath, ErpInterfaceType.TR, "tr");
            WriteErpFileList(localPath, ErpInterfaceType.BK, "bk");
            WriteErpFileList(localPath, ErpInterfaceType.SH, "sh");
            var fileList = Directory.GetFiles(localPath).ToList();
            if (_isFtp)
            {
                try
                {
                    Console.WriteLine(@"上传文件开始");
                    _ftp.GotoDirectory("//" + _ftpToErp, false);
                    _ftp.UploadList(fileList);
                    Console.WriteLine(@"上传文件完成");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            foreach (string localFileName in fileList)
            {
                string txtName = Path.GetFileName(localFileName);
                string bakFileName  = IoHelper.GetFullFilename(_localRootPath+_localBackup + "\\" + _localToErp, txtName,false);
                if(File.Exists(bakFileName))
                    File.Delete(bakFileName);
                File.Move(localFileName, bakFileName);
//                File.Delete(localFileName);
            }
        }

        private  void WriteErpFileList(string localPath, ErpInterfaceType type, string prefix)
        {


            try
            {
                using (SpareEntities db = EntitiesFactory.CreateWmsInstance())
                {
                    var list = ErpInterfaceController.GetNewList(db, type).ToList();
                    if (list.Count == 0)
                    {
                        Console.WriteLine(@"未发现需要发送的 " + type + " 接口数据");
                        return;
                    }


                    var billList = list.DistinctBy(p => p.BillNum);

                    foreach (var bill in billList)
                    {
                        var sb = new StringBuilder();
                        foreach (var tsInterface in list.Where(p => p.BillNum == bill.BillNum).OrderBy(p => p.p08))
                        {
                            sb.AppendLine(tsInterface.InterfaceString);
                        }
                        WriteErpFile(localPath, bill.BillNum, prefix, sb.ToString());
                    }
                    try
                    {
                        ErpInterfaceController.UpdateList(db, list);
                        EntitiesFactory.SaveDb(db);
                    }
                    catch (WmsException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
                Console.WriteLine(@"生成" + type + "接口文件完成");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void WriteErpFile(string localPath, string billNum,string prefix, string strFileData)
        {
            string txtName = prefix  + billNum +"_"+ DateTime.Now.ToString("HHmmss") + ".in";
            string localFileName = IoHelper.GetFullFilename(localPath, txtName, false);
            using (StreamWriter sw = new StreamWriter(localFileName, true, Encoding.Unicode))
            {
                sw.Write(strFileData);
                sw.Flush();
                sw.Close();
                sw.Dispose();
                Console.WriteLine(@"生成接口文件" + txtName + @" ");
            }
        }
        

        private void BgwFromErpRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine(@"接收完成");
        }

        private void BgwFromErpDoWork(object sender, DoWorkEventArgs e)
        {
            ReadErpFiles();
        }

        public void Receive()
        {

            _bgwFromErp.RunWorkerAsync();

        }
        
        private  void ReadErpFiles()
        {
            //TODO GetErpFile
            Console.WriteLine(@"接收开始");
            string remotePath = _localRootPath + _localFromErp;
            try
            {

                if (!Directory.Exists(remotePath))
                {
                    Console.WriteLine("接口文件夹 " + remotePath + " 不存在，获取失败");
                    return;
                }
                var fileList = Directory.GetFiles(remotePath);
                if (fileList.Length == 0)
                {
                    Console.WriteLine("未发现需要接收的文件");
                    return;
                }
                using (SpareEntities db = EntitiesFactory.CreateWmsInstance())
                {
                    foreach (string remoteFile in fileList)
                    {

                        var filename = Path.GetFileName(remoteFile);
                        if (filename == null)
                            continue;
                        if (!(filename.StartsWith("part") || filename.StartsWith("stock")))
                            continue;
                        var encoding = IoHelper.GetFileEncodeType(remoteFile);

                        List<string> dataList;
                        try
                        {
                            dataList = File.ReadAllLines(remoteFile, encoding).ToList();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("文件被其它进程占用，读取失败");
                            continue;
                        }

                        if (!dataList.Any())
                        {
                            Console.WriteLine("文件 " + filename + " 的内容为空");
                            continue;
                        }
                        if (filename.StartsWith("part", true, null))
                        {
                            ReadPartFile(dataList, filename, db);
                        }
                        else if (filename.StartsWith("stock", true, null))
                        {
                            ReadStockFile(dataList, filename, db);
                        }
                        else
                        {
                            Console.WriteLine(filename + " 文件名错误");
                        }
                        string bakFileName = IoHelper.GetFullFilename(_localBackup + "\\" + _localFromErp,
                            Path.GetFileNameWithoutExtension(filename) + DateTime.Now.ToString("yyyyMMdd") + ".txt");
                        try
                        {
                            File.Copy(remoteFile, bakFileName, true);
                            File.Delete(remoteFile);
                        }
                        catch
                        {
                            // ignored
                        }
                    }
                   EntitiesFactory.SaveDb(db);
                }
            }
            catch (WmsException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void ReadStockFile(List<string> dataList, string filename, SpareEntities db)
        {
            Console.WriteLine(@"接收库存数据开始");
            var curStockList = StockController.GetList(db);
            var newStockList = new List<TS_STOCK>();
            for (int i = 0; i < dataList.Count; i++)
            {
                string strErr = "库存文件 " + filename + " 第 " + i + " 行 \t";
                string data = dataList[i];
                var cols = data.Split(';');
                if (cols.Length != 7)
                {
                    Console.WriteLine(strErr + " 格式错误" + Environment.NewLine + "\t\t\t\t" + data);
                    continue;
                }
                string locCode = cols[1].ToUpper();
                if (locCode == "FGAVA")
                {
                    continue;
                }
                string barCode = cols[3].ToUpper();
                if (string.IsNullOrEmpty(barCode))
                {
                    Console.WriteLine(strErr + " barCode为空" + Environment.NewLine + "\t\t\t\t" + data);
                    continue;
                }

//                if (curStockList.Exists(p => p.VinCode == barCode))
//                {
//                    //                    Console.WriteLine(strErr + " barCode重复" + Environment.NewLine + "\t\t\t\t" + data);
//                    continue;
//                }
                var stock = new TS_STOCK
                {
//                    VinCode = barCode,
                    LocCode = locCode,
                    PartCode = cols[2].ToUpper(),
                    Batch = cols[3].ToUpper(),
                    RefCode = cols[4].ToUpper(),
                    Qty = Convert.ToInt32(cols[5]),
                    UpdateTime = DateTime.Now
                };
                if (stock.Qty != 1)
                {
                    Console.WriteLine(strErr + " 数量错误" + Environment.NewLine + "\t\t\t\t" + data);
                    continue;
                }
                newStockList.Add(stock);
            }
//            StockController.Update(db, newStockList);
            Console.WriteLine(@"新增库存数据 " + newStockList.Count);
            Console.WriteLine(@"接收库存数据完成");
        }

        private static void ReadPartFile(List<string> dataList, string filename, SpareEntities db)
        {
            Console.WriteLine(@"接收零件数据开始");
            var partList = new List<TA_PART>();

            for (int i = 0; i < dataList.Count; i++)
            {
                string strErr = "零件文件 " + filename + " 第 " + i + " 行 \t";
                string data = dataList[i];
                var cols = data.Split(';');
                if (cols.Length != 8)
                {
                    Console.WriteLine(strErr + @" 格式错误" + Environment.NewLine + "\t\t\t\t" + data);
                    continue;
                }
                string partCode = cols[0];
                if (string.IsNullOrEmpty(partCode))
                {
                    Console.WriteLine(strErr + @" partCode为空" + Environment.NewLine + "\t\t\t\t" + data);
                    continue;
                }

                

                TA_PART part = db.TA_PART.FirstOrDefault(p => p.ErpPartCode == partCode) ?? new TA_PART
                {
                    ErpPartCode = partCode,
                    State = (int)DataState.Enabled,
                    ContainerQty = 0,
                    MaxQty = 0,
                    MinQty = 0,
                    SafeQty = 0
                };
                if (partList.Exists(p => p.ErpPartCode == partCode))
                {
                    Console.WriteLine(strErr + @" partCode重复" + Environment.NewLine + "\t\t\t\t" + data);
                    continue;
                }

                part.PartDesc1 = cols[1];
                part.PartDesc2 = cols[2];
                part.BM = cols[3];
                part.ProjectId = cols[4];
                part.PartKind = cols[4];
                part.Unit = cols[5];

                partList.Add(part);
            }
            PartController.AddOrUpdate(db, partList);
            Console.WriteLine(@"接收零件数据完成");
        }


    }
}