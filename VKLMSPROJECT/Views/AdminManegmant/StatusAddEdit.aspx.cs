using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class StatusAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string StatusID = Request["StatusID"] + "";
                if (string.IsNullOrEmpty(StatusID))
                {
                    StatusID = "-1";
                }
                BtnDelete.Visible = StatusID != "-1";
                ImgPnl.Visible = StatusID != "-1";
                FillData(StatusID);
            }
        }
        public void FillData(string StatusID)
        {
            Status Tmp = null;
            if (string.IsNullOrEmpty(StatusID))
            {
                StatusID = "-1";
            }
            else
            {
                Tmp = Status.GetById(int.Parse(StatusID));
                if (Tmp == null)
                {
                    StatusID = "-1";
                }
            }
            if(Tmp != null)
            {
                TxtStatusName.Text = Tmp.StatusName;
                TxtStatusDescription.Text = Tmp.StatusDescription;
                StatusImg.ImageUrl = "/Uploads/Status/" + Tmp.StatusImg;
                HidStatusID.Value = StatusID;
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
                Picname = StatusImg.ImageUrl.Substring(StatusImg.ImageUrl.LastIndexOf('/') + 1);
            }
            Status Tmp = new Status()
            {
                StatusID = int.Parse(HidStatusID.Value),
                StatusName = TxtStatusName.Text,
                StatusDescription = TxtStatusDescription.Text,
                StatusImg = Picname,
            };
            Tmp.AddEdit();
            Application["Status"] = Status.GetAll();
            Response.Redirect("StatusList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int statid = int.Parse(HidStatusID.Value);
            Status.Delete(statid);
            Application["Status"] = Status.GetAll();
            Response.Redirect("StatusList.aspx");
        }
    }
}