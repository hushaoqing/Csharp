<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zhangDan.aspx.cs" Inherits="zhangDan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 77%;
            height: 187px;
        }
        .auto-style3 {
            width: 244px;
        }
        .auto-style4 {
            height: 20px;
            width: 244px;
        }
        .auto-style6 {
            width: 244px;
            height: 31px;
        }
        .auto-style7 {
            height: 20px;
            width: 547px;
        }
        .auto-style8 {
            width: 547px;
        }
        .auto-style9 {
            width: 547px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="0" class="auto-style1" style="border: thin dotted #000000">
            <tr>
                <td class="auto-style4">名称：</td>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">数量：</td>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    个</td>
            </tr>
            <tr>
                <td class="auto-style3">单价：</td>
                <td class="auto-style8">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    元</td>
            </tr>
                        <tr>
                <td class="auto-style3">总价：</td>
                <td class="auto-style8">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    元</td>
            </tr>
                        <tr>
                <td class="auto-style3">单位：</td>
                <td class="auto-style8">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            </td>
            </tr>
                                    <tr>
                <td class="auto-style6">时间：</td>
                <td class="auto-style9">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            </td>
            </tr>

        </table>
    
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
