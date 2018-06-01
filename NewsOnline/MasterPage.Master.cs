using System;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        ContactFac objContact = new ContactFac();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = objContact.Get_Contact_Information();

                foreach (DataRow kontakt in dt.Rows)
                {
                    litKontakt.Text += "<p class='plaintext'>" + kontakt["fldFirmName"] + "</p>";
                    litKontakt.Text += "<p class='plaintext'>" + kontakt["fldAddress"] + "</p>";
                    litKontakt.Text += "<p class='plaintext'>" + kontakt["fldPostNummer"] + "</p>";
                    litKontakt.Text += "<p class='plaintext'>" + kontakt["fldBy"] + "</p>";
                    litKontakt.Text += "<p class='plaintext'>" + kontakt["fldTelePhone"] + "</p>";
                    litKontakt.Text += "<p class='plaintext'><a href='mailto:newssite@newssite'>" + kontakt["fldEmail"] + "</p></a>";

                }
            }
        }
    }
}