using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DateTimeTry
{
    public partial class DateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string edoj = TextBox1.Text;


            data dt = new data {  doj = edoj };
            DataLayer dl = new DataLayer();
            dl.InsertData(dt);
        }
    }
}