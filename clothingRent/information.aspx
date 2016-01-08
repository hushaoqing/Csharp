<%@ Page Language="C#" AutoEventWireup="true" CodeFile="information.aspx.cs" Inherits="information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理界面</title>
</head>
<body>
   
    <div align="center">
    <form id="form1" runat="server">
         <asp:Button ID="Button2" runat="server" Text="刷新" onclick="Button2_Click" Height="33px" Width="52px"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button5" runat="server" Height="31px" OnClick="Button5_Click" Text="客户登录" Width="80px" />
&nbsp;<div style="width:1000px">
        <div style="width:300px;height:800px;border-style:dotted;float:left">
            <asp:Table ID="Table3" runat="server" Height="123px" Width="244px">
                <asp:TableRow>
                    <asp:TableCell>
                    编号：<asp:TextBox ID="bianhao" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                                <asp:TableRow>
                    <asp:TableCell>
                    名称：<asp:TextBox ID="mingcheng" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    数量：<asp:TextBox ID="shuliang" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <br />
        <asp:Button ID="Button1" runat="server" Height="22px" Text="入库" Width="75px" OnClick="Button1_Click" />
            <br />
        <br />
            <asp:Table ID="Table1" runat="server" Height="108px" Width="244px">
                <asp:TableRow>
                    <asp:TableCell>
                    编号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    数量：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>

            </asp:Table>

            <br />

            <asp:Button ID="Button3" runat="server" Text="修改" Width="83px" OnClick="Button3_Click" />
            <br />
            <br />
                       <asp:Table ID="Table2" runat="server" Height="108px" Width="244px">
                <asp:TableRow>
                    <asp:TableCell>
                    编号：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    名称：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>

            </asp:Table>

            <br />

            <asp:Button ID="Button4" runat="server" Text="删除" Width="89px" OnClick="Button4_Click" />
            <br />
        </div>
      <div style="width:600px;height:800px;border-style:dotted;float:left;margin-left:30px">
          库存信息：
          <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

            <br />
            <br />
            <br />
          客户信息：
            <br />
          <asp:GridView ID="GridView3" runat="server"></asp:GridView>
            <br />
            <br />
            <br />
            <br />
          租赁信息：
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>

    </div>
          
    </div>
    </form></div>
</body>
</html>
