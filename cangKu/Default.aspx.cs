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
        Button3.Visible = false;
        Button4.Visible = false;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        conn.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select  id 编号,name 名称,amount 数量,price 单价 from caiLiao", conn);
        DataSet sss = new DataSet();
        sda.Fill(sss);
        GridView1.DataSource = sss;
        GridView1.DataBind();
        conn.Close();

        conn.Open();
        SqlDataAdapter sda1 = new SqlDataAdapter("select inAndOut.id 帐单流水号,inAndOut.amount 数量,priceInAll 总价,caiLiao.name 材料,usr.name 单位,inTime 入库时间,outTime 出库时间 from inAndOut,usr,caiLiao where caiLiao.id=inAndOut.idCaiLiao and usr.id=inAndOut.idUsr", conn);
        DataSet sss1 = new DataSet();
        sda1.Fill(sss1);
        GridView2.DataSource = sss1;
        GridView2.DataBind();
        conn.Close();

        conn.Open();
        SqlDataAdapter sda2 = new SqlDataAdapter("select id 编号,name 单位名 from usr", conn);
        DataSet sss2 = new DataSet();
        sda2.Fill(sss2);
        GridView3.DataSource = sss2;
        GridView3.DataBind();
        conn.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("insert into caiLiao(id,name,amount,price) values(@id,@name,@number,@priceInAll)", conn);
        comm.Parameters.Add("@id", SqlDbType.Int).Value = bianhao.Text;
        comm.Parameters.Add("@name", SqlDbType.Char, 30).Value = mingcheng.Text;
        comm.Parameters.Add("@number", SqlDbType.Int).Value = shuliang.Text;
        comm.Parameters.Add("@priceInAll", SqlDbType.Float).Value = danjia.Text;
        int RecordeAffected = comm.ExecuteNonQuery();
        conn.Close();
        conn.Open();
        //SqlCommand comm1 = new SqlCommand("update inAndOut set inTime='"+shijian.Text+"',amount='"+shuliang.Text+"',idUsr='"+danwei.Text+"',idCaiLiao='"+bianhao.Text+"',priceInAll='"+zongjia.Text+"' ",conn);
        SqlCommand comm1 = new SqlCommand("insert into inAndOut(idCaiLiao,amount,inTime,priceInAll,idUsr) values(@id,@amount,@inTime,@priceInAll,@idUsr)", conn);
        comm1.Parameters.Add("@id", SqlDbType.Int).Value = bianhao.Text;
        comm1.Parameters.Add("@amount", SqlDbType.Int).Value = shuliang.Text;
        comm1.Parameters.Add("@inTime", SqlDbType.DateTime).Value = shijian.Text;
        comm1.Parameters.Add("@priceInAll", SqlDbType.Float).Value = zongjia.Text;
        comm1.Parameters.Add("@idUsr", SqlDbType.Int).Value = danwei.Text;
        int aaa = comm1.ExecuteNonQuery();
        conn.Close();
        try
        {
            
            
            if (RecordeAffected == 1&& aaa==1)
            {
                Response.Write("<script>alert('入库成功')</script>");
                Button3.Visible = true;

            }
        }
        catch
        {
            Response.Write("<script>alert('入库失败')</script>");
        }
        finally
        {  }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {   
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("update caiLiao set amount=amount-'"+shuliang.Text+"'where id='"+bianhao.Text+"' and name='"+mingcheng.Text+"'", conn);
        int RecordeAffected = comm.ExecuteNonQuery();
        conn.Close();
        conn.Open();
        //SqlCommand comm1 = new SqlCommand("update inAndOut set inTime='"+shijian.Text+"',amount='"+shuliang.Text+"',idUsr='"+danwei.Text+"',idCaiLiao='"+bianhao.Text+"',priceInAll='"+zongjia.Text+"' ",conn);
        SqlCommand comm1 = new SqlCommand("insert into inAndOut(idCaiLiao,amount,outTime,priceInAll,idUsr) values(@id,@amount,@outTime,@priceInAll,@idUsr)", conn);
        comm1.Parameters.Add("@id", SqlDbType.Int).Value = bianhao.Text;
        comm1.Parameters.Add("@amount", SqlDbType.Int).Value = shuliang.Text;
        comm1.Parameters.Add("@outTime", SqlDbType.DateTime).Value = shijian.Text;
        comm1.Parameters.Add("@priceInAll", SqlDbType.Float).Value = zongjia.Text;
        comm1.Parameters.Add("@idUsr", SqlDbType.Int).Value = danwei.Text;
        int aaa = comm1.ExecuteNonQuery();
        conn.Close();
        try
        {
            if (RecordeAffected == 1 && aaa==1)
            {
                Response.Write("<script>alert('出库成功')</script>");
                Button4.Visible = true;

            }
        }
        catch
        {
            Response.Write("<script>alert('出库失败')</script>");
        }
        finally
        { conn.Close(); }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["id"] = bianhao.Text;
        Session["name"] = mingcheng.Text;
        Session["amount"] = shuliang.Text;
        Session["price"] = danjia.Text;
        Session["priceInAll"] = zongjia.Text;
        Session["time"] = shijian.Text;
        Session["idUsr"] = danwei.Text;
        Response.Write("<script>window.open('zhangDan.aspx','','width=300,height=300')</script>");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        Session["id"] = bianhao.Text;
        Session["name"] = mingcheng.Text;
        Session["amount"] = shuliang.Text;
        Session["price"] = danjia.Text;
        Session["priceInAll"] = zongjia.Text;
        Session["time"] = shijian.Text;
        Session["idUsr"] = danwei.Text;
        Response.Write("<script>window.open('zhangDan.aspx','','width=300,height=300')</script>");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        shijian.Text = DateTime.Now.ToString();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('info.aspx','','width=670,height=400')</script>");
    }
}