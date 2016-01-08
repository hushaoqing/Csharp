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
public partial class editNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(Session["id"].ToString());

    }
    protected void edit_Click(object sender, EventArgs e)
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        SqlCommand comm = new SqlCommand("update news set title='"+title.Text+"',content='"+content.Text+"',author='"+author.Text+"',newsTime='"+time.Text+"' where id='" + Session["id"].ToString() + "'and title='"+Session["title"].ToString()+"'", co);
        try
        {
            co.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Response.Write("<script>alert('更新成功')</script>");
                Response.Write("<script>window.close()</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('更新失败')</script>");
        }
        finally
        { co.Close(); }
    }
    protected void getTime_Click(object sender, EventArgs e)
    {
        time.Text = DateTime.Now.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        co.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select * from news where id='" + Session["id"].ToString() + "'and title='" + Session["title"].ToString() + "'", co);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        foreach (DataRow rs in ds.Tables[0].Rows)
        {
            title.Text = rs["title"].ToString();
            author.Text = rs["author"].ToString();
            time.Text = rs["newsTime"].ToString();
            content.Text = rs["content"].ToString();
        }
        co.Close();
    }
}