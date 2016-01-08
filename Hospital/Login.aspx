<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" Height="111px">
            <asp:TableRow><asp:TableCell>账号<asp:TextBox ID="name" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>密码<asp:TextBox ID="psw" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow>

        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
