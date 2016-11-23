using System.Collections.Generic;
using System.Linq;
using ChangKeTec.Wms.Models;

namespace ChangKeTec.Wms.Controllers.BaseData
{
    public static class PowerController
    {

        public static List<VS_POWER_MENU> GetPowerMenuList(PowerEntities db, string portalCode, string operCode)
        {
            var returnList = new List<VS_POWER_MENU>();
            var roles = db.TS_OPER_ROLE.Where(p => p.OperCode == operCode&&p.IsBeloneTo);
            foreach (var role in roles)
            {
                var list = db.VS_POWER_MENU.Where(p => p.RoleCode == role.RoleCode &&p.PortalCode == portalCode);
                foreach (var menu in list)
                {
                    var existMenu = returnList.SingleOrDefault(p =>p.MenuCode == menu.MenuCode);
                    if (existMenu!=null)
                    {
                        if (menu.IsVisible) existMenu.IsVisible = true;
                        if (!menu.IsReadOnly) existMenu.IsReadOnly = false;
                    }
                    else
                    {
                        returnList.Add(menu);
                    }

                }
            }

            return returnList;
        }

        public static List<TS_ROLE_NOTIFYTYPE> GetNotiFyTypeList(PowerEntities db, string portalCode, string operCode)
        {
            var returnList = new List<TS_ROLE_NOTIFYTYPE>();
            var roles = db.TS_OPER_ROLE.Where(p => p.OperCode == operCode);
            foreach (var role in roles)
            {
                var list = db.TS_ROLE_NOTIFYTYPE.Where(p => p.RoleCode == role.RoleCode && p.PortalCode == portalCode);
                foreach (var item in list)
                {
                    var exitItem = returnList.SingleOrDefault(p => p.NotifyType == item.NotifyType);
                    if (exitItem == null)
                    {
                        returnList.Add(item);
                    }
                    else
                    {
                        if (item.IsVisible) exitItem.IsVisible = item.IsVisible;
                    }
                }
            }

            return returnList;
        }
    }
}