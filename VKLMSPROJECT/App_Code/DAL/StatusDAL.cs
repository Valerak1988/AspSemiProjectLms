using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using DATA;


namespace DAL
{
    public class StatusDAL
    {
        public static List<Status> GetAll()
        {
            List<Status> StatusList = new List<Status>();
            DbContext db = new DbContext();
            string Sql = "SELECT * FROM T_Status";
            DataTable Dt = db.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Status Tmp = new Status()
                {
                    StatusID = int.Parse(Dt.Rows[i]["StatusID"] + ""),
                    StatusName = Dt.Rows[i]["StatusName"] + "",
                    StatusDescription = Dt.Rows[i]["StatusDescription"] + "",
                    StatusImg = Dt.Rows[i]["StatusImg"] + ""
                };
                StatusList.Add(Tmp);
            }
            db.Close();
            return StatusList;
        }
        public static Status GetById(int id)
        {
            DbContext db = new DbContext();
            string Sql = $"Select * FROM T_Status WHERE StatusID={id}";
            DataTable Dt = db.Execute(Sql);
            Status Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Status()
                {
                    StatusID = int.Parse(Dt.Rows[0]["StatusID"] + ""),
                    StatusName = Dt.Rows[0]["StatusName"] + "",
                    StatusDescription = Dt.Rows[0]["StatusDescription"] + "",
                    StatusImg = Dt.Rows[0]["StatusImg"] + ""
                };
            }
            db.Close();
            return Tmp;
        }
        public static int AddEdit(Status Tmp)
        {
            int RecCount = 0;
            DbContext db = new DbContext();
            string Sql = "";
            if (Tmp.StatusID == -1)
            {
                Sql = $"INSERT INTO T_Status (StatusName, StatusDescription, StatusImg) VALUES ";
                Sql += $"(N'{Tmp.StatusName}', N'{Tmp.StatusDescription}', N'{Tmp.StatusImg}')";
            }
            else
            {
                Sql = "UPDATE T_Status set ";
                Sql += $"StatusName = N'{Tmp.StatusName}',";
                Sql += $"StatusDescription = N'{Tmp.StatusDescription}',";
                Sql += $"StatusImg = N'{Tmp.StatusImg}'";
                Sql += $"WHERE StatusID ={Tmp.StatusID}";
            }
            RecCount = db.ExecuteNonQuery(Sql);

            if (Tmp.StatusID == -1)
            {
                Tmp.StatusID = db.GetMaxId("T_Status", "StatusID");
            }
            return RecCount;
        }
        public static int Delete(int id)
        {
            Status Tmp = null;
            DbContext db = new DbContext();
            string Sql = $"DELETE FROM T_Status WHERE StatusID={id}";
            int RecCount = 0;
            RecCount = db.ExecuteNonQuery(Sql);
            return RecCount;
        }
    }
}