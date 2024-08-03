using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace VKLMSPROJECT.Views.StartApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAdminName.Text) ||
                string.IsNullOrEmpty(TxtAdminLastName.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) ||
                string.IsNullOrEmpty(TxtPassword.Text))
            {
                LtlMsg.Text = "<div class='alert alert-danger'>All fields are required!</div>";
                return;
            }
            var existingAdmin = Admin.GetAll().FirstOrDefault(a => a.Email.Equals(TxtEmail.Text, StringComparison.OrdinalIgnoreCase));
            if (existingAdmin != null)
            {
                LtlMsg.Text = "<div class='alert alert-danger'>Email already exists!</div>";
                return;
            }

            string Picname = "";
            if (UploadPic.HasFile)
            {
                Picname = GlobFunc.GetRandStr(8);
                string OriginFileName = UploadPic.FileName;
                int index = OriginFileName.LastIndexOf('.');
                string Ext = OriginFileName.Substring(index);
                Picname += Ext;
                string FullPath = Server.MapPath("/Uploads/Admin/");
                UploadPic.SaveAs(FullPath + Picname);
            }
            Admin Tmp = new Admin()
            {
                AdminName = TxtAdminName.Text,
                AdminLastName = TxtAdminLastName.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Text,
                Role = TxtRole.Text,
                ProfileImg = Picname,
            };
            Tmp.AddEdit();
            LtlMsg.Text = "<div class='alert alert-success'>Registration successful!</div>";
            Response.Redirect("LogIn.aspx");
        }
    }
}