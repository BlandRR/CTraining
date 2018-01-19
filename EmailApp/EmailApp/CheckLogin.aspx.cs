using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EmailApp
{
    public partial class CheckLogin : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            String u = (Request.Form["Username"]);
            String p = (Request.Form["Password"]);

            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = c:\\users\\admin\\source\\repos\\EmailApp\\EmailApp\\App_Data\\Data.mdf; Integrated Security = True");
            con.Open();

            string CommandText = "SELECT * FROM Users" +
                                " WHERE (Username = '" + u + "' AND Password = '" + p + "')";


            SqlCommand cmd = new SqlCommand(CommandText);
            cmd.Connection = con;

            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read())
            {
                Session["Username"] = u;
                Response.Redirect("Homepage.aspx");
            }
            else
            {
                Response.Redirect("LoginPage.aspx?p=error");
            }
            con.Close();
        }
    }
}