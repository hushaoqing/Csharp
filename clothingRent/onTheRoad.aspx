<%@ Page Language="C#" AutoEventWireup="true" CodeFile="onTheRoad.aspx.cs" Inherits="onTheRoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<script src="countDown.js"></script>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <span id="jumpTo">5</span>秒后自动跳转,
        你的账号ID是<asp:Label ID="Label1" runat="server" Text="Label" BackColor="Red" BorderStyle="Dotted" Font-Size="XX-Large" Height="38px" Width="101px" ></asp:Label>
        <script>countDown(5,'Default.aspx')</script>
    </div>
    </form>
</body>
</html>
