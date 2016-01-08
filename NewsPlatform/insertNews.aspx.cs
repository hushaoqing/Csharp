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
public partial class insertNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idNum = Session["idNum"].ToString();
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        co.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select id 编号,title 标题,author 作者,newsTime 发布时间, idNum 管理人 from news where idNum='" + idNum + "'  order by id DESC", co);
        DataSet s = new DataSet();
        sda.Fill(s);
        GridView1.DataSource = s;
        GridView1.DataBind();
        co.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string num = Session["idNum"].ToString();
        SqlConnection co= new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        SqlCommand comm = new SqlCommand("insert into news(title,content,author,newsTime,idNum) values(@title,@content,@author,@time,@idNum)", co);
        comm.Parameters.Add("@title", SqlDbType.VarChar, 50).Value = title.Text;
        comm.Parameters.Add("@author", SqlDbType.Char, 20).Value = author.Text;
        comm.Parameters.Add("@time", SqlDbType.SmallDateTime).Value = time.Text;
        comm.Parameters.Add("@content", SqlDbType.Text).Value = content.Text;
        comm.Parameters.Add("@idNum", SqlDbType.Int).Value = num;
        try
        {
            co.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Response.Write("<script>alert('插入成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('插入失败')</script>");
        }
        finally { co.Close(); }
    }

    protected void getTime_Click(object sender, EventArgs e)
    {
        time.Text = DateTime.Now.ToString();
    }
    protected void search_Click(object sender, EventArgs e)
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        co.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select id 编号,title 标题,content 内容,author 作者,newsTime 发布时间 from news where id='"+TextBox1.Text+"'", co);
        DataSet s = new DataSet();
        sda.Fill(s);
        GridView1.DataSource = s;
        GridView1.DataBind();
        co.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("insertNews.aspx");
    }
    protected void delete_Click(object sender, EventArgs e)
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        SqlCommand comm = new SqlCommand("delete from news where id='"+TextBox1.Text+"'and title='"+TextBox2.Text+"'", co);
        try
        {
            co.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Response.Write("<script>alert('删除成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('删除失败')</script>");
        }
        finally { co.Close(); }
    }
    protected void edit_Click(object sender, EventArgs e)
    {
        Session["id"] = TextBox1.Text;
        Session["title"] = TextBox2.Text;
        Response.Write("<script>window.open('editNews.aspx','','width=300,height=500')</script>");
    }
}