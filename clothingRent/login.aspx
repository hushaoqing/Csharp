<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Table ID="Table1" runat="server" Height="131px">
            <asp:TableRow><asp:TableCell>
                账号：<asp:TextBox ID="name" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>
                密码：<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow>

        </asp:Table>
    
        <br />
        <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="登陆" Width="90px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="27px" Text="注册" Width="85px" OnClick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>
