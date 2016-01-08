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


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        name.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("select * from usr where id='"+name.Text+"'and psd='"+password.Text+"'",conn);
        SqlDataReader srd = comm.ExecuteReader();
        if(srd.Read())
        {
            Session["idNum"] = name.Text;
            Response.Write("<script>window.open('insertNews.aspx');window.close();</script>");
        }else
        {
            Response.Write("<script>alert('密码错误/账号不存在')</script>");
        }
        conn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('register.aspx');window.close();</script>");
    }
}