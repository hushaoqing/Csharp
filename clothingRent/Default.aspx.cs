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

public partial class _Default : System.Web.UI.Page
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
        SqlDataAdapter cott = new SqlDataAdapter("select BH 单号,id 编号,rentName 名称,number 数量,rentTime 租赁时间,returnTime 归还时间 from closeRented where idPerson='"+Session["idPerson"].ToString()+"'", conn);
        DataSet sap = new DataSet();
        cott.Fill(sap);
        GridView2.DataSource = sap;
        GridView2.DataBind();
        conn.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("update closeAndDevice set number=number-'"+TextBox7.Text+"' where id='"+TextBox6.Text+"'", conn);
        int RecordeAffected = comm.ExecuteNonQuery();
        conn.Close();
        conn.Open();
        SqlCommand codd = new SqlCommand("insert into closeRented(id,rentName,number,rentTime,idPerson) values(@id,@rentName,@number,@rentTime,@idPerson)",conn);
        codd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox6.Text;
        codd.Parameters.Add("@rentName", SqlDbType.Char,20).Value = TextBox1.Text;
        codd.Parameters.Add("@number", SqlDbType.Int).Value = TextBox7.Text;
        codd.Parameters.Add("@rentTime", SqlDbType.DateTime).Value = DateTime.Now.ToString();
        codd.Parameters.Add("@idPerson", SqlDbType.Int).Value = Session["idPerson"].ToString();
        int record = codd.ExecuteNonQuery();
        conn.Close();
        try
        {  
            if (RecordeAffected == 1 && record == 1)
            {
                Response.Write("<script>alert('租赁成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('租赁失败')</script>");
        }
        finally {  }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("update closeAndDevice set number=number+'" + TextBox11.Text + "' where id='" + TextBox10.Text + "' ", conn);
        int RecordeAffected = comm.ExecuteNonQuery();
        conn.Close();
        conn.Open();
        SqlCommand codd = new SqlCommand("update closeRented set returnTime='"+DateTime.Now.ToString()+"',number=number-'"+TextBox11.Text+"' where BH='"+TextBox3.Text+"'", conn);
        int record = codd.ExecuteNonQuery();
        conn.Close();
        try
        {
            if (RecordeAffected == 1 && record == 1)
            {
           Response.Write("<script>alert('归还成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('归还失败')</script>");
        }
        finally { }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("information.aspx");
    }
}