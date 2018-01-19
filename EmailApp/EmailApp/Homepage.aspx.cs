using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace EmailApp
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] != null)
            {
                Response.Write("<A href = 'CreateEmail.aspx'>" +" Compose An Email " +"</A>");
                Response.Write("<br>");
                Response.Write("<br>");

                Response.Write("Welcome To Emails R US " + Session["Username"]);

                String u = (String)Session["Username"];

                SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = c:\\users\\admin\\source\\repos\\EmailApp\\EmailApp\\App_Data\\Data.mdf; Integrated Security = True");
                con.Open();

                string CommandText = "SELECT * FROM Emails" +
                                    " WHERE (To_ = '" + u + "')";


                SqlCommand cmd = new SqlCommand(CommandText);
                cmd.Connection = con;

                SqlDataReader data = cmd.ExecuteReader();

                Response.Write("<Table style=font-size:medium;background-color:#808080;border:mediumgroove#000000> <tr> <td class =auto-style1> OPEN STATUS <td class =auto-style1> FROM <td class =autostyle1> SUBJECT <td class =autoStyle1> BODY </td></td></td></td></tr>");

                while (data.Read())
                {
                    int pk = data.GetInt32(0);
                    String from = data.GetString(1);
                    String Subject = data.GetString(3);
                    String Body = data.GetString(4).Substring(0, 20);
                    String image = data.GetString(5);
            
                    if (image == "N")
                    {
                        Response.Write("<tr> <td>" + "<img src =\\Pictures\\New.jpg alt = Sample Photo width=100px height=100px/>" + "<td>" + from + "<td>" + "<A href ='ReadEmail.aspx?id=" + pk + "'>" + Subject + "</A>" + "<td>" + "<A href ='ReadEmail.aspx?id=" + pk + "'>" + Body + "</A>" + "</td> </td> </td> </td> </tr>");
                    }

                    else
                    {
                        Response.Write("<tr> <td>" + "<img src =\\Pictures\\Old.jpg alt = Sample Photo width=100px height=100px/>" + "<td>" + from + "<td>" + "<A href ='ReadEmail.aspx?id=" + pk + "'>" + Subject + "</A>" + "<td>" + "<A href ='ReadEmail.aspx?id=" + pk + "'>" + Body + "</A>" + "</td> </td> </td> </td> </tr>");
                    }
                }

                Response.Write("</Table>");
            }


            



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Loginpage.aspx");
            Session.Abandon();
        }
    }
}