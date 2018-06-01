using System;
using System.Web.UI.WebControls;
using System.Data;

using NewsOnline.App_Code;

namespace NewsOnline
{
    public partial class News_Type1 : System.Web.UI.Page
    {
        //ProduktFac objProdukt = new ProduktFac();
        NewsTypeFac objNewsType = new NewsTypeFac();
        NewsFac objNews = new NewsFac();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Getting all kategories from database
                dt = objNewsType.GetAll_NewsType();

                // Inserting them into DropDownList
                foreach (DataRow newsType in dt.Rows)
                {
                    ListItem li = new ListItem(newsType["fldType"].ToString(), newsType["fldTypeID"].ToString());
                    ddlNewsType.Items.Add(li);
                }
            }

        }
        protected void ddlNewsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            litResult.Text = "";             // Emptying the literal (AutoPostBack)
            int _id = Convert.ToInt32(ddlNewsType.SelectedValue); // Making DropDownList into INT(_id)
            dt = objNews.GetNewestNewsByTypeID(_id);    // Getting "_id" from Method in Fac

            foreach (DataRow news in dt.Rows)
            {
                litResult.Text += "<div id='vidstedu'><a href='News_Detail.aspx?ID="
                    + news["fldID"] + "'><p>" 
                    + news["fldTitle"] 
                    + "</p></a></div>";      // Posting selected DropDown item content
            }
        }
    }
}