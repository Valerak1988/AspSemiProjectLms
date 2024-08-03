using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public static List<City> GetAll()
        {
            return CityDAL.GetAll();
        }
        public static City GetByID(int id)
        {
            return CityDAL.GetByID(id);
        }
        public int AddEdit()
        {
            return CityDAL.AddEdit(this);
        }
        public static int Delete(int id)
        {
            return CityDAL.Delete(id);
        }
    }
}