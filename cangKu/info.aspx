<%@ Page Language="C#" AutoEventWireup="true" CodeFile="info.aspx.cs" Inherits="info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style="width:300px;height:500px;float:left;border-style:dotted">更新库存材料信息<br />
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" Width="280px">
            <asp:TableRow><asp:TableCell>编号：<asp:TextBox ID="id" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>数量：<asp:TextBox ID="amount" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>单价：<asp:TextBox ID="price" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>

        </asp:Table>

        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="更新" OnClick="Button3_Click" />

    </div>
        
        <div style="width:300px;height:500px;float:left;border-style:dotted;margin-left:30px">更新各单位信息

         
            <br />
            <br />
         <asp:Table ID="Table2" runat="server" Width="280px">
             <asp:TableRow><asp:TableCell>单位ID：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>单位名：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
         </asp:Table>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
            
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="修改" OnClick="Button2_Click" />
        </div>
     </div>
    </form>
</body>
</html>
