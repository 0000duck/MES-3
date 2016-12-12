using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ChangKeTec.PowerForm.Bll;
using ChangKeTec.Wms.Models;
using ChangKeTec.Wms.Models.Enums;


namespace ChangKeTec.PowerForm
{
    public static class GlobalVar
    {
        public static TS_OPERATOR Oper { get; set; }
        public static List<TS_DEPT> DeptList { get; set; }
        public static List<TS_ROLE> RoleList { get; set; }
        public static List<TA_MENU> MenuList { get; set; }
        public static List<TS_PORTAL> PortalList { get; set; }
        public static List<TS_OPER_ROLE> OperRoleList { get; set; }
        public static List<string> DataStateStringList { get; set; }
        public static List<TS_OPERATOR> OperList { get; set; }
        public static string DefaultPassword { get; set; } = "123456";


        public const string PowerDbServer = "PowerDbServer";
        public const string PwerDbName = "PowerDbName";
        public const string PowerDbUser = "PowerDbUser";
        public const string PowerDbPassword = "PowerDbPassword";
        public const string UpdateServerUrl = "UpdateServerUrl";
        public const string UpdateFileName = "UpdateFileName";


        public static void InitGlobalVar(PowerEntities db, TS_OPERATOR oper)
        {
            Oper = oper;     
            DataStateStringList = Enum.GetNames(typeof(DataState)).ToList();
            DeptList = DeptController.GetList(db);
            RoleList = RoleController.GetList(db);
            MenuList = MenuController.GetList(db);
            PortalList = PortalControler.GetList(db);
            OperList = OperController.GetList(db);
            OperRoleList = OperRoleController.GetList(db);
        }

        public static void InitGlobalVar(PowerEntities db)
        {
            InitGlobalVar(db,Oper);
        }

     
    }
}