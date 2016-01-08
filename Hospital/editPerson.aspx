<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editPerson.aspx.cs" Inherits="edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table ID="Table1" runat="server" Height="283px" Width="300px" Font-Underline="False" BorderStyle="Double">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
                <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label10" runat="server" Text="性别"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="sex" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label2" runat="server" Text="年龄"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label3" runat="server" Text="电话"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="tel" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>

             <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label4" runat="server" Text="地址"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="addr" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
    
        </asp:Table>
        <br />
        身份证号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="更新" Width="68px" />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
