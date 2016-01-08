<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 69px;
        }
        .auto-style2 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button7" runat="server" Text="刷新" BackColor="red" OnClick="Button7_Click1" Height="25px" Width="54px" />
        <div>
            
        <div style="width:350px;height:560px;float:left;border-style:dotted">
    <div align="left"  style="width: 300px; height: 39px; margin-bottom:10px">
        <asp:Label ID="Label9" runat="server" Text="Hospital入库信息" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" Height="283px" Width="300px" Font-Underline="False" BorderStyle="Double" HorizontalAlign="Center">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
                        <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label13" runat="server" Text="身份证号"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="idNum" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
                <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label10" runat="server" Text="性别"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="sex" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label2" runat="server" Text="年龄"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label3" runat="server" Text="电话"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="tel" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>

             <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label4" runat="server" Text="地址"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="addr" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
    
        </asp:Table>
    
        <br />
&nbsp;&nbsp;&nbsp;
    

        <br />
    
    </div>

       <div style="width:300px;height:60px;margin-top:350px"><asp:Button ID="Button1" runat="server" Text="入库" BackColor="Green" Font-Size="Large" OnClick="Button1_Click" Width="94px" ></asp:Button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="MessageTB" runat="server" Text="Label"></asp:Label>
 </div>
        </div>
        <div style="width:300px;height:560px;margin-left:50px;margin-bottom:10px;float:left;border-style:dotted">
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label12" runat="server" Text="病历信息" Font-Size="XX-Large"></asp:Label>
            <br />
            <asp:Table ID="Table2" runat="server" BorderStyle="Double" HorizontalAlign="Center">

                               <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label11" runat="server" Text="姓名"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="name1" runat="server"></asp:TextBox>
</asp:TableCell>
            </asp:TableRow>
                                              <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label14" runat="server" Text="身份证号"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="id" runat="server"></asp:TextBox><asp:Button ID="Button6" runat="server" Text="搜索" BackColor="Green" OnClick="Button6_Click" />
                <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                    <asp:Label ID="biaoqian" runat="server" Text="Label" Width="20px"></asp:Label>
</asp:TableCell>
            </asp:TableRow>
                                          <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label5" runat="server" Text="住院时间"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="inHospital" runat="server"></asp:TextBox><asp:Button ID="Button5" runat="server" Text="时间" BackColor="Green" OnClick="Button5_Click"/>
</asp:TableCell>
            </asp:TableRow> 
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
                    <asp:Label ID="Label7" runat="server" Text="病史"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server" >
                    <asp:TextBox ID="medicalHistory" runat="server" Height="150" TextMode="MultiLine"></asp:TextBox></asp:TableCell>
            </asp:TableRow>    
                                     <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Label ID="Label8" runat="server" Text="病历"></asp:Label>
</asp:TableCell>
                <asp:TableCell runat="server" >
                    <asp:TextBox ID="caseHistory" runat="server" Height="150" TextMode="MultiLine"></asp:TextBox></asp:TableCell>
            </asp:TableRow>   
            </asp:Table>
            <div style="margin-top:30px"><asp:Button ID="Button2" runat="server" Text="提交" BackColor="Green" Font-Size="Large" Height="29px" Width="97px" OnClick="Button2_Click" /></div>
        </div>
            <div style="float:left;width:300px;height:560px;margin-left:50px;border-style:dotted">
                
                <div style="margin-bottom:20px"><asp:Button ID="search" runat="server" Text="查看信息" BackColor="Green" OnClick="Button3_Click" />
                <asp:TextBox ID="searchName" runat="server" Width="126px"></asp:TextBox>(输入姓名)<br />
                    <br />
                    <br />
           <asp:Button ID="Button8" runat="server" Height="27px" Text="更新个人信息" Width="100px" BackColor="Green" OnClick="Button8_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button9" runat="server" Text="更新病历信息" Width="100px" BackColor="Green" OnClick="Button9_Click" Height="26px"/>
                </div>
                <div style="margin-top:20px"><asp:Button ID="Button3" runat="server" Text="注销信息" BackColor="Green" OnClick="Button3_Click1" Height="27px" Width="87px"/>
                 
                    <asp:Table ID="Table3" runat="server" HorizontalAlign="left" BorderStyle="Dotted" Width="275px">
                        <asp:TableRow><asp:TableCell>身份证号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                        <asp:TableRow><asp:TableCell>病人姓名    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox></asp:TableCell></asp:TableRow>

                    </asp:Table>
                
                    （请输入身份证号和姓名）</div>

                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                信息统计：<br />
                <table class="auto-style1">
                    <tr>
                        <td>病人数量：</td>
                        <td>
                            <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">病历数目：</td>
                        <td class="auto-style2">
                            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                                        <tr>
                        <td class="auto-style2">医生数目：</td>
                        <td class="auto-style2">
                            <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
               </div>
            



        </div>

   
    </form>

</body>
</html>
