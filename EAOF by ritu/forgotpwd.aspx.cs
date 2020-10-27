using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Collections.Specialized;

namespace EAOF_by_ritu
{
    public partial class forgotpwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void sendpassword(String mobno, String password, String uid)
        {

            string message = "Hi " + uid + " , Your Password is " + password + " .";

            String message1 = HttpUtility.UrlEncode(message);
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                {
                {"apikey","AKEtJZhVox0-ChiA3a0GkcrUAW37aqh9pc1ZIIlMGX"},
                {"numbers" , mobno},
                {"message" , message1},
                {"sender" , "TXTLCL"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                string mobilelast = "*******" + mobno.Substring(8);
                flblmbl.Text = "Your Password Has Been Sent to Registered Mobile Number " + mobilelast;
            }
        }

        protected void fbtnpwd_Click(object sender, EventArgs e)
        {
            String mobno;
            String password;
            String mycon = "Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student";
            String myquery = "Select * from registration0253 where uid='" + ftxtuid.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Label3.Text = "Data Found";
                mobno = ds.Tables[0].Rows[0]["mobno"].ToString();
                password = ds.Tables[0].Rows[0]["password"].ToString();
                sendpassword(mobno, password, ftxtuid.Text);

            }
            else
            {
                flblmbl.Text = "Your Username is Not Valid";

            }
            con.Close();

        }
    }
}