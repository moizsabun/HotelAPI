using HotelAPI.BO;
using HotelAPI.DA;
using HotelAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Service
{
   public class ListAllHotelsService : baseClass, IListAllHotel
    {
        public ListAllHotelsService(AppDBContext DBCONTEXT) : base(DBCONTEXT)
        {

        }

        public List<HotelMaster> getAllHotels()
        {
            try
            {
                return _appDBContext.HotelMasters.Where(s => s.HotelStatus == true).ToList();
            }
            catch (Exception ex) 
            {

                throw new Exception("Exception while Reading data from datasource" , ex);
            }
        }
    }
}
