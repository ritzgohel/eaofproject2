using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EAOF_by_ritu
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student");
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select rid from registration0253 where uid=@uid and password=@password";
            cmd.Parameters.AddWithValue("@uid", txtuid.Text.Trim().ToString());
            cmd.Parameters.AddWithValue("@password", txtpwd.Text.Trim().ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["user"] = txtuid.Text.Trim().ToString();

                Response.Redirect("profitloss.aspx");

                con.Close();
            }
            else
            {
                if (txtuid.Text.ToString() == "admin" && txtpwd.Text.ToString() == "admin")
                {
                    Session["admin"] = txtuid.Text.Trim().ToString();

                    con.Close();

                    Response.Redirect("adminhome.aspx");
                }
                else
                {

                    Label1.ForeColor = System.Drawing.Color.Red;
                     Label1.Text = "User Name or Password incorrect";

                }
            }
            txtuid.Text = string.Empty;
            txtpwd.Text = string.Empty;
        }
        //string check = "Select count(*) from registration0253 Where uid ='" + txtuid.Text.Trim() + "'And password= '" + txtpwd.Text.Trim() + "'";
        //SqlCommand com = new SqlCommand(check, con);
        //con.Open();
        //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        //con.Close();
        //if (temp == 1)
        //{
        //    Response.Redirect("profitloss.aspx");
        //}
        //else
        //{
        //    Label1.ForeColor = System.Drawing.Color.Red;
        //    Label1.Text = "User Name or Password incorrect";
        //}

    }
    
}