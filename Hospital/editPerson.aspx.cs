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
public partial class edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string str = "update patient set name='" + name.Text + "',sex='" + sex.Text + "',age='" + age.Text + "',addr='" + addr.Text + "',tel='" + tel.Text + "'where idNum='"+TextBox1.Text+"'";
        SqlCommand cmd = new SqlCommand(str, conn);
        try
        {
            conn.Open();
            int record = cmd.ExecuteNonQuery();
            if (record == 1)
            {
                Response.Write("<script>alert('更新成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('更新失败')</script>");
        }
        finally { conn.Close(); }
    }
}