using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("select * from doctor where id='" + name.Text + "'and psw='" + psw.Text + "'", conn);
        SqlDataReader srd = comm.ExecuteReader();
        if (srd.Read())
        {   
            Session["id"]=name.Text.ToString();
            Response.Write("<script>window.open('Default.aspx')</script>");
        }
        else
        {
            Response.Write("<script>alert('密码错误/账号不存在')</script>");
        }
        conn.Close();
    }
}