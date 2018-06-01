using System;
using System.Data;

using NewsOnline.App_Code;


namespace NewsOnline.admin
{
    public partial class Default : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = objNews.GetNewestNewsForAdmin();

                foreach (DataRow news in dt.Rows)
                {
                    litNews.Text += "<div id='forside-news'><img src='../Img/News/" + news["fldImage"] 
                        + "'><br /><div id='forside-news-datooverskrift'><p>" + news["fldDateTime"] 
                        + "</p><h2><a target='_blank' href='../News_Detail.aspx?ID=" + news["fldID"] 
                        + "'>" + news["fldTitle"] + "</h2></a></div></div><br />";
                }
            }
        }
    }
}