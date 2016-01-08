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
public partial class info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("update caiLiao set amount='"+amount.Text+"',price='"+price.Text+"'where id='"+id.Text+"'",conn);
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("insert into usr(id,name) values(@id,@name)", conn);
        comm.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text;
        comm.Parameters.Add("@name",SqlDbType.Char,30).Value = TextBox3.Text;
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Response.Write("<script>alert('添加成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('添加失败')</script>");
        }
        finally { conn.Close(); }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("update usr set name='"+TextBox3.Text+"'where id='"+TextBox1.Text+"' ", conn);
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
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