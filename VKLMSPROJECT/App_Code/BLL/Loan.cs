using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int ClientID { get; set; }
        public string Email { get; set; }
        public int BookID { get; set; }
        public string Title { get; set; }
        public int MaxLoanDays { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime EstimatedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public static List<Loan> GetAll()
        {
            return LoanDAL.GetAll();
        }
        public static Loan GetById(int id)
        {
            return LoanDAL.GetById(id);
        }
        public int AddEdit()
        {
            MaxLoanDays = Book.GetMaxLoanById(BookID);
            EstimatedReturnDate = LoanDate.AddDays(MaxLoanDays);
            return LoanDAL.AddEdit(this);
        }
        public static int Delete(int id)
        {
            return LoanDAL.Delete(id);
        }

    }
}