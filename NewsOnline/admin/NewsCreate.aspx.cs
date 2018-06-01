using System;
using System.Data;
using System.Web.UI.WebControls;

using NewsOnline.App_Code;

namespace NewsOnline.admin
{
    public partial class NewsCreat : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        NewsTypeFac objNewsType = new NewsTypeFac();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = objNewsType.GetAll_NewsType();

                foreach (DataRow newsType in dt.Rows)
                {
                    ListItem li = new ListItem(newsType["fldType"].ToString(), newsType["fldTypeID"].ToString());
                    ddlNewsType.Items.Add(li);
                }
            }
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string imagename = "foto-paa-vej.jpg";

            if (fuImage.HasFile)
            {
                imagename = PictureSave.SavePicture(fuImage.PostedFile, "Img/News/", 580);
            }

            objNews._image = imagename;
            objNews._title = txtTitle.Text;
            objNews._preview = txtPreview.Text;
            objNews._text = txtText.Text;
            objNews._datetime = DateTime.Now;
            objNews._typeid = Convert.ToInt32(ddlNewsType.SelectedValue);

            int addedsubject = objNews.CreateNews();

            if (addedsubject > 0)
            {
                txtTitle.Text = "";
                txtPreview.Text = "";
                txtText.Text = "";

                litResult.Text = "<h4>新闻已提交!";
            }
            else
            {
                litResult.Text = "<h4>Error!";
            }
        }
    }
}