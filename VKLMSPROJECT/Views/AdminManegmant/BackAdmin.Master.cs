using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class BackAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminSession"] == null)
            {
                Response.Redirect("~/Views/StartApp/LogIn.aspx");
            }
            else
            {
                var admin = (Admin)Session["AdminSession"];
                LblUserName.Text = $"{admin.AdminName} {admin.AdminLastName}";
                ImgUserProfile.ImageUrl = $"~/Uploads/Admin/{admin.ProfileImg}"; 
            }
        }
    }
}