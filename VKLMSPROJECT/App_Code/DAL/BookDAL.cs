using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using DATA;


namespace DAL
{
    public class BookDAL
    {
        public static List<Book> GetAll()
        {
            List<Book> BookList = new List<Book>();
            DbContext db = new DbContext();
            string sql = "SELECT T_Book.*, T_Category.CategoryName FROM T_Book " +
                         "INNER JOIN T_Category ON T_Book.CategoryID = T_Category.CategoryID";
            DataTable Dt = db.Execute(sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Book Tmp = new Book()
                {
                    BookID = int.Parse(Dt.Rows[i]["BookID"] + ""),
                    Title = Dt.Rows[i]["Title"] + "",
                    Author = Dt.Rows[i]["Author"] + "",
                    Description = Dt.Rows[i]["Description"] + "",
                    PicName = Dt.Rows[i]["PicName"] + "",
                    CategoryID = int.Parse(Dt.Rows[i]["CategoryID"] + ""),
                    CategoryName = Dt.Rows[i]["CategoryName"] + "",
                    ISBN = Dt.Rows[i]["ISBN"] + "",
                    Quantity = int.Parse(Dt.Rows[i]["Quantity"] + ""),
                    CopiesInStock = int.Parse(Dt.Rows[i]["CopiesInStock"] + ""),
                    MaxLoanDays = int.Parse(Dt.Rows[i]["MaxLoanDays"] + ""),
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"] + "")
                };
                BookList.Add(Tmp);
            }
            db.Close();
            return BookList;
        }

        public static Book GetById(int id)
        {
            DbContext db = new DbContext();
            string Sql = $"SELECT T_Book.*, T_Category.CategoryName FROM T_Book " +
                         $"INNER JOIN T_Category ON T_Book.CategoryID = T_Category.CategoryID " +
                         $"WHERE T_Book.BookID = {id}";
            DataTable Dt = db.Execute(Sql);
            Book Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Book()
                {
                    BookID = int.Parse(Dt.Rows[0]["BookID"] + ""),
                    Title = Dt.Rows[0]["Title"] + "",
                    Author = Dt.Rows[0]["Author"] + "",
                    Description = Dt.Rows[0]["Description"] + "",
                    PicName = Dt.Rows[0]["PicName"] + "",
                    CategoryID = int.Parse(Dt.Rows[0]["CategoryID"] + ""),
                    CategoryName = Dt.Rows[0]["CategoryName"] + "",
                    ISBN = Dt.Rows[0]["ISBN"] + "",
                    Quantity = int.Parse(Dt.Rows[0]["Quantity"] + ""),
                    CopiesInStock = int.Parse(Dt.Rows[0]["CopiesInStock"] + ""),
                    MaxLoanDays = int.Parse(Dt.Rows[0]["MaxLoanDays"] + ""),
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            db.Close();
            return Tmp;
        }

        public static int AddEdit(Book Tmp)
        {
            int RecCount = 0;
            DbContext db = new DbContext();
            string Sql = "";
            if (Tmp.BookID == -1)
            {
                Sql = "INSERT INTO T_Book (Title, Author, Description, PicName, CategoryID, ISBN, Quantity, CopiesInStock, MaxLoanDays) VALUES";
                Sql += $"(N'{Tmp.Title}', N'{Tmp.Author}', N'{Tmp.Description}', '{Tmp.PicName}', {Tmp.CategoryID}, '{Tmp.ISBN}', {Tmp.Quantity}, {Tmp.CopiesInStock}, {Tmp.MaxLoanDays})";
            }
            else
            {
                Sql = "UPDATE T_Book SET ";
                Sql += $"Title = N'{Tmp.Title}',";
                Sql += $"Author = N'{Tmp.Author}',";
                Sql += $"Description = N'{Tmp.Description}',";
                Sql += $"PicName = '{Tmp.PicName}',";
                Sql += $"CategoryID = {Tmp.CategoryID},";
                Sql += $"ISBN = '{Tmp.ISBN}',";
                Sql += $"Quantity = {Tmp.Quantity},";
                Sql += $"CopiesInStock = {Tmp.CopiesInStock},";
                Sql += $"MaxLoanDays = {Tmp.MaxLoanDays} ";
                Sql += $"WHERE BookID = {Tmp.BookID}";
            }
            RecCount = db.ExecuteNonQuery(Sql);
            if (Tmp.BookID == -1)
            {
                Tmp.BookID = db.GetMaxId("T_Book", "BookID");
            }
            db.Close();
            return RecCount;
        }

        public static int Delete(int id)
        {
            Book Tmp = null;
            DbContext db = new DbContext();
            string Sql = $"DELETE FROM T_Book WHERE BookID={id}";
            int RecCount = 0;
            RecCount = db.ExecuteNonQuery(Sql);
            return RecCount;
        }
        public static int GetMaxLoanById(int BookID)
        {
            int maxLoan = 0;
            DbContext db = new DbContext();
            string sql = $"SELECT MaxLoanDays FROM T_Book WHERE BookID = {BookID}";
            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0)
            {
                maxLoan = int.Parse(dt.Rows[0]["MaxLoanDays"].ToString());
            }
            db.Close();
            return maxLoan;
        }
    }
}