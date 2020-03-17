using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace MyFirstWeb
{
    public partial class MyFirstWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if(!this.IsPostBack)
            {
                 DataLayer dl = new DataLayer();
                /var pdlst = dl.Showdata();
                 GridView1.DataSource = pdlst;
                 GridView1.DataBind();
                product pr = Setdata();
                var pdlst = dl.InsertData(pr);
            }*/
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /* SqlCommand cmd;
            SqlConnection con;
            cmd.Parameters.AddWithValue("id", TextBox1.Text);
            cmd.Parameters.AddWithValue("name", TextBox2.Text);
            cmd.Parameters.AddWithValue("category", TextBox3.Text);
            cmd.Parameters.AddWithValue("price", TextBox4.Text);
           
            con.Open();
            int k = cmd.ExecuteNonQuery();
            if (k != 0)
            {
                Console.WriteLine("insert");
            }*/
        }
    }
}