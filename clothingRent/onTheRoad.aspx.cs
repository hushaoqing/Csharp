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

public partial class onTheRoad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["clothingRentConnectionString"].ToString());
        conn.Open();
        SqlDataAdapter sad = new SqlDataAdapter("select * from usr where name='"+Session["name"].ToString()+"' ", conn);
        DataSet sss = new DataSet();
        sad.Fill(sss);
        foreach (DataRow ds in sss.Tables[0].Rows) { Label1.Text = ds["idPerson"].ToString(); }
        Session["idPerson"] = Label1.Text;
        conn.Close();
    }
}