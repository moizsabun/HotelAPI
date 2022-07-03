using HotelAPI.BO;
using HotelAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Service.Interface
{
    public interface IListAllHotel
    {
        public List<HotelMaster> getAllHotels();
    }
}
