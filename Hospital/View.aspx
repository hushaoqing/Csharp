
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="返回" OnClick="Button1_Click" />
    <div style="text-align:center">
    <asp:Label ID="sss" runat="server" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
        <br />
    
    </div>
    </form>
</body>
</html>
