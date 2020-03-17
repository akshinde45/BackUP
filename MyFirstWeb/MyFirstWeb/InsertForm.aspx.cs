using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWeb
{
    public partial class InsertForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);
            string pname = TextBox2.Text;
            string pcategroy = TextBox3.Text;

            int pprice = Convert.ToInt32(TextBox4.Text);
            product pr = new product { id = pid, name = pname, category = pcategroy, price = pprice };
            DataLayer dl = new DataLayer();
            dl.InsertData(pr);



         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);
            string pname = TextBox2.Text;
            string pcategroy = TextBox3.Text;

            int pprice = Convert.ToInt32(TextBox4.Text);
            product pr = new product { id = pid, name = pname, category = pcategroy, price = pprice };
            DataLayer dl = new DataLayer();
            dl.Updatedata(pr);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);
          
            product pr = new product { id = pid };

            DataLayer dl = new DataLayer();
            dl.Deletedata(pr);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
                
            
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);

            product pr = new product { id = pid };


            DataLayer dl = new DataLayer();


            var pdlst = dl.Searchdata(pr);
            GridView2.DataSource = pdlst;
            GridView2.DataBind();

            


        }
    }
}