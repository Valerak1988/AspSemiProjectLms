using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VKLMSPROJECT.Views.AdminManegmant
{
    public partial class LoanAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string LoanID = Request["LoanID"] + "";
                FillData(LoanID);
                BtnDelete.Visible = LoanID != "-1";
            }
        }
        public void FillData(string LoanID)
        {
            Loan Tmp = null;
            if (string.IsNullOrEmpty(LoanID))
            {
                LoanID = "-1";
            }
            else
            {
                Tmp = Loan.GetById(int.Parse(LoanID));
                if (Tmp == null)
                {
                    LoanID = "-1";
                }
                else
                {
                    Book selectedBook = Book.GetById(Tmp.BookID);
                    if (selectedBook != null)
                    {
                        HidBookID.Value = selectedBook.BookID.ToString();                        
                    }
                }
            }
            HidLoanID.Value = LoanID;

            List<Client> clients = Client.GetAll();
            DDLClientID.DataSource = clients;
            DDLClientID.DataTextField = "ClientID";
            DDLClientID.DataValueField = "ClientID";
            DDLClientID.DataBind();
            DDLClientID.Items.Insert(0, new ListItem("Choose Client ID", ""));

            DDLEmail.DataSource = clients;
            DDLEmail.DataTextField = "Email";
            DDLEmail.DataValueField = "ClientID";
            DDLEmail.DataBind();
            DDLEmail.Items.Insert(0, new ListItem("Choose Client Email", ""));

            List<Book> books = Book.GetAll();
            DDLBookID.DataSource = books;
            DDLBookID.DataTextField = "BookID";
            DDLBookID.DataValueField = "BookID";
            DDLBookID.DataBind();
            DDLBookID.Items.Insert(0, new ListItem("Choose Book ID", ""));

            DDLBookName.DataSource = books;
            DDLBookName.DataTextField = "Title";
            DDLBookName.DataValueField = "BookID";
            DDLBookName.DataBind();
            DDLBookName.Items.Insert(0, new ListItem("Choose Book Title", ""));

            if (Tmp != null)
            {
                DDLClientID.SelectedValue = Tmp.ClientID.ToString();
                DDLEmail.SelectedValue = Tmp.ClientID.ToString();
                DDLBookID.SelectedValue = Tmp.BookID.ToString();
                DDLBookName.SelectedValue = Tmp.BookID.ToString();
                TxtLoanDate.Text = Tmp.LoanDate.ToString("yyyy-MM-dd");
                TxtActualReturnDate.Text = Tmp.ActualReturnDate.HasValue ? Tmp.ActualReturnDate.Value.ToString("yyyy-MM-dd") : "";
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime? actualReturnDate = null;
            if (!string.IsNullOrWhiteSpace(TxtActualReturnDate.Text))
            {
                actualReturnDate = DateTime.Parse(TxtActualReturnDate.Text);
            }
            Loan Tmp = new Loan()
            {
                LoanID = int.Parse(HidLoanID.Value),
                ClientID = int.Parse(DDLClientID.SelectedValue),
                Email = DDLEmail.SelectedItem.Text,
                BookID = int.Parse(DDLBookID.SelectedValue),
                Title = DDLBookName.SelectedItem.Text,
                LoanDate = DateTime.Parse(TxtLoanDate.Text),
                ActualReturnDate = actualReturnDate
            };

            Tmp.AddEdit();
            Application["Loan"] = Loan.GetAll();
            Response.Redirect("LoanList.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int loanid = int.Parse(HidLoanID.Value);
            Loan.Delete(loanid);
            Application["Loan"] = Loan.GetAll();
            Response.Redirect("LoanList.aspx");
        }
    }
}