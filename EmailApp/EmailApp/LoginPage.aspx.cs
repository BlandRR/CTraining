using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EmailApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String p = (Request.QueryString["p"]);
            if (p == "error")
            {
                Label1.Text = "Invalid Username or Password";
            }
        }
    }
}