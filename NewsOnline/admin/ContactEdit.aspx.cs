using System;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline.admin
{
    public partial class ContactEdit : System.Web.UI.Page
    {
        ContactFac objContact = new ContactFac();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = objContact.Get_Contact_Information();

                txtFirmName.Text = dt.Rows[0]["fldFirmName"].ToString();
                txtAddress.Text = dt.Rows[0]["fldAddress"].ToString();
                txtPostNummer.Text = dt.Rows[0]["fldPostNummer"].ToString();
                txtBy.Text = dt.Rows[0]["fldBy"].ToString();
                txtTelePhone.Text = dt.Rows[0]["fldTelePhone"].ToString();
                txtEmail.Text = dt.Rows[0]["fldEmail"].ToString();
            }

        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            dt = objContact.Get_Contact_Information();

            objContact._firmname = txtFirmName.Text;
            objContact._address = txtAddress.Text;
            objContact._postnummer = txtPostNummer.Text;
            objContact._by = txtBy.Text;
            objContact._telephone = txtTelePhone.Text;
            objContact._email = txtEmail.Text;

            int antalnewsopdateret = objContact.Edit_Contact();

            if (antalnewsopdateret > 0)
            {
                litResult.Text = "<h4>联系信息已经更新!</h4>";
            }
            else
            {
                litResult.Text = "<h4>更新错误!</h4>";
            }
        }
    }
}