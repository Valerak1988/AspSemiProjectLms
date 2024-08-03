using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class ClientAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ClientID = Request["ClientID"] + "";
                if (string.IsNullOrEmpty(ClientID))
                {
                    ClientID = "-1";
                }

                BtnDelete.Visible = ClientID != "-1";
                PassPnl.Visible = ClientID == "-1";
                ImgPnl.Visible = ClientID != "-1";

                FillData(ClientID);
            }
        }
        public void FillData(string ClientID)
        {
            Client Tmp = null;
            if (string.IsNullOrEmpty(ClientID))
            {
                ClientID = "-1";
            }
            else
            {
                Tmp = Client.GetById(int.Parse(ClientID));
                if (Tmp == null)
                {
                    ClientID = "-1";
                }
            }
            HidClientID.Value = ClientID;
            DDLCity.DataSource = City.GetAll();
            DDLCity.DataTextField = "CityName";
            DDLCity.DataValueField = "CityID";
            DDLCity.DataBind();
            DDLCity.Items.Insert(0, "Choose City");

            DDLStatus.DataSource = Status.GetAll();
            DDLStatus.DataTextField = "StatusName";
            DDLStatus.DataValueField = "StatusID";
            DDLStatus.DataBind();
            DDLStatus.Items.Insert(0, "Choose Status");

            if (Tmp != null)
            {
                TxtFirstName.Text = Tmp.FirstName;
                TxtLastName.Text = Tmp.LastName;
                TxtID.Text = Tmp.ID.ToString();
                DDLCity.SelectedValue = Tmp.CityID + "";
                TxtPhone.Text = Tmp.Phone;
                TxtEmail.Text = Tmp.Email;
                TxtPassword.Text = Tmp.Password;
                ProfileImg.ImageUrl = "/Uploads/Client/" + Tmp.ProfileImg;
                TxtDateOfBirth.Text = Tmp.DateOfBirth.ToString("yyyy-MM-dd");
                TxtSubscriptionEndDate.Text = Tmp.SubscriptionEndDate.ToString("yyyy-MM-dd");
                DDLStatus.SelectedValue = Tmp.StatusID + "";
                HidClientID.Value = ClientID;
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
                Picname = ProfileImg.ImageUrl.Substring(ProfileImg.ImageUrl.LastIndexOf('/') + 1);
            }
            Client Tmp = new Client()
            {
                ClientID = int.Parse(HidClientID.Value),
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                ID = int.Parse(TxtID.Text),
                CityID = int.Parse(DDLCity.SelectedValue),
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Text,
                ProfileImg = Picname,
                DateOfBirth = DateTime.Parse(TxtDateOfBirth.Text),
                SubscriptionEndDate = DateTime.Parse(TxtSubscriptionEndDate.Text),
                StatusID = int.Parse(DDLStatus.SelectedValue),
            };
            Tmp.AddEdit();
            Application["Client"] = Client.GetAll();
            Response.Redirect("ClientList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int clientid = int.Parse(HidClientID.Value);
            Client.Delete(clientid);
            Application["Client"] = Client.GetAll();
            Response.Redirect("ClientList.aspx");
        }
    }
}