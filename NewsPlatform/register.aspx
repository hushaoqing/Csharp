<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        姓名<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        密码<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="28px" Text="注册" Width="71px" OnClick="Button1_Click" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
