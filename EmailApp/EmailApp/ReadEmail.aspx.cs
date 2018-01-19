using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailApp
{
    public partial class ReadEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("<Center><A href ='Homepage.aspx'>" + "Return To Homepage" + "</A></Center>");


            int primary = Int32.Parse(Request.QueryString["id"]);

            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = c:\\users\\admin\\source\\repos\\EmailApp\\EmailApp\\App_Data\\Data.mdf; Integrated Security = True");
            con.Open();

            string CommandText = "SELECT * FROM Emails" +
                                    " WHERE (EmailId = '" + primary + "')";

            SqlCommand cmd = new SqlCommand(CommandText);
            cmd.Connection = con;

            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                String from = data.GetString(1);
                String Subject = data.GetString(3);
                String Body = data.GetString(4);

                Response.Write("<br>");
                Response.Write("<br>");
                Response.Write("<br>");
                Response.Write("<Center>  From : " + from + "</Center>");
                Response.Write("<br>");
                Response.Write("<br>");
                Response.Write("<br>");
                Response.Write("<Center>  Subject : " + Subject + "</Center>");
                Response.Write("<br>");
                Response.Write("<br>");
                Response.Write("<br>");
                Response.Write("<Center>  Body : " + Body + "</Center>");
            }
            con.Close();

            SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = c:\\users\\admin\\source\\repos\\EmailApp\\EmailApp\\App_Data\\Data.mdf; Integrated Security = True");
            con2.Open();
            string CommandText2 = "UPDATE Emails SET Status = 'O' WHERE EmailID = '" + primary + "'";

            SqlCommand cmd2 = new SqlCommand(CommandText2);
            cmd2.Connection = con2;

            cmd2.ExecuteNonQuery();
            con2.Close();

        }



    }
}