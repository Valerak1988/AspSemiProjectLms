using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfileImg { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public static List<Client> GetAll()
        {
            return ClientDAL.GetAll();
        }
        public static Client GetById(int id)
        {
            return ClientDAL.GetById(id);
        }
        public int AddEdit()
        {
            return ClientDAL.AddEdit(this);
        }
        public static int Delete(int id)
        {
            return ClientDAL.Delete(id);
        }
    }
}