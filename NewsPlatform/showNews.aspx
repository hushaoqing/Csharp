<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showNews.aspx.cs" Inherits="showNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .title {}
    </style>
</head>
<body>    
    
    <form id="form1" runat="server">

    <div >
        <asp:Label ID="labTitle" runat="server" CssClass="title" Text="Label" Width="305px"></asp:Label>  
        <asp:Label ID="LabTime" runat="server" Text="LabTime"></asp:Label>
        <asp:TextBox ID="txtContent" runat="server" CssClass="txt" Height="159px" OnTextChanged="txtContent_TextChanged" TextMode="MultiLine" Width="486px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="关闭窗口" Width="103px" />
     </div></form>
   
</body>
</html>
