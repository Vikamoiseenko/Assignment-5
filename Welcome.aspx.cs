using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (Session["personKey"] != null)
        {
            GetCustomerInfo();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }


    private void GetCustomerInfo()
    {
       CommunityAssistEntities1 ca = new CommunityAssistEntities1();
        int pk = (int)Session["personKey"];
        var person = from c in ca.People
                       where c.PersonKey == pk
                       select new
                       {
                           c.PersonLastName,
                           c.PersonFirstName,
                           
                       };


        GridView2.DataSource = person.ToList();
        GridView2.DataBind();
    }
        
}