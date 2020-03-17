using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
//using System.Configuration;

namespace DateTimeTry
{
    
    public class DataLayer
    {
        string constring = "";
        public DataLayer()
        {


            try
            {
                constring = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;

            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
        }
        public string InsertData(data dt)
        {
            string insertquery = String.Format("insert into doj(date_joining)" + "values({0});", dt.doj);
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
                msg = "Record Inserted";
            }
            return msg;
        }
    }
}