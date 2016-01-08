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


public partial class information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        conn.Open();
        SqlDataAdapter comm = new SqlDataAdapter("select id 编号,name 服装,number 数量 from closeAndDevice", conn);
        DataSet sad = new DataSet();
        comm.Fill(sad);
        GridView1.DataSource = sad;
        GridView1.DataBind();
        conn.Close();
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        conn.Open();
        SqlDataAdapter cott = new SqlDataAdapter("select BH 单号,id 编号,rentName 名称,number 数量,rentTime 租赁时间,returnTime 归还时间,name 租赁人 from closeRented,usr where usr.idPerson=closeRented.idPerson ", conn);
        DataSet sap = new DataSet();
        cott.Fill(sap);
        GridView2.DataSource = sap;
        GridView2.DataBind();
        conn.Close();
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        conn.Open();
        SqlDataAdapter com = new SqlDataAdapter("select idPerson 租赁人,name 名称,tel 电话, addr 地址 from usr", conn);
        DataSet sa = new DataSet();
        com.Fill(sa);
        GridView3.DataSource = sa;
        GridView3.DataBind();
        conn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("insert closeAndDevice(id,name,number) values(@id,@name,@number)", conn);
        comm.Parameters.Add("@id", SqlDbType.Int).Value = bianhao.Text;
        comm.Parameters.Add("@name", SqlDbType.Char, 20).Value = mingcheng.Text;
        comm.Parameters.Add("@number", SqlDbType.Int).Value = shuliang.Text;
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Response.Write("<script>alert('入库成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('入库失败')</script>");
        }
        finally
        { conn.Close(); }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("information.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("delete from closeAndDevice where id='"+TextBox2.Text+"' and name='"+TextBox4.Text+"'", conn);
        try
        {
            conn.Open();
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
        finally { conn.Close(); }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        SqlCommand comm = new SqlCommand("update closeAndDevice set number='"+TextBox3.Text+"' where id='"+TextBox1.Text+"'",conn);
        try
        {
            conn.Open();
            int RecordeAffected = comm.ExecuteNonQuery();
            if (RecordeAffected == 1)
            {
                Response.Write("<script>alert('修改成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('修改失败')</script>");
        }
        finally { conn.Close(); }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}