using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace EAOF_by_ritu
{
    public partial class chart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
        decimal[] yr = new decimal[10];
        String[] pro = new string[10];
        String mycon = "Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student";
        String myquery = "Select * from showgraph0253 where uid='" + ddl1.Text+"'";
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
            
                yr[0] = Convert.ToInt32(ds.Tables[0].Rows[0]["1991"].ToString());
                yr[1] = Convert.ToInt32(ds.Tables[0].Rows[0]["1992"].ToString());
                yr[2] = Convert.ToInt32(ds.Tables[0].Rows[0]["1993"].ToString());
                yr[3] = Convert.ToInt32(ds.Tables[0].Rows[0]["1994"].ToString());
                yr[4] = Convert.ToInt32(ds.Tables[0].Rows[0]["1995"].ToString());
                yr[5] = Convert.ToInt32(ds.Tables[0].Rows[0]["1996"].ToString());
                yr[6] = Convert.ToInt32(ds.Tables[0].Rows[0]["1997"].ToString());
                yr[7] = Convert.ToInt32(ds.Tables[0].Rows[0]["1998"].ToString());
                yr[8] = Convert.ToInt32(ds.Tables[0].Rows[0]["1999"].ToString());
                yr[9] = Convert.ToInt32(ds.Tables[0].Rows[0]["2000"].ToString());
                pro[0] = "1991";
                pro[1] = "1992";
                pro[2] = "1993";
                pro[3] = "1994";
                pro[4] = "1995";
                pro[5] = "1996";
                pro[6] = "1997";
                pro[7] = "1998";
                pro[8] = "1999";
                pro[9] = "2000";
            }
        con.Close();
        BarChart1.Series.Add(new AjaxControlToolkit.BarChartSeries { Data = yr });
        BarChart1.CategoriesAxis = string.Join(",", pro);
        BarChart1.ChartTitle = "Farmer's Performence";

        }
    }
}