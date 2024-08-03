using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using DATA;


namespace DAL
{
    public class LoanDAL
    {
        public static List<Loan> GetAll()
        {
            List<Loan> LoanList = new List<Loan>();
            DbContext db = new DbContext();
            string sql = "SELECT L.*, C.Email, B.Title " +
                         "FROM T_Loan L " +
                         "INNER JOIN T_Client C ON L.ClientID = C.ClientID " +
                         "INNER JOIN T_Book B ON L.BookID = B.BookID";

            DataTable Dt = db.Execute(sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Loan Tmp = new Loan()
                {
                    LoanID = int.Parse(Dt.Rows[i]["LoanID"] + ""),
                    ClientID = int.Parse(Dt.Rows[i]["ClientID"] + ""),
                    Email = Dt.Rows[i]["Email"] + "",
                    BookID = int.Parse(Dt.Rows[i]["BookID"] + ""),
                    Title = Dt.Rows[i]["Title"] + "",
                    LoanDate = DateTime.Parse(Dt.Rows[i]["LoanDate"] + ""),
                    EstimatedReturnDate = DateTime.Parse(Dt.Rows[i]["EstimatedReturnDate"] + ""),
                    ActualReturnDate = DateTime.Parse(Dt.Rows[i]["ActualReturnDate"] + "")
                };
                LoanList.Add(Tmp);
            }
            db.Close();
            return LoanList;
        }

        public static Loan GetById(int id)
        {
            DbContext db = new DbContext();
            string Sql = $"SELECT L.*, C.Email, B.Title " +
                 $"FROM T_Loan L " +
                 $"INNER JOIN T_Client C ON L.ClientID = C.ClientID " +
                 $"INNER JOIN T_Book B ON L.BookID = B.BookID " +
                 $"WHERE L.LoanID = {id}";
            DataTable Dt = db.Execute(Sql);
            Loan Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Loan()
                {
                    LoanID = int.Parse(Dt.Rows[0]["LoanID"] + ""),
                    ClientID = int.Parse(Dt.Rows[0]["ClientID"] + ""),
                    Email = Dt.Rows[0]["Email"] + "",
                    BookID = int.Parse(Dt.Rows[0]["BookID"] + ""),
                    Title = Dt.Rows[0]["Title"] + "",
                    LoanDate = DateTime.Parse(Dt.Rows[0]["LoanDate"] + ""),
                    EstimatedReturnDate = DateTime.Parse(Dt.Rows[0]["EstimatedReturnDate"] + ""),
                    ActualReturnDate = DateTime.Parse(Dt.Rows[0]["ActualReturnDate"] + "")
                };
            }
            db.Close();
            return Tmp;
        }

        public static int AddEdit(Loan Tmp)
        {
            int RecCount = 0;
            DbContext db = new DbContext();
            string Sql = "";
            if (Tmp.LoanID == -1)
            {
                Sql = $"INSERT INTO T_Loan (ClientID, BookID, LoanDate, EstimatedReturnDate, ActualReturnDate) " +
                      $"VALUES ({Tmp.ClientID}, {Tmp.BookID}, '{Tmp.LoanDate:yyyy-MM-dd}', '{Tmp.EstimatedReturnDate:yyyy-MM-dd}', '{Tmp.ActualReturnDate:yyyy-MM-dd}')";
            }
            else
            {
                Sql = $"UPDATE T_Loan SET " +
                      $"ClientID = {Tmp.ClientID}, " +
                      $"BookID = {Tmp.BookID}, " +
                      $"LoanDate = '{Tmp.LoanDate:yyyy-MM-dd}', " +
                      $"EstimatedReturnDate = '{Tmp.EstimatedReturnDate:yyyy-MM-dd}', " +
                      $"ActualReturnDate = '{Tmp.ActualReturnDate:yyyy-MM-dd}' " +
                      $"WHERE LoanID = {Tmp.LoanID}";
            }
            RecCount = db.ExecuteNonQuery(Sql);
            if (Tmp.LoanID == -1)
            {
                Tmp.LoanID = db.GetMaxId("T_Loan", "LoanID");
            }
            db.Close();
            return RecCount;
        }

        public static int Delete(int id)
        {
            DbContext db = new DbContext();
            string Sql = $"DELETE FROM T_Loan WHERE LoanID={id}";
            int RecCount = db.ExecuteNonQuery(Sql);
            db.Close();
            return RecCount;
        }
    }
}