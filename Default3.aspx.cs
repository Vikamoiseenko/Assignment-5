using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities1 ca = new CommunityAssistEntities1();
            ServiceGrant sg = new ServiceGrant();
            int pk = (int)Session["personKey"];
            sg.ServiceKey = int.Parse(ddlGrantType.SelectedValue.ToString());
            sg.GrantAmount = Decimal.Parse(txtGrantAmount.Text);
            sg.GrantDate = DateTime.Now;
            sg.GrantNeedExplanation = txtExplanation.Text;
            sg.EmployeeKey = 1;
            sg.PersonKey = pk;
            ca.ServiceGrants.Add(sg);


            ca.SaveChanges();


            Response.Redirect("Default6.aspx");
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
}