<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:600px;height:700px;margin-left:30px;border-style:dotted;float:left">
            库存信息：<br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            出/入库记录信息：<br />
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            <br />
            单位信息：<br />
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>
        </div>
    <div style="width:300px;height:700px;margin-left:30px;border-style:dotted;float:left;">
        <asp:Table ID="Table1" runat="server" Height="269px" Width="270px">
            <asp:TableRow><asp:TableCell>编号：<asp:TextBox ID="bianhao" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>名称：<asp:TextBox ID="mingcheng" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>数量：<asp:TextBox ID="shuliang" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>单价：<asp:TextBox ID="danjia" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell>时间：<asp:TextBox ID="shijian" runat="server"></asp:TextBox><asp:Button ID="Button6" runat="server" Text="时间" OnClick="Button6_Click" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>单位：<asp:TextBox ID="danwei" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell>总价：<asp:TextBox ID="zongjia" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
        </asp:Table>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="入库" Height="27px" Width="51px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="打印入库单" OnClick="Button3_Click" Height="28px" Width="99px" />
        <br />
        <br />
                <asp:Button ID="Button2" runat="server" Text="出库" Height="27px" Width="51px" OnClick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="打印出库单" OnClick="Button4_Click" Height="28px" Width="99px" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Height="26px" Text="更新" Width="52px" OnClick="Button5_Click" />
    </div>


                &nbsp;<asp:Button ID="Button7" runat="server" Height="42px" Text="刷新" Width="75px" OnClick="Button7_Click" />

    
    </form>
</body>
</html>
