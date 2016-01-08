<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="width:400px;height:200px;background-color:gray">
        <asp:Table ID="Table1" runat="server" Height="180px" Width="260px">
            <asp:TableRow><asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="账号"></asp:Label><asp:TextBox ID="name" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label><asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click"/>&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />
            </asp:TableCell></asp:TableRow>
        </asp:Table>
        

    </div>
    </form>
</body>
</html>
