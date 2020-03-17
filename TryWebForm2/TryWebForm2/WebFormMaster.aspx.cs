using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryWebForm2
{
    public partial class WebFormMaster : System.Web.UI.Page
    {
        private int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            /* if (!IsPostBack)
              {
             // List<Books> books = Books.GetPagedBooks(2,5);
             var books = Books.GetPagedBooks(2, 4);
                 GridView1.DataSource = books;
                 GridView1.DataBind();
               }  */
            counter =(int)(ViewState["Counter"] ?? 0);
            ViewState["counter"] = ++counter;

           
        }
        protected int GetCounter()
        {
            return counter;
        }

        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            spanid.InnerText = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text)).ToString();

        }
       
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}