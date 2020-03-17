using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace MyFirstWeb
{
    public class DataLayer
    {
        private string constring = "";

        public DataLayer()
        {
            try
            {
                constring = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;

            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

        }
        public DataSet Showdata()
        {
            string query = "select *from product";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return ds;
        }

        public string InsertData(product pd)
        {
            string insertquery = String.Format("insert into product(pid,pname,pcategory,price)" + "values({0},'{1}','{2}',{3});", pd.id, pd.name, pd.category, pd.price);
            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {


                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    i = sda.Fill(ds);
                    sda.Update(ds);
                    // i = cmd.ExecuteNonQuery();
                    //  cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (i > 0)
            {
                // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + msg + "')", true);
                //return "New Employee Added Successfully";
                // string script = "alert('Data Saved Successfully');"; ClientScript.RegisterStartUpScript(this.GetType(), "saved", script);
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "$('#message').html('" + msg + "').show().fadeOut(2000);", true);
                msg = "Record Inserted";
            }
            return msg;
        }

        public string Updatedata(product pd)
        {
            string UpdateQuery = String.Format("update  product set pname='" + pd.name + "', pcategory='" + pd.category + "',price='" + pd.price + "' where pid='" + pd.id + "'");

            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {


                    SqlCommand cmd = new SqlCommand(UpdateQuery, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    i = sda.Fill(ds);
                    sda.Update(ds);
                    // i = cmd.ExecuteNonQuery();
                    //  cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (i > 0)
            {
                // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + msg + "')", true);
                //return "New Employee Added Successfully";
                // string script = "alert('Data Saved Successfully');"; ClientScript.RegisterStartUpScript(this.GetType(), "saved", script);
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "$('#message').html('" + msg + "').show().fadeOut(2000);", true);
                msg = string.Format("Record Inserted");
            }
            return msg;
        }
        public string Deletedata(product pd)
        {
            string Deletequery = String.Format("delete from  product  where pid='" + pd.id + "'");

            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand(Deletequery, con);
                    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    //i = sda.Fill(ds);
                    // sda.Update(ds);
                    //cmd.ExecuteNonQuery();
                    //  cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (i > 0)
            {
                
                //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "akshay", "alert('{Text come to here}'); ", true);
            }
            return msg;
        }
        public DataSet Searchdata(product pd)
        {
            string Searchquery = String.Format("select *from  product  where pid like '" + pd.id + "'");

            DataSet ds = new DataSet();
           
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {

                  
                    SqlCommand cmd = new SqlCommand(Searchquery, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                     sda.Fill(ds);
                     sda.Update(ds);
                   
                    //  cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return ds;
        }
        

           
        }
       
    }

