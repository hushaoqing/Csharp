<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>客户界面</title>
</head>
<body><div align="center">
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="刷新" Height="28px" OnClick="Button1_Click" Width="87px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Height="28px" OnClick="Button5_Click" Text="退出" Width="67px" />
&nbsp;&nbsp;&nbsp;
    <div style="width:1000px"> 
        <div style="width:300px;height:500px;border-style:dotted;float:left">
            <asp:Table ID="Table3" runat="server" Height="190px" Width="244px">
                <asp:TableRow>
                    <asp:TableCell>
                    编号：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                                <asp:TableRow>
                    <asp:TableCell>
                    名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    数量：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <br />
            <asp:Button ID="Button3" runat="server" Text="租赁" Height="29px" style="margin-left: 0px" Width="61px" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Table ID="Table4" runat="server" Height="190px" Width="244px">
                                <asp:TableRow>
                    <asp:TableCell>
                    单号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    编号：<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
         <asp:TableRow>
                    <asp:TableCell>
                    名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    数量：<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <asp:Button ID="Button4" runat="server" Text="归还" Height="25px" Width="64px" OnClick="Button4_Click" />
    </div>
        <div style="width:600px;height:500px;border-style:dotted;float:left;margin-left:30px">

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>

    </div>
    </form></div>
</body>
</html>
