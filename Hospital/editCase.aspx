<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editCase.aspx.cs" Inherits="editCase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table ID="Table2" runat="server" BorderStyle="Double">

                         <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label6" runat="server" Text="出院时间"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="outHospital" runat="server"></asp:TextBox><asp:Button ID="Button4" runat="server" Text="时间" BackColor="Green" OnClick="Button4_Click" />
</asp:TableCell>
            </asp:TableRow>   
                                     <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label8" runat="server" Text="病历"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server" >
                    <asp:TextBox ID="caseHistory" runat="server" Height="150" TextMode="MultiLine"></asp:TextBox></asp:TableCell>
            </asp:TableRow>   
            </asp:Table>
        <br />
        帐单号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="更新" OnClick="Button6_Click" />
    </div>
    </form>
</body>
</html>
