<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
            <asp:Table ID="Table2" runat="server" Height="172px">
                <asp:TableRow><asp:TableCell>
                    姓名：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell>
                    电话：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell>
                    地址：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                            <asp:TableRow><asp:TableCell>
                    密码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            </asp:Table>
    
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="注册" Width="79px" />
    
    </div>
    </form>
</body>
</html>
