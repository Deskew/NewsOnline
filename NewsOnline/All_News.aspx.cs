using System;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline
{
    public partial class All_News : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = objNews.GetAllNews();

                foreach (DataRow news in dt.Rows)
                {
                    litNews.Text += "<div id='nyhed-box'>";
                    litNews.Text += "<div id='nyhed-overskrift-teaser'>";
                    litNews.Text += "<h3>" + news["fldTitle"] + "</h3>";
                    litNews.Text += "<br /><p>" + news["fldPreview"] + "</p>";
                    litNews.Text += "<br /><div id='lasmere'>";
                    litNews.Text += "<a href='News_Detail.aspx?ID=" + news["fldID"] + "'><p>查看更多</p></a>";
                    litNews.Text += "</div>";
                    litNews.Text += "</div>";
                    litNews.Text += "<div id='nyhed-imagedate'>";
                    litNews.Text += "<img style='width: 80%' src='Img/News/" + news["fldImage"] + "'>";
                    litNews.Text += "<p>" + news["fldDateTime"] + "</p>";
                    litNews.Text += "</div>";
                    litNews.Text += "</div>";
                    litNews.Text += "<br />";

                }
            }

        }
    }
}