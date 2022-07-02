using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBooking : ControllerBase
    {
        [HttpGet]

        public string get()
        {
            return "This will be a post method for add booking for a specific hotel, initially made as get";
        }
    }
}
