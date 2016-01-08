using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["Conn"].ToString());
         conn.Open();
         SqlDataAdapter adapt = new SqlDataAdapter("selectNews", conn);//存储过程
         adapt.SelectCommand.CommandType = CommandType.StoredProcedure;//声明是存储过程类型，不要也行；
         DataSet dd = new DataSet();
         adapt.Fill(dd);
         DataList2.DataSource = dd;
         DataList2.DataKeyField = "id";
         DataList2.DataBind();
         conn.Close();  
    }
    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(DataList2.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.open('Login.aspx','','width=410,height=210')</script>");
    }
}