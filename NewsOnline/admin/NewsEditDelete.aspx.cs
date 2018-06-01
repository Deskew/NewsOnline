using System;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline.admin
{
    public partial class NewsEditDelete : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = objNews.GetAllNews();
            foreach (DataRow news in dt.Rows)
            {
                litResult.Text += "<div id='ret-slet'><a target='_blank' href='../News_Detail.aspx?ID=" 
                    + news["fldID"] + "'>" + news["fldDateTime"] + " - " 
                    + news["fldTitle"] + "<p> </p></a>";
                litResult.Text += "<div id='ret'><a href='NewsEdit.aspx?ret=" 
                    + news["fldID"] + "'> <i class='fa fa-pencil fa-2x'></i></a></div>";
                litResult.Text += "<div id='slet'><a href='NewsEditDelete.aspx?sletid=" 
                    + news["fldID"] 
                    + "' onclick='return confirm (\"您确定要删除此条新闻吗？?\")'> <i class='fa fa-trash fa-2x'></i></a></br /></div></div><div class='line'></div>";
            }
            if (!string.IsNullOrEmpty(Request.QueryString["sletid"]))
            {
                deleteNews();
            }
        }
        protected void deleteNews()
        {
            objNews._id = Convert.ToInt32(Request.QueryString["sletid"]);
            objNews.DeleteNews(); // from SQL FAC
            Response.Redirect("NewsEditDelete.aspx");
        }

    }
}