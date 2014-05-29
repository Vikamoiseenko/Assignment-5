using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
   
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities1 ca = new CommunityAssistEntities1();
                                   
            Person p = new Person();
            p.PersonFirstName = txtFirstName.Text;
            p.PersonLastName = txtLastName.Text;

            ca.People.Add(p);


            Donation d = new Donation();
            d.DonationDate = DateTime.Now;
            d.DonationAmount = decimal.Parse(txtDonationAmount.Text);
            d.Person = p;
            ca.Donations.Add(d);


            PasscodeGenerator pg = new PasscodeGenerator();
            int passcode = pg.GetPasscode();
            PasswordHash ph = new PasswordHash();


            Person c = new Person();
            c.PersonUsername = txtEmail.Text;
            c.Personpasskey = passcode;
            p.PersonPlainPassword = txtConfirm.Text;
            c.PersonUserPassword = ph.Hashit(txtConfirm.Text, passcode.ToString());
            ca.People.Add(c);


            ca.SaveChanges();


            Response.Redirect("Welcome.aspx");
        }
        catch (Exception ex)
        {
            lblResult.Text = ex.Message;
        }



    }
}