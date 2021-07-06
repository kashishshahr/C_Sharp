using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session[int]
            //Session[string]
            //Session["Session1"] = "Session 1 data";
            //Session["Session2"] = "Session 2 data";
            //Response.Write("Session 1 Data =" + Session["Session1"]);
            //Response.Write("<br/>");
            //Response.Write("Session 1 Data =" + Session[0]);
            //Response.Write("<br/>");
            //Response.Write("Session 1 Data =" + Session[0].ToString());
            //Response.Write("<br/>");
            //Response.Write("Session 2 Data =" + Session["Session2"]);
            //Response.Write("<br/>");
            //Response.Write("Session 2 Data =" + Session[1]);
            //Response.Write("<br/>");
            //Response.Write("Session 2 Data =" + Session[1].ToString());
            //Response.Write("<br/>");

            Company company = new Company();
            Response.Write("Name of Employee With Id=2: "+company[2]+"<br/>");
            Response.Write("Changing Name of Employee With Id=2: "+company[2]+"<br/>");
            company[2] = "Pamila";
            Response.Write("Changing Name of Employee With Id=2: " + company[2] + "<br/>");
            //company["Pamila"] = "Pam";
            Response.Write("Name o f Employee With Id=2: "+company[2]+"<br/>");

            Response.Write("Total Male in Company:" + company["Male"]);
            company["Male"] = "Female";
            Response.Write("Total Male in Company:" + company["Male"]);
        }
    }
}