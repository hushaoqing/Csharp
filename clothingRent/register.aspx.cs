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
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("insert  usr(name,tel,addr,psw) values(@name,@tel,@addr,@psw)", conn);
        comm.Parameters.Add("@name", SqlDbType.Char, 20).Value = TextBox3.Text;
        comm.Parameters.Add("@tel", SqlDbType.Char, 11).Value = TextBox4.Text;
        comm.Parameters.Add("@addr", SqlDbType.Char, 50).Value = TextBox5.Text;
        comm.Parameters.Add("@psw", SqlDbType.Char, 10).Value = TextBox1.Text;
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Session["name"] = TextBox3.Text;
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