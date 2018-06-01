using System;
using System.Data;
using System.Web.UI.WebControls;

using NewsOnline.App_Code;

namespace NewsOnline.admin
{
    public partial class NewsEdit : System.Web.UI.Page
    {
        NewsFac objNews = new NewsFac();
        NewsTypeFac objNewsType = new NewsTypeFac();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ret"]))
                {
                    dt = objNewsType.GetAll_NewsType();

                    foreach (DataRow newsType in dt.Rows)
                    {
                        ListItem li = new ListItem(newsType["fldType"].ToString(), newsType["fldTypeID"].ToString());
                        ddlNewsType.Items.Add(li);
                    }
                    objNews._id = Convert.ToInt32(Request.QueryString["ret"]);

                    dt = objNews.GetNewsByfldID();

                    if (!IsPostBack)
                    {
                        ShowSubject();

                    }

                    txtTitle.Text = dt.Rows[0]["fldTitle"].ToString();
                    txtPreview.Text = dt.Rows[0]["fldPreview"].ToString();
                    txtText.Text = dt.Rows[0]["fldText"].ToString();
                    ddlNewsType.SelectedValue = dt.Rows[0]["fldTypeID_fk"].ToString();

                }
                else
                {
                    Response.Redirect("NewsEditDelete.aspx");
                }
            }
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            objNews._id = Convert.ToInt32(Request.QueryString["ret"]);
            dt = objNews.GetNewsByfldID();

            string imagename;


            if ((chbImg.Checked || fuImage.HasFile) && !string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
            {
                IOFunctions.DeleteFile(Server.MapPath("../Img/News/") + dt.Rows[0]["fldImage"]);
                imagename = ""; // 图像名称在数据库中将默认删除
            }

            else
            {
                imagename = dt.Rows[0]["fldImage"].ToString();
            }

            if (fuImage.HasFile)
            {
                imagename = PictureSave.SavePicture(fuImage.PostedFile, "Img/News/", 580);
            }
            objNews._image = imagename;
            objNews._title = txtTitle.Text;
            objNews._text = txtText.Text;
            objNews._preview = txtPreview.Text;
            objNews._typeid = Convert.ToInt32(ddlNewsType.SelectedValue);

            int antalnewsopdateret = objNews.EditNews();

            if (antalnewsopdateret > 0)
            {
                litResult.Text = "<h4>这条新闻已经更新!</h4>";
            }
            else
            {
                litResult.Text = "<h4>更新错误!</h4>";
            }
        }

        protected void ShowSubject()
        {
            if (!string.IsNullOrEmpty(dt.Rows[0]["fldImage"].ToString()))
            {
                imgImage.ImageUrl = "../Img/News/" + dt.Rows[0]["fldImage"].ToString();
                imgImage.Visible = true; // 图像框可见
                chbImg.Visible = true; // 勾选删除图像
            }
            else
            {
                // 如果数据库中没有图像...
                imgImage.Visible = false; // 图像框不可见
                chbImg.Visible = false; // 勾选框不可见
            }
        }

    }
}