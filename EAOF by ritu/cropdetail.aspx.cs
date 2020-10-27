using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EAOF_by_ritu
{
    public partial class cropdetail : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from pl0253";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                gv1.DataSource = dr;
                gv1.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();

                }
            }
        }



        protected void txtsrch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from pl0253 where txtuid like '%" + txtsrch.Text + "%'";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                gv1.DataSource = dr;
                gv1.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();


            }
        }
    }
}