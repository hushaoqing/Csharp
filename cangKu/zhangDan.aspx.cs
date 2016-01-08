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

public partial class zhangDan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        conn.Open();
        string str1 = "select * from caiLiao where id='"+Session["id"].ToString()+"'";
        SqlDataAdapter da = new SqlDataAdapter(str1,conn);
        DataSet daa = new DataSet();
        da.Fill(daa);
        foreach (DataRow rs in daa.Tables[0].Rows) 
        {
            Label1.Text = rs["id"].ToString();
            Label2.Text = rs["name"].ToString();
            Label3.Text = rs["amount"].ToString();
            Label4.Text = rs["priceInAll"].ToString();
        }
        conn.Close();*/
        String a = Session["id"].ToString();
        String b = Session["name"].ToString();
        String c = Session["amount"].ToString();
        String d = Session["price"].ToString();
        //Label1.Text = a;
        Label2.Text = b;
        Label3.Text = c;
        Label4.Text = d;
        Label5.Text=Session["priceInAll"].ToString();
        Label7.Text = Session["time"].ToString();

        //Session["idUsr"] = 2;
        //Label6.Text = Session["idUsr"].ToString();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cangKuConnectionString"].ToString());
        conn.Open();
        SqlCommand comm = new SqlCommand("select * from usr where id='"+Session["idUsr"].ToString()+"'",conn);
        SqlDataReader sda = comm.ExecuteReader();
        if (sda.Read()) 
        {
            Label6.Text = sda["name"].ToString(); 
        }
        conn.Close();

    }
}