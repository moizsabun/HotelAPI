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
    public class SearchHotelViaIDService : baseClass , ISearchHotel
    {
        public SearchHotelViaIDService(AppDBContext DBCONTEXT) : base(DBCONTEXT)
        {

        }

        public HotelMaster getAllHotelviaID(int Id)
        {
            try
            {
                return _appDBContext.HotelMasters.Where(s => s.HotelId == Id && s.HotelStatus == true).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new Exception("Exception while Reading data from datasource", ex);
            }
        }
    }
}
