using HotelAPI.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Service.Interface
{
    public interface ISearchHotel
    {
        public HotelMaster getAllHotelviaID(int Id);
    }
}
