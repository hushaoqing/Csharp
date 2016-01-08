<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertNews.aspx.cs" Inherits="insertNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台管理系统</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="float:right"><asp:Button ID="Button2" runat="server" Text="刷新"  OnClick="Button2_Click" BackColor="green" Height="50px" Width="100px" Font-Size="Large" ForeColor="White" /></div>
    <div style="height:500px;width:300px;text-align:left;float:left">
    
        <asp:Table ID="Table1" runat="server" Height="401px" Width="286px" BorderStyle="Dotted">
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
        <asp:Button ID="Button1" runat="server" Text="提交" Font-Size="Large" Height="37px" Width="95px" OnClick="Button1_Click" />
    </div>
        <div style="height:394px; float:left;margin-left:30px;border-style:dotted; width: 613px;">
            新闻编号：<asp:TextBox ID="TextBox1" runat="server" Width="78px"></asp:TextBox>
            <br />
            <br />
            新闻标题：<asp:TextBox ID="TextBox2" runat="server" Width="78px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="delete" runat="server"  Text="删除新闻" BackColor="Green" OnClick="delete_Click" ForeColor="White" />
            <asp:Button ID="edit" OnClick="edit_Click" runat="server" Text="修改新闻" BackColor="Green" ForeColor="White" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Height="205px" Width="570px"></asp:GridView>
            <br />
        </div>
     </div>
    </form>
</body>
</html>
