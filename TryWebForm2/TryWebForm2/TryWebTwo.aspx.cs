using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryWebForm2
{
    public partial class TryWebTwo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string[] GetCity()
        {
            return new[] { "ak", "shiva", "modak" };
        }
    }
}