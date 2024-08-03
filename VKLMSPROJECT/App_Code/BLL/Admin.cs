using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfileImg { get; set; }
        public string Role { get; set; }
        public DateTime AddDate { get; set; }

        public static List<Admin> GetAll()
        {
            return AdminDAL.GetAll();
        }
        public static Admin GetByID(int id)
        {
            return AdminDAL.GetByID(id);
        }
        public int AddEdit()
        {
            return AdminDAL.AddEdit(this);
        }
        public static int Delete(int id)
        {
            return AdminDAL.Delete(id);
        }
    }
}