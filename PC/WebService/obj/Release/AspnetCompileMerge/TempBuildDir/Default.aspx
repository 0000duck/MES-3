<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChangKeTec.Wms.WebService.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        WMS系统软件下载<br />
        <br />
        权限管理客户端：<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="/PcSetup/PowerForm.zip">PowerForm.zip</asp:HyperLink>
        <br />
        <br />
        PC客户端：<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/PcSetup/Wms.WinForm.zip">Wms.WinForm.zip</asp:HyperLink>
        <br />
        <br />
        <br />
        环境支持软件下载<br />
        <br />
        软件运行环境
        .NET Framework 4.5:<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/Resources/dotnetfx45_full_4.5.51209.exe">dotnetfx45_full_4.5.51209.exe</asp:HyperLink>
        <br />
        <br />
        报表控件
        Grid++ Report 6.0:<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Resources/GridReport6.zip">Grid++Report6.zip</asp:HyperLink>
        <br />
        <br />
        Excel导出控件
        AccessDatabaseEngine.exe:<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="/Resources/AccessDatabaseEngine.exe">AccessDatabaseEngine.exe</asp:HyperLink>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
