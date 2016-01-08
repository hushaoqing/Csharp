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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MessageTB.Visible =false;
        biaoqian.Visible = false;
        GridView2.Visible = true;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string str1 = "select count(*) from patient";      
        conn.Open();
        SqlCommand comm1 = new SqlCommand(str1, conn);
        SqlDataReader da1 = comm1.ExecuteReader();
        if (da1.Read()) { Label15.Text = da1[""].ToString(); }
        conn.Close();
        string str2 = "select count(*) from patientInfo";
        conn.Open();
        SqlCommand comm2 = new SqlCommand(str2, conn);
        SqlDataReader da2 = comm2.ExecuteReader();
        if (da2.Read()) { Label16.Text = da2[""].ToString(); }
        conn.Close();
         string str3 = "select count(*) from doctor";
         conn.Open();
         SqlCommand comm3 = new SqlCommand(str3, conn);
         SqlDataReader da3 = comm3.ExecuteReader();
         if (da3.Read()) { Label17.Text = da3[""].ToString(); }
         conn.Close();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string strcommand = "insert patient values(@name,@idNum,@age,@tel,@addr,@sex)";
        SqlCommand cmdMsg = new SqlCommand(strcommand, conn);
        cmdMsg.Parameters.Add("@name",SqlDbType.Char,50).Value=name.Text.ToString();
        cmdMsg.Parameters.Add("@idNum", SqlDbType.Char, 18).Value = idNum.Text;
        cmdMsg.Parameters.Add("@age",SqlDbType.Char,2).Value=age.Text;
        cmdMsg.Parameters.Add("@sex",SqlDbType.Char,10).Value=sex.Text;
        cmdMsg.Parameters.Add("@tel",SqlDbType.Char,11).Value=tel.Text;
        cmdMsg.Parameters.Add("@addr",SqlDbType.VarChar,50).Value=addr.Text;

        try
        {
            conn.Open();
            int RecordeAffected = cmdMsg.ExecuteNonQuery();
            if (RecordeAffected==1)
            {
                MessageTB.Text = "插入成功";
                MessageTB.Visible = true;
                Response.Write("<script>alert('插入成功')</script>");

            }
        }
        catch
        {
            MessageTB.Text = "插入失败，系统错误！";
            MessageTB.Visible = true;
            Response.Write("<script>alert('插入失败')</script>");
        }
        finally { conn.Close(); }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Response.Write("<script>confirm('确定提交信息?')</script>");
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string str = "insert patientInfo values(@name,@inhosp,@outhosp,@medicalHistory,@caseHistory,@idNum,@id)";
        SqlCommand cmd = new SqlCommand(str, conn);
        cmd.Parameters.Add("@name", SqlDbType.Char,50).Value = name1.Text;
        cmd.Parameters.Add("@inhosp", SqlDbType.DateTime).Value = inHospital.Text;
        cmd.Parameters.Add("@outhosp", SqlDbType.DateTime).Value = outHospital.Text;
        cmd.Parameters.Add("@medicalHistory", SqlDbType.Text).Value = medicalHistory.Text;
        cmd.Parameters.Add("@caseHistory", SqlDbType.Text).Value = caseHistory.Text;
        cmd.Parameters.Add("@idNum", SqlDbType.Char, 18).Value =id.Text;
        cmd.Parameters.Add("id", SqlDbType.Int).Value = Session["id"].ToString();

        try
        {
            conn.Open();
            int record = cmd.ExecuteNonQuery();
            if (record == 1)
            {
                Response.Write("<script>alert('插入成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('插入失败')</script>");
        }
        finally { conn.Close(); }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["name"] = searchName.Text;
        Response.Redirect("View.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        inHospital.Text = DateTime.Now.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        outHospital.Text = DateTime.Now.ToString();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string strcomm = "select idNum as 身份证号,name as 姓名 from patientInfo where name='" + name1.Text + "'";
            conn.Open();
            SqlCommand stt = new SqlCommand(strcomm,conn);
            SqlDataReader srd = stt.ExecuteReader();
            if (srd.Read())
            {
                conn.Close();
                conn.Open();
                SqlDataAdapter ss = new SqlDataAdapter(strcomm, conn);
                DataSet sss = new DataSet();
                ss.Fill(sss);
                GridView2.DataSource = sss;
                GridView2.DataBind();
                            }
            else
            {
                GridView2.Visible = false;
                biaoqian.Visible = true;
                biaoqian.Text = "无此人病历！";
            }
            conn.Close();
        //id.Text = sss.Tables[0].Rows[0][0].ToString();
        //SqlCommand stt = new SqlCommand(strcomm, conn);
        //MessageTB.Text = stt.ExecuteScalar().ToString();
        //SqlDataReader srd = stt.ExecuteReader();
        //string str="";
        /*while (srd.Read())
        {
           str=srd.ToString();
        }
        MessageTB.Text = str;*/
        
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string str = "delete from patient where idNum='"+TextBox1.Text+"' and name='"+TextBox2.Text+"'";
        SqlCommand cmd = new SqlCommand(str, conn);
        try
        {
            conn.Open();
            int record = cmd.ExecuteNonQuery();
            if (record >= 1)
            {
                Response.Write("<script>alert('注销成功')</script>");

            }
        }
        catch
        {
            Response.Write("<script>alert('注销失败')</script>");
        }
        finally { conn.Close(); }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {

    }
    protected void Button7_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("editPerson.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("editCase.aspx");
    }
}