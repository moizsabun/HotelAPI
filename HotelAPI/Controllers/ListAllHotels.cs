using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListAllHotels : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "Welcome to Hotel API.";
        }
    }
}
