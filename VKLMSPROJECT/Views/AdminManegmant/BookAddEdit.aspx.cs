using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class BookAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string BookID = Request["BookID"] + "";
                if (string.IsNullOrEmpty(BookID))
                {
                    BookID = "-1";
                }
                BtnDelete.Visible = BookID != "-1";
                ImgPnl.Visible = BookID != "-1";
                FillData(BookID);
            }
        }
        public void FillData(string BookID)
        {
            Book Tmp = null;
            if (string.IsNullOrEmpty(BookID))
            {
                BookID = "-1";
            }
            else
            {
                Tmp = Book.GetById(int.Parse(BookID));
                if (Tmp == null)
                {
                    BookID = "-1";
                }
            }
            HidBookID.Value = BookID;
            DDLCategory.DataSource = Category.GetAll();
            DDLCategory.DataTextField = "CategoryName";
            DDLCategory.DataValueField = "CategoryID";
            DDLCategory.DataBind();
            DDLCategory.Items.Insert(0, "Choose Category");

            if (Tmp != null)
            {
                TxtTitle.Text = Tmp.Title;
                TxtAuthor.Text = Tmp.Author;                
                TxtDescription.Text = Tmp.Description;
                CoverImg.ImageUrl = "/Uploads/Book/" + Tmp.PicName;
                DDLCategory.SelectedValue = Tmp.CategoryID + "";
                TxtISBN.Text = Tmp.ISBN;
                TxtQuantity.Text = Tmp.Quantity + "";
                TxtCopiesInStock.Text = Tmp.CopiesInStock + "";
                TxtMaxLoanDays.Text = Tmp.MaxLoanDays + "";
                HidBookID.Value = BookID;
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
                string FullPath = Server.MapPath("/Uploads/Book/");
                UploadPic.SaveAs(FullPath + Picname);
            }
            else
            {
                Picname = CoverImg.ImageUrl.Substring(CoverImg.ImageUrl.LastIndexOf('/') + 1);
            }
            Book Tmp = new Book()
            {
                BookID = int.Parse(HidBookID.Value),
                Title = TxtTitle.Text,
                Author = TxtAuthor.Text,
                Description = TxtDescription.Text,
                PicName = Picname,
                CategoryID = int.Parse(DDLCategory.SelectedValue),
                ISBN = TxtISBN.Text,
                Quantity = int.Parse(TxtQuantity.Text),
                CopiesInStock = int.Parse(TxtCopiesInStock.Text),
                MaxLoanDays = int.Parse(TxtMaxLoanDays.Text),
            };

            Tmp.AddEdit();
            Application["Book"] = Book.GetAll();
            Response.Redirect("BookList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int bookid = int.Parse(HidBookID.Value);
            Book.Delete(bookid);
            Application["Book"] = Book.GetAll();
            Response.Redirect("BookList.aspx");
        }
    }
}