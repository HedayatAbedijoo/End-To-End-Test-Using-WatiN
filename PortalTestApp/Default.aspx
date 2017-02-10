<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PortalTestApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>Welcome UserName!</div>
            <asp:HyperLink runat="server" ID="logOut" ClientIDMode="Static" NavigateUrl="~/Login.aspx">LogOut</asp:HyperLink>
        </div>
        <br />
        <br />
        <br />
        <br />
        <asp:HyperLink runat="server" ID="openLink" ClientIDMode="Static" NavigateUrl="~/SecondPage.aspx">Go To Second Page</asp:HyperLink>

    </form>
</body>
</html>
