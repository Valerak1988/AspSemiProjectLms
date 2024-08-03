using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using DATA;


namespace DAL
{
    public class ClientDAL
    {
        public static List<Client> GetAll()
        {
            List<Client> ClientList = new List<Client>();
            DbContext db = new DbContext();
            string sql = "SELECT T_Client.*, T_City.CityName, T_Status.StatusName FROM T_Client " +
                         "INNER JOIN T_City ON T_Client.CityID = T_City.CityID " +
                         "INNER JOIN T_Status ON T_Client.StatusID = T_Status.StatusID";
            DataTable Dt = db.Execute(sql);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Client Tmp = new Client()
                {
                    ClientID = int.Parse(Dt.Rows[i]["ClientID"] + ""),
                    FirstName = Dt.Rows[i]["FirstName"] + "",
                    LastName = Dt.Rows[i]["LastName"] + "",
                    ID = int.Parse(Dt.Rows[i]["ID"] + ""),
                    CityID = int.Parse(Dt.Rows[i]["CityID"] + ""),
                    CityName = Dt.Rows[i]["CityName"] + "",
                    Phone = Dt.Rows[i]["Phone"] + "",
                    Email = Dt.Rows[i]["Email"] + "",
                    Password = Dt.Rows[i]["Password"] + "",
                    ProfileImg = Dt.Rows[i]["ProfileImg"] + "",
                    DateOfBirth = DateTime.Parse(Dt.Rows[i]["DateOfBirth"] + ""),
                    StatusID = int.Parse(Dt.Rows[i]["StatusID"] + ""),
                    StatusName = Dt.Rows[i]["StatusName"] + "",
                    JoinDate = DateTime.Parse(Dt.Rows[i]["JoinDate"] + ""),
                    SubscriptionEndDate = DateTime.Parse(Dt.Rows[i]["SubscriptionEndDate"] + "")
                };
                ClientList.Add(Tmp);
            }
            db.Close();
            return ClientList;
        }

        public static Client GetById(int id)
        {
            DbContext db = new DbContext();
            string Sql = $"SELECT T_Client.*, T_City.CityName, T_Status.StatusName FROM T_Client " +
                         $"INNER JOIN T_City ON T_Client.CityID = T_City.CityID " +
                         $"INNER JOIN T_Status ON T_Client.StatusID = T_Status.StatusID " +
                         $"WHERE T_Client.ClientID = {id}";
            DataTable Dt = db.Execute(Sql);
            Client Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Client()
                {
                    ClientID = int.Parse(Dt.Rows[0]["ClientID"] + ""),
                    FirstName = Dt.Rows[0]["FirstName"] + "",
                    LastName = Dt.Rows[0]["LastName"] + "",
                    ID = int.Parse(Dt.Rows[0]["ID"] + ""),
                    CityID = int.Parse(Dt.Rows[0]["CityID"] + ""),
                    CityName = Dt.Rows[0]["CityName"] + "",
                    Phone = Dt.Rows[0]["Phone"] + "",
                    Email = Dt.Rows[0]["Email"] + "",
                    Password = Dt.Rows[0]["Password"] + "",
                    ProfileImg = Dt.Rows[0]["ProfileImg"] + "",
                    DateOfBirth = DateTime.Parse(Dt.Rows[0]["DateOfBirth"] + ""),
                    StatusID = int.Parse(Dt.Rows[0]["StatusID"] + ""),
                    StatusName = Dt.Rows[0]["StatusName"] + "",
                    JoinDate = DateTime.Parse(Dt.Rows[0]["JoinDate"] + ""),
                    SubscriptionEndDate = DateTime.Parse(Dt.Rows[0]["SubscriptionEndDate"] + "")
                };
            }
            db.Close();
            return Tmp;
        }

        public static int AddEdit(Client Tmp)
        {
            int RecCount = 0;
            DbContext db = new DbContext();

            string Sql = "";
            if (Tmp.ClientID == -1)
            {
                Sql = "INSERT INTO T_Client (FirstName, LastName, ID, CityID, Phone, Email, Password, ProfileImg, DateOfBirth, StatusID, SubscriptionEndDate) VALUES";
                Sql += $"(N'{Tmp.FirstName}', N'{Tmp.LastName}', {Tmp.ID}, {Tmp.CityID}, '{Tmp.Phone}', '{Tmp.Email}', N'{Tmp.Password}', '{Tmp.ProfileImg}', '{Tmp.DateOfBirth.ToString("yyyy-MM-dd")}', {Tmp.StatusID}, '{Tmp.SubscriptionEndDate.ToString("yyyy-MM-dd")}')";
            }
            else
            {
                Sql = "UPDATE T_Client SET ";
                Sql += $"FirstName = N'{Tmp.FirstName}',";
                Sql += $"LastName = N'{Tmp.LastName}',";
                Sql += $"ID = {Tmp.ID},";
                Sql += $"CityID = {Tmp.CityID},";
                Sql += $"Phone = '{Tmp.Phone}',";
                Sql += $"Email = '{Tmp.Email}',";
                Sql += $"Password = N'{Tmp.Password}',";
                Sql += $"ProfileImg = '{Tmp.ProfileImg}',";
                Sql += $"DateOfBirth = '{Tmp.DateOfBirth.ToString("yyyy-MM-dd")}',";
                Sql += $"StatusID = {Tmp.StatusID},";
                Sql += $"SubscriptionEndDate = '{Tmp.SubscriptionEndDate.ToString("yyyy-MM-dd")}'";
                Sql += $" WHERE ClientID = {Tmp.ClientID}";
            }
            RecCount = db.ExecuteNonQuery(Sql);
            if (Tmp.ClientID == -1)
            {
                Tmp.ClientID = db.GetMaxId("T_Client", "ClientID");
            }
            return RecCount;
        }

        public static int Delete(int id)
        {
            Client Tmp = null;
            DbContext db = new DbContext();
            string Sql = $"DELETE FROM T_Client WHERE ClientID={id}";
            int RecCount = 0;
            RecCount = db.ExecuteNonQuery(Sql);
            return RecCount;
        }
    }
}