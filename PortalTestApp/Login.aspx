<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PortalTestApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>UserName</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtUserName" ClientIDMode="Static"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox TextMode="Password" runat="server"  ID="txtPassword" ClientIDMode="Static"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button runat="server" Text="Login"  ID="btnLogin" ClientIDMode="Static" OnClick="btnLogin_Click" /></td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
