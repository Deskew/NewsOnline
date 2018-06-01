using System;
using System.Linq;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline
{
    public partial class Login : System.Web.UI.Page
    {
        UserFac objBruger = new UserFac();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            objBruger._user = txtUsername.Text;
            objBruger._password = txtPassword.Text;
            dt = objBruger.UserLogin();

            if (dt.Rows.Count > 0)
            {
                Session["login"] = dt.Rows[0]["fldUserName"].ToString();
                Response.Redirect("admin/Default.aspx");
            }
            else
            {
                litResult.Text = "用户名或密码错误，请重试!";
            }
        }
    }
}