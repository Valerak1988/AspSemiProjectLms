using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CategoryID = Request["CategoryID"] + "";
                if (string.IsNullOrEmpty(CategoryID))
                {
                    CategoryID = "-1";
                }
                BtnDelete.Visible = CategoryID != "-1";
                ImgPnl.Visible = CategoryID != "-1";
                FillData(CategoryID);
            }
        }

        public void FillData(string CategoryID)
        {
            Category Tmp = null;
            if (string.IsNullOrEmpty(CategoryID))
            {
                CategoryID = "-1";
            }
            else
            {
                Tmp = Category.GetById(int.Parse(CategoryID));
                if (Tmp == null)
                {
                    CategoryID = "-1";
                }
            }
            if (Tmp != null)
            {
                TxtCategoryName.Text = Tmp.CategoryName;
                TxtDescription.Text = Tmp.Description;
                CatgoryImg.ImageUrl = "/Uploads/Category/" + Tmp.PicName;
                HidCategoryID.Value = CategoryID;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string Picname = "";
            if (UploadPic.HasFile)
            {
                Picname = GlobFunc.GetRandStr(8);
                string OriginFileName = UploadPic.FileName;
                int index = OriginFileName.LastIndexOf('.');
                string Ext = OriginFileName.Substring(index);
                Picname += Ext;
                string FullPath = Server.MapPath("/Uploads/Client/");
                UploadPic.SaveAs(FullPath + Picname);
            }
            else
            {
                Picname = CatgoryImg.ImageUrl.Substring(CatgoryImg.ImageUrl.LastIndexOf('/') + 1);
            }
            Category Tmp = new Category()
            {
                CategoryID = int.Parse(HidCategoryID.Value),
                CategoryName = TxtCategoryName.Text,
                Description = TxtDescription.Text,
                PicName = Picname,
            };

            Tmp.AddEdit();
            Application["Category"] = Category.GetAll();
            Response.Redirect("CategoryList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int catid = int.Parse(HidCategoryID.Value);
            Category.Delete(catid);
            Application["Category"] = Category.GetAll();
            Response.Redirect("CategoryList.aspx");
        }
    }
}