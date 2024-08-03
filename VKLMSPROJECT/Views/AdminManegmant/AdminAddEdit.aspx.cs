using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class AdminAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string AdminID = Request["AdminID"] + "";
                if (string.IsNullOrEmpty(AdminID))
                {
                    AdminID = "-1";
                }
                FillData(AdminID);
                BtnDelete.Visible = AdminID != "-1";
                PassPnl.Visible = AdminID == "-1";
                ImgPnl.Visible= AdminID != "-1";
            }
        }
        public void FillData(string AdminID)
        {
            Admin Tmp = null;
            if(string.IsNullOrEmpty(AdminID))
            {
                AdminID = "-1";
            }
            else
            {
                Tmp = Admin.GetByID(int.Parse(AdminID));
                if(Tmp == null)
                {
                    AdminID = "-1";
                }
            }
            if(Tmp != null)
            {
                TxtAdminName.Text = Tmp.AdminName;
                TxtAdminLastName.Text = Tmp.AdminLastName;
                TxtEmail.Text = Tmp.Email;
                TxtPassword.Text = Tmp.Password;
                TxtRole.Text = Tmp.Role;
                ProfileImg.ImageUrl = "/Uploads/Admin/" + Tmp.ProfileImg;
                HidAdminID.Value = AdminID;
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
                string FullPath = Server.MapPath("/Uploads/Admin/");
                UploadPic.SaveAs(FullPath + Picname);
            }
            else
            {
                Picname = ProfileImg.ImageUrl.Substring(ProfileImg.ImageUrl.LastIndexOf('/') + 1);
            }
            Admin Tmp = new Admin()
            {
                AdminID = int.Parse(HidAdminID.Value),
                AdminName = TxtAdminName.Text,
                AdminLastName = TxtAdminLastName.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Text,
                Role = TxtRole.Text,
                ProfileImg = Picname,
            };
            Tmp.AddEdit();
            Application["Admin"] = Admin.GetAll();
            Response.Redirect("AdminList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (HidAdminID.Value != "-1")
            {
                int aid = int.Parse(HidAdminID.Value);
                Admin.Delete(aid);
                Application["Admin"] = Admin.GetAll();
                Response.Redirect("AdminList.aspx");
            }
        }
    }
}