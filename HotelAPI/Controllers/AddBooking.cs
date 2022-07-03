using HotelAPI.Model;
using HotelAPI.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBooking : ControllerBase
    {
        private readonly IAddBooking _iAddBooking;

        public AddBooking(IAddBooking iAddBooking)
        {
            _iAddBooking = iAddBooking;
        }

        [HttpPost]

        public int Post([FromBody] HotelBooking data)
        {
            return _iAddBooking.addBooking(data);
        }
    }
}
