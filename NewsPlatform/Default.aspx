<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新闻发布系统</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 199px;
        }
        </style>
    <script src="countDown.js"></script>
    </head>
<body>
    <form id="form1" runat="server">
    <div align="center"style="font-size: xx-large; color: #FF0000;">新闻发布系统</div>
    <div align="center">
        <table class="auto-style1">
        <tr>
            <td class="auto-style2" style="text-align:center"><div style="color:red">新闻标题</div></td>
        </tr>

    </table>
        <asp:DataList ID="DataList2" runat="server" BackColor="White" BorderColor="White" BorderWidth="2px" CellPadding="3" BorderStyle="Ridge" OnItemCommand="DataList2_ItemCommand" CellSpacing="1" Height="341px" Width="446px" >
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <ItemTemplate>
                <asp:LinkButton ID="Label1" runat="server"><%# DataBinder.Eval(Container.DataItem,"title")%> </asp:LinkButton>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#9471DE" ForeColor="White" Font-Bold="True" />
        </asp:DataList>
        </div>


        <div style="text-align:center;font-size:large;padding-top:30px">This designed By HSQ<br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" BackColor="Red">管理员登陆</asp:LinkButton>
        </div>
    </form>
    


</body>
</html>
