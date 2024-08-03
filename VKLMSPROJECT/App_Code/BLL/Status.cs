using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Status
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public string StatusImg { get; set; }

        public static List<Status> GetAll()
        {
            return StatusDAL.GetAll();
        }
        public static Status GetById(int id)
        {
            return StatusDAL.GetById(id);
        }
        public int AddEdit()
        {
            return StatusDAL.AddEdit(this);
        }
        public static int Delete(int id)
        {
            return StatusDAL.Delete(id);
        }
    }
}