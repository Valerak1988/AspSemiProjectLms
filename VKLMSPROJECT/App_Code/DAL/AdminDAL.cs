using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using DATA;

namespace DAL
{
    public class AdminDAL
    {
        public static List<Admin> GetAll()
        {
            List<Admin> AdminList = new List<Admin>();
            DbContext Db = new DbContext();
            string sql = "SELECT * FROM T_Admin";
            DataTable Dt = Db.Execute(sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Admin Tmp = new Admin()
                {
                    AdminID = int.Parse(Dt.Rows[i]["AdminID"] + ""),
                    AdminName = Dt.Rows[i]["AdminName"] + "",
                    AdminLastName = Dt.Rows[i]["AdminLastName"] + "",
                    Email = Dt.Rows[i]["Email"] + "",
                    Password = Dt.Rows[i]["Password"] + "",
                    ProfileImg = Dt.Rows[i]["ProfileImg"] + "",
                    Role = Dt.Rows[i]["Role"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"] + "")
                };
                AdminList.Add(Tmp);
            }
            Db.Close();
            return AdminList;
        }
        public static Admin GetByID(int id)
        {
            DbContext Db = new DbContext();
            string sql = $"SELECT * FROM T_Admin WHERE AdminID={id}";
            DataTable Dt = Db.Execute(sql);
            Admin Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Admin()
                {
                    AdminID = int.Parse(Dt.Rows[0]["AdminID"] + ""),
                    AdminName = Dt.Rows[0]["AdminName"] + "",
                    AdminLastName = Dt.Rows[0]["AdminLastName"] + "",
                    Password = Dt.Rows[0]["Password"] + "",
                    Email = Dt.Rows[0]["Email"] + "",
                    ProfileImg = Dt.Rows[0]["ProfileImg"] + "",
                    Role = Dt.Rows[0]["Role"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            Db.Close();
            return Tmp;
        }
        public static int AddEdit(Admin Tmp)
        {
            int RecCount = 0;
            DbContext db = new DbContext();
            string Sql = "";
            if (Tmp.AdminID == -1)
            {
                Sql = $"INSERT INTO T_Admin (AdminName, AdminLastName, Email, Password, ProfileImg, Role) VALUES";
                Sql += $"(N'{Tmp.AdminName}', N'{Tmp.AdminLastName}', N'{Tmp.Email}', N'{Tmp.Password}', N'{Tmp.ProfileImg}', N'{Tmp.Role}')";
            }
            else
            {
                Sql = "UPDATE T_Admin SET ";
                Sql += $"AdminName = N'{Tmp.AdminName}',";
                Sql += $"AdminLastName = N'{Tmp.AdminLastName}',";
                Sql += $"Email = N'{Tmp.Email}',";
                Sql += $"Password = N'{Tmp.Password}',";
                Sql += $"ProfileImg = N'{Tmp.ProfileImg}',";
                Sql += $"Role = N'{Tmp.Role}'";
                Sql += $"WHERE AdminID = {Tmp.AdminID}";
            }
            RecCount = db.ExecuteNonQuery(Sql);

            if (Tmp.AdminID == -1)
            {
                Tmp.AdminID = db.GetMaxId("T_Admin", "AdminID");
            }
            return RecCount;
        }
        public static int Delete(int id)
        {
            Admin Tmp = null;
            DbContext db = new DbContext();
            string sql = $"DELETE FROM T_Admin WHERE AdminID = {id}";
            int RecCount = 0;
            RecCount = db.ExecuteNonQuery(sql);
            return RecCount;
        }
    }
}