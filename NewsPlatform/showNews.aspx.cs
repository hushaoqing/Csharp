using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;

public partial class showNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string myStr = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        SqlConnection conn = new SqlConnection(myStr);
        conn.Open();
        SqlDataAdapter adapt = new SqlDataAdapter("selectNews", conn);//使用存储过程selectNews，减少网络流量
        DataSet dd = new DataSet();
        adapt.Fill(dd);
        DataRow[] row = dd.Tables[0].Select("id=" + Request.QueryString["id"]);
        foreach (DataRow rs in row)
        {
            this.Page.Title = rs["title"].ToString();
            this.labTitle.Text = rs["title"].ToString();
            this.LabTime.Text = rs["newsTime"].ToString();
            this.txtContent.Text = "　　" + rs["content"].ToString();
        }

;
    }
    protected void txtContent_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.close()</script>");
    }
}