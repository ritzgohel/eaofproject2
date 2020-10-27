using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

namespace EAOF_by_ritu
{
    public partial class userchart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //string user = Session["user"].ToString();
            decimal[] yr = new decimal[11];
            String[] pro = new string[11];
            String mycon = "Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student";
            String myquery = "SELECT txttotpro,txtland,negoprice,lbrcost,fertilizercost,seedcost,irrcost,machincharge,picost,grossprofit,netprofit from pl0253 where Id =(select MAX(Id) from pl0253)";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(myquery,con);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                yr[0] = Convert.ToInt32(ds.Tables[0].Rows[0]["txttotpro"].ToString());
                yr[1] = Convert.ToInt32(ds.Tables[0].Rows[0]["txtland"].ToString());
                yr[2] = Convert.ToInt32(ds.Tables[0].Rows[0]["negoprice"].ToString());
                yr[3] = Convert.ToInt32(ds.Tables[0].Rows[0]["lbrcost"].ToString());
                yr[4] = Convert.ToInt32(ds.Tables[0].Rows[0]["fertilizercost"].ToString());
                yr[5] = Convert.ToInt32(ds.Tables[0].Rows[0]["seedcost"].ToString());
                yr[6] = Convert.ToInt32(ds.Tables[0].Rows[0]["irrcost"].ToString());
                yr[7] = Convert.ToInt32(ds.Tables[0].Rows[0]["machincharge"].ToString());
                yr[8] = Convert.ToInt32(ds.Tables[0].Rows[0]["picost"].ToString());
                yr[9] = Convert.ToInt32(ds.Tables[0].Rows[0]["grossprofit"].ToString());
                yr[10] = Convert.ToInt32(ds.Tables[0].Rows[0]["netprofit"].ToString());
                pro[0] = "Total Production";
                pro[1] = "Land";
                pro[2] = "Selling Price";
                pro[3] = "Labour Cost";
                pro[4] = "Fertilizer Cost";
                pro[5] = "Seed Cost";
                pro[6] = "Irrigation Cost";
                pro[7] = "Machinary Charges";
                pro[8] = "Pesticide Or Insecticide Cost";
                pro[9] = "Gross Income";
                pro[10] = "Net Income";
            }
            con.Close();
            BarChart1.Series.Add(new AjaxControlToolkit.BarChartSeries { Data = yr });
            BarChart1.CategoriesAxis = string.Join(",", pro);
            BarChart1.ChartTitle = "Cost Evalution";


        }

       
    }
}