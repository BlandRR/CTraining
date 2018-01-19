using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailApp
{
    public partial class SendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String to = (Request.Form["TO"]);
            String sub = (Request.Form["SUBJECT"]);
            String bod = (Request.Form["BODY"]);
            String N = "N";
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = c:\\users\\admin\\source\\repos\\EmailApp\\EmailApp\\App_Data\\Data.mdf; Integrated Security = True");
            con.Open();
            string CommandText = "INSERT INTO Emails (From_, To_, Subject, Body, Status, Deleted) VALUES ('" + Session["Username"] + "', '" + to + "', '" + sub + "', '" + bod + "', '"+N+ "', '" + N + "')";
            SqlCommand cmd = new SqlCommand(CommandText);
            cmd.Connection = con;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                Response.Redirect("CreateEmail.aspx");
            }

            
            con.Close();
            Response.Redirect("Homepage.aspx");
        }
    }
}