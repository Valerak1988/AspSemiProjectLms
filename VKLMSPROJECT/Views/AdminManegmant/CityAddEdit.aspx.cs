using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class CityAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CityID = Request["CityID"] + "";
                if (string.IsNullOrEmpty(CityID))
                {
                    CityID = "-1";
                }
                BtnDelete.Visible = CityID != "-1";
                FillData(CityID);
            }
        }
        public void FillData(string CityID)
        {
            City Tmp = new City();
            if (string.IsNullOrEmpty(CityID))
            {
                CityID = "-1";
            }
            else
            {
                Tmp = City.GetByID(int.Parse(CityID));
                if (Tmp == null)
                {
                    CityID = "-1";
                }
            }
            if (Tmp != null)
            {
                TxtCityName.Text = Tmp.CityName;
                HidCityID.Value = CityID;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            City Tmp = new City()
            {
                CityID = int.Parse(HidCityID.Value),
                CityName = TxtCityName.Text,
            };
            Tmp.AddEdit();
            Application["City"] = City.GetAll();
            Response.Redirect("CityList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (HidCityID.Value != "-1")
            {
                int CityID = int.Parse(HidCityID.Value);
                City.Delete(CityID);
                Application["City"] = City.GetAll();
                Response.Redirect("CityList.aspx");
            }
        }
    }
}