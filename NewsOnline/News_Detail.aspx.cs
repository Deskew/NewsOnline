using System;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline
{
    public partial class News_Detail : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"])) // IF ID EXIST THEN CONTINUE THE CODE - ELSE GO TO DEFAULT WEBPAGE
                {
                    objNews._id = Convert.ToInt32(Request.QueryString["ID"]);

                    dt = objNews.GetNewsByfldID();

                    foreach (DataRow nyhed in dt.Rows)
                    {
                        litNews.Text += "<div id='ind-nyhed'>";
                        litNews.Text += "<p class='ind-nyhed-img'><img src='Img/Nyheder/" + nyhed["fldImage"] + "'></p>";
                        litNews.Text += "<div id='ind-nyhed-style'>";
                        litNews.Text += "<p class='ind-nyhed-overskrift'>" + nyhed["fldTitle"] + "</p>";
                        litNews.Text += "<p class='ind-nyhed-dato'>" + nyhed["fldDateTime"] + "</p>";
                        litNews.Text += "<p class='ind-nyhed-tekst'>" + nyhed["fldText"] + "</p>";
                        litNews.Text += "</div>";
                        litNews.Text += "</div>";
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }

        }
    }
}