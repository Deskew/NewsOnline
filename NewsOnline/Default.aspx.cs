using System;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline
{
    public partial class _Default : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = objNews.GetNewestNewsForUser();

                foreach (DataRow nyhed in dt.Rows)
                {
                    litNews.Text += "<div id='forside-nyhed'><img src='Img/News/" + nyhed["fldImage"] 
                        + "'><br /><div id='forside-nyhed-datooverskrift'><p>" + nyhed["fldDateTime"]
                        + "</p><h2><a href='News_Detail.aspx?ID=" + nyhed["fldID"] + "'>" + nyhed["fldTitle"]
                        + "</h2></a></div></div><br />";
                }
            }
        }
    }
}