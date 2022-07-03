using HotelAPI.Model;
using HotelAPI.Service.Interface;
using HotelAPI.ViewModels;
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

        public ResponseModel Post([FromBody] HotelBooking data)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                responseModel.Data = _iAddBooking.addBooking(data); 
                responseModel.StatusCode = 200;
                responseModel.StatusMessage = "Sucessful";
            }
            catch (Exception ex)
            {

                responseModel.Data = ex.Data;
                responseModel.StatusCode = 400;
                responseModel.StatusMessage = ex.Message;
            }
            return responseModel;
             
        }
    }
}
