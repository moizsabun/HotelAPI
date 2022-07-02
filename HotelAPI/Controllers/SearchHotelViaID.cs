using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchHotelViaID : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "here we will return specific hotel with details";
        }
    }
}
