using BLL;
using System;
using System.Collections.Generic;
using VKLMSPROJECT.Views.AdminManegmant;

namespace VKLMSPROJECT.Views.StartApp
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogIn_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;
            List<Admin> LstAdmin = (List<Admin>)Application["Admin"];
            for (int i = 0; i < LstAdmin.Count; i++)
            {
                if (LstAdmin[i].Email == email && LstAdmin[i].Password == password)
                {
                    Session["AdminSession"] = LstAdmin[i];
                    Response.Redirect("~/Views/AdminManegmant/Default.aspx");
                }
            }
            LtlMsg.Text = "Wrog Email or Password";
        }
    }
}