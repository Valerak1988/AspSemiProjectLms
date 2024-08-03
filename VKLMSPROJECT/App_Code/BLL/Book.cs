using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string PicName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ISBN { get; set; }
        public int Quantity { get; set; }
        public int CopiesInStock { get; set; }
        public int MaxLoanDays { get; set; }
        public DateTime AddDate { get; set; }

        public static List<Book> GetAll()
        {
            return BookDAL.GetAll();
        }
        public static Book GetById(int id)
        {
            return BookDAL.GetById(id);
        }
        public int AddEdit()
        {
            return BookDAL.AddEdit(this);
        }
        public static int Delete(int id)
        {
            return BookDAL.Delete(id);
        }
        public static int GetMaxLoanById(int id)
        {
            return BookDAL.GetMaxLoanById(id);
        }
    }
}