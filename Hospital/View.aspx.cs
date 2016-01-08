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

public partial class view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        sss.Visible = false;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ToString());
        string strcomm = "select num 账单号 ,patient.name as 姓名,patient.idNum 身份证号,age 年龄,tel 电话,addr 地址,sex 性别,inhosp 入院时间,outhosp 出院时间,medicalHistory 病史,caseHistory 病历,id 主治医生 from patient,patientInfo where patient.idNum=patientInfo.idNum and patient.name ='" + Session["name"].ToString() + "'";
        conn.Open();
        SqlCommand strc = new SqlCommand(strcomm, conn);
        SqlDataReader srd = strc.ExecuteReader();
        if (srd.Read())
        {
            conn.Close();
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(strcomm, conn);
            DataSet s = new DataSet();
            adapt.Fill(s);
            GridView1.DataSource = s;
            GridView1.DataBind();
            conn.Close();
        }
        else 
        {
            GridView1.Visible = false;
            sss.Visible = true;
            sss.Text = "无此人信息/病历，请先入库/查看病历！";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}