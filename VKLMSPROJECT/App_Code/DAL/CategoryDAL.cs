using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using DATA;


namespace DAL
{
    public class CategoryDAL
    {
        public static List<Category> GetAll()
        {
            List<Category> CategoryList = new List<Category>();
            DbContext db = new DbContext();
            string sql = "SELECT * FROM T_Category";
            DataTable Dt = db.Execute(sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Category Tmp = new Category()
                {
                    CategoryID = int.Parse(Dt.Rows[i]["CategoryID"] + ""),
                    CategoryName = Dt.Rows[i]["CategoryName"] + "",
                    Description = Dt.Rows[i]["Description"] + "",
                    PicName = Dt.Rows[i]["PicName"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"] + "")
                };
                CategoryList.Add(Tmp);
            }
            db.Close();
            return CategoryList;
        }
        public static Category GetById(int id)
        {
            DbContext db = new DbContext();
            string Sql = $"Select * FROM T_Category WHERE CategoryID={id}";
            DataTable Dt = db.Execute(Sql);
            Category Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Category()
                {
                    CategoryID = int.Parse(Dt.Rows[0]["CategoryID"] + ""),
                    CategoryName = Dt.Rows[0]["CategoryName"] + "",
                    Description = Dt.Rows[0]["Description"] + "",
                    PicName = Dt.Rows[0]["PicName"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            db.Close();
            return Tmp;
        }
        public static int AddEdit(Category Tmp)
        {
            int RecCount = 0;
            DbContext db = new DbContext();
            string Sql = "";
            if (Tmp.CategoryID == -1)
            {
                Sql = "INSERT INTO T_Category (CategoryName, Description, PicName) VALUES ";
                Sql += $"(N'{Tmp.CategoryName}', N'{Tmp.Description}', N'{Tmp.PicName}')";
            }
            else
            {
                Sql = "UPDATE T_Category SET ";
                Sql += $"CategoryName= N'{Tmp.CategoryName}',";
                Sql += $"Description= N'{Tmp.Description}',";
                Sql += $"PicName= N'{Tmp.PicName}'";
                Sql += $"WHERE CategoryID ={Tmp.CategoryID}";
            }
            RecCount = db.ExecuteNonQuery(Sql);
            if (Tmp.CategoryID == -1)
            {
                Tmp.CategoryID = db.GetMaxId("T_Category", "CategoryID");
            }
            return RecCount;
        }
        public static int Delete(int id)
        {
            Category Tmp = null;
            DbContext db = new DbContext();
            string Sql = $"DELETE FROM T_Category WHERE CategoryID={id}";
            int RecCount = 0;
            RecCount = db.ExecuteNonQuery(Sql);
            return RecCount;
        }
    }
}