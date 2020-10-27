using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EAOF_by_ritu
{
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string query = "select dist_id, district_name from district0253";
                BindDropDownList(ddldistrict, query, "district_name", "dist_id", "Select district");
                ddltaluka.Enabled = false;
                ddlvillages.Enabled = false;
                ddltaluka.Items.Insert(0, new ListItem("Select taluka", "0"));
                ddlvillages.Items.Insert(0, new ListItem("Select village", "0"));
            }
        }

        


        private void BindDropDownList(DropDownList ddl, string query, string text, string value, string defaultText)
        {
            //string conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student");

            SqlCommand cmd = new SqlCommand(query);

            using (SqlConnection com = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    con.Open();
                    ddl.DataSource = cmd.ExecuteReader();
                    ddl.DataTextField = text;
                    ddl.DataValueField = value;
                    ddl.DataBind();
                    con.Close();
                }
            }
            ddl.Items.Insert(0, new ListItem(defaultText, "0"));
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (IsValid)
            {
                
                    cmd.Connection = con;
                    con.Open();

                    cmd.Parameters.AddWithValue("@fname", txtfname.Text.Trim());
                    cmd.Parameters.AddWithValue("@lname", txtlname.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobno", txtmobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@district", ddldistrict.SelectedValue);
                    cmd.Parameters.AddWithValue("@taluka", ddltaluka.SelectedValue);
                    cmd.Parameters.AddWithValue("@village", ddlvillages.SelectedValue);
                    cmd.Parameters.AddWithValue("@uid", txtuid.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtpwd.Text.Trim());


                   
                    cmd.CommandText = "INSERT INTO registration0253(fname,lname,mobno,district,taluka,village,uid,password) VALUES(@fname,@lname,@mobno,@district,@taluka,@village,@uid,@password)";

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                    Response.Redirect("login.aspx");
                    }
                    
                      con.Close();
                
            }
        }
        protected void CustomValidatoruser_ServerValidate(object source, ServerValidateEventArgs args)
        {
            SqlCommand selectMails = new SqlCommand("SELECT uid FROM registration0253 WHERE uid ='" + txtuid.Text.Trim().ToString() + "'", con);
            con.Open();
            SqlDataReader rdr = selectMails.ExecuteReader();
            if (rdr.HasRows)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
            con.Close();
        }
        protected void taluka_Changed(object sender, EventArgs e)
        {
            ddlvillages.Enabled = false;
            ddlvillages.Items.Clear();
            ddlvillages.Items.Insert(0, new ListItem("Select village", "0"));
            int talukaId = int.Parse(ddltaluka.SelectedItem.Value);
            if (talukaId > 0)
            {
                string query = string.Format("select village_Id, village_name from village0253 where talukaId = {0}", talukaId);
                BindDropDownList(ddlvillages, query, "village_name", "village_Id", "Select village");
                ddlvillages.Enabled = true;
            }
        }


        protected void district_Changed(object sender, EventArgs e)
        {
            ddltaluka.Enabled = false;
            ddlvillages.Enabled = false;
            ddltaluka.Items.Clear();
            ddlvillages.Items.Clear();
            ddltaluka.Items.Insert(0, new ListItem("Select district", "0"));
            ddlvillages.Items.Insert(0, new ListItem("Select village", "0"));
            int dist_id = int.Parse(ddldistrict.SelectedItem.Value);
            if (dist_id > 0)
            {
                string query = string.Format("select talukaId, t_nm from taluka0253 where dist_id = {0}", dist_id);
                BindDropDownList(ddltaluka, query, "t_nm", "talukaId", "Select taluka");
                ddltaluka.Enabled = true;
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtmobile.Text = string.Empty;
            txtuid.Text = string.Empty;
            txtpwd.Text = string.Empty;
            txtcpwd.Text = string.Empty;
            Response.Redirect("login.aspx");
        }
    }
}