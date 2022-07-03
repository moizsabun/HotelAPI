using HotelAPI.BO;
using HotelAPI.Model;
using HotelAPI.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListAllHotels : ControllerBase
    {
        private readonly IListAllHotel _iListAllHotel;
        public ListAllHotels(IListAllHotel ilistAllHotel)
        {
            _iListAllHotel = ilistAllHotel;
        }
        [HttpGet]
        public List<HotelMaster> get()
        {
            return _iListAllHotel.getAllHotels();
        }
    }
}
