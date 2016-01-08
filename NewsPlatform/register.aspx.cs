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

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["Conn"].ToString());
        SqlCommand comm = new SqlCommand("insert into usr(name,psd) values(@name,@psd)", conn);
        comm.Parameters.Add("@name", SqlDbType.Char, 10).Value = TextBox1.Text;
        comm.Parameters.Add("@psd", SqlDbType.Char, 10).Value = TextBox2.Text;
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Session["name"] = TextBox1.Text;
                Response.Write("<script>alert('注册成功')</script>");
                Response.Redirect("onTheRoad.aspx");

            }
        }
        catch
        {
            Response.Write("<script>alert('注册失败')</script>");
        }
        finally { conn.Close(); }
    }
}