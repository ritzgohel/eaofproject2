using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace EAOF_by_ritu
{
    public partial class profitloss : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=10.112.60.43;Initial Catalog=Student;User ID=student;Password=student");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["user"].ToString();

            DataTable dt = new DataTable();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT uid from registration0253 where uid = @user", con);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

            sqlCmd.Parameters.AddWithValue("@user", user);

            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lbluid.Text = dt.Rows[0]["uid"].ToString();
            }
            con.Close();

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            SqlCommand cmd3 = new SqlCommand();
            lbladd.Visible = false;
            lblcost.Visible = false;
            lblnet.Visible = false;
            lbladd.Text = (Convert.ToInt32(txtlbrcost.Text) + Int32.Parse(txtfertilizercost.Text) + Int32.Parse(txtseedcost.Text) + Int32.Parse(txtmachincharge.Text) + Int32.Parse(txtirrcost.Text) + Int32.Parse(txtpicost.Text) + Convert.ToInt32(txttranspcost.Text)).ToString().Trim();
            lblcost.Text = (Convert.ToInt32(lbladd.Text) * Int32.Parse(txtland.Text)).ToString().Trim();
            lblnet.Text = (Convert.ToDouble(txtnegoprice.Text) - Convert.ToDouble(lblcost.Text)).ToString().Trim();


            if (Page.IsValid)
            {

                cmd.Connection = con;
                cmd2.Connection = con;
                cmd3.Connection = con;
                con.Open();

                cmd.Parameters.AddWithValue("@txtuid", lbluid.Text.Trim());
                cmd.Parameters.AddWithValue("@ddlyear", ddlyear.SelectedValue);
                cmd.Parameters.AddWithValue("@cropnm", txtcropnm.Text.Trim());
                cmd.Parameters.AddWithValue("@txtland", txtland.Text.Trim());
                cmd.Parameters.AddWithValue("@negoprice", txtnegoprice.Text.Trim());
                cmd.Parameters.AddWithValue("@lbrcost", txtlbrcost.Text.Trim());
                cmd.Parameters.AddWithValue("@fertilizercost", txtfertilizercost.Text.Trim());
                cmd.Parameters.AddWithValue("@seedcost", txtseedcost.Text.Trim());
                cmd.Parameters.AddWithValue("@irrcost", txtirrcost.Text.Trim());
                cmd.Parameters.AddWithValue("@machincharge", txtmachincharge.Text.Trim());
                cmd.Parameters.AddWithValue("@picost", txtpicost.Text.Trim());
                cmd.Parameters.AddWithValue("@txttotpro", txttotpro.Text.Trim());
                cmd.Parameters.AddWithValue("@txttranspcost", txttranspcost.Text.Trim());
                cmd.Parameters.AddWithValue("@grossprofit", txtnegoprice.Text.Trim());
                cmd.Parameters.AddWithValue("@netprofit", lblnet.Text);

                Session["prod"] = txttotpro.Text.Trim().ToString();
                cmd.CommandText = "INSERT INTO pl0253(txtuid,ddlyear,cropnm,txtland,negoprice,lbrcost,fertilizercost,seedcost,irrcost,machincharge,picost,txttotpro,txttranspcost,grossprofit,netprofit) VALUES(@txtuid,@ddlyear,@cropnm,@txtland,@negoprice,@lbrcost,@fertilizercost,@seedcost,@irrcost,@machincharge,@picost,@txttotpro,@txttranspcost,@grossprofit,@netprofit)";

                if (cmd.ExecuteNonQuery() > 0)
                {

                    if (Session["user"] == null)
                    { Response.Redirect("login.aspx"); }
                    else
                    {


                        //txtuid,1991,1992,1993,1994,1995,1996,1997,1998,1999,2000
                        //string user = Session["user"].ToString();


                        string user = Session["user"].ToString();

                        DataTable dt = new DataTable();
                        //con.Open();
                        SqlCommand sqlCmd = new SqlCommand("SELECT uid from showgraph0253 where uid = @user", con);
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                        sqlCmd.Parameters.AddWithValue("@user", user);
                        cmd3.Parameters.AddWithValue("@uid", user);


                        sqlDa.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (ddlyear.SelectedValue == "1991")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1991] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "' ; ";
                            }
                            else if (ddlyear.SelectedValue == "1992")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1992] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1993")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1993] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1994")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1994] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1995")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1995] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1996")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1996] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1997")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1997] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1998")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1998] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }
                            else if (ddlyear.SelectedValue == "1999")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1999] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "' ; ";
                            }
                            else if (ddlyear.SelectedValue == "2000")
                            {
                                cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[2000] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                            }

                        }
                        else
                        {
                            
                            cmd3.CommandText = "insert into showgraph0253 (uid)values(@uid)";
                            
                            if (cmd3.ExecuteNonQuery() > 0)
                            {

                                if (ddlyear.SelectedValue == "1991")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1991] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1992")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1992] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1993")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1993] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1994")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1994] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1995")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1995] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1996")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1996] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1997")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1997] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1998")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1998] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                                else if (ddlyear.SelectedValue == "1999")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[1999] = " + txttotpro.Text.Trim() + " WHERE uid = '"+user+"' ; ";
                                }
                                else if (ddlyear.SelectedValue == "2000")
                                {
                                    cmd2.CommandText = "UPDATE [dbo].[showgraph0253] SET[2000] = " + txttotpro.Text.Trim() + " WHERE uid = '" + user + "'; ";
                                }
                            }

                        }
                        if (cmd2.ExecuteNonQuery() > 0)
                        {
                            Response.Redirect("showreport.aspx");
                        }
                        con.Close();

                    }
                }
            }
                      
        }

    }
}