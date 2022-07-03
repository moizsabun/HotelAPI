using HotelAPI.BO;
using HotelAPI.Model;
using HotelAPI.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchHotelViaID : ControllerBase
    {
        private readonly ISearchHotel _IsearchHotel;
        public SearchHotelViaID(ISearchHotel iSearchHotel)
        {
            _IsearchHotel = iSearchHotel;
        }
        [HttpGet]
        public HotelMaster get(int Id)
        {
            return _IsearchHotel.getAllHotelviaID(Id);
        }
    }
}
