﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class StatusList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillData();
            }
        }
        public void FillData()
        {
            RptStatus.DataSource = Status.GetAll();
            RptStatus.DataBind();
        }
    }
}