<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editNews.aspx.cs" Inherits="editNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <div style="height:500px;width:300px;text-align:left;float:left">
    
        <asp:Table ID="Table1" runat="server" Height="400px" Width="280px" BorderStyle="Dotted">
            <asp:TableRow><asp:TableCell>标题：<asp:TextBox ID="title" runat="server"></asp:TextBox>
</asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>作者：<asp:TextBox ID="author" runat="server" ></asp:TextBox>
</asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>时间：<asp:TextBox ID="time" runat="server"></asp:TextBox><asp:Button ID="getTime" runat="server" Text="时间"  OnClick="getTime_Click" BackColor="Green" ForeColor="White"/>
</asp:TableCell></asp:TableRow>
          <asp:TableRow><asp:TableCell>内容：<asp:TextBox ID="content" runat="server" TextMode="MultiLine" Height="150px"></asp:TextBox>
</asp:TableCell></asp:TableRow>
        </asp:Table>
        <br />
        <br />
        <asp:Button ID="edit" runat="server" Text="更新" Font-Size="Large" Height="37px" Width="54px" OnClick="edit_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="34px" OnClick="Button1_Click" Text="获取上版本信息" Width="118px" />
        &nbsp;&nbsp;
        </div>
    </div>
    </form>
</body>
</html>
