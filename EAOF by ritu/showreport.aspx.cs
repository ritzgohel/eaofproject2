using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;





namespace EAOF_by_ritu
{
    public partial class showreport : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student");
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["user"].ToString();
           

            DataTable dt = new DataTable();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT txtuid,ddlyear,txtland,cropnm,txttotpro,grossprofit,netprofit from pl0253 where Id =(select MAX(Id) from pl0253)", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

            sqlCmd.Parameters.AddWithValue("@user", user);

            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                name.Text = dt.Rows[0]["txtuid"].ToString();
                year.Text = dt.Rows[0]["ddlyear"].ToString();
                crop.Text = dt.Rows[0]["cropnm"].ToString();
                land.Text = dt.Rows[0]["txtland"].ToString();
                production.Text = dt.Rows[0]["txttotpro"].ToString();
                gross.Text = dt.Rows[0]["grossprofit"].ToString();
                net.Text = dt.Rows[0]["netprofit"].ToString();
                
                
            }
            con.Close();
        }

       
    }

    
}