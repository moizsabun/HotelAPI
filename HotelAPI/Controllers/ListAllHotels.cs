using HotelAPI.BO;
using HotelAPI.Model;
using HotelAPI.Service.Interface;
using HotelAPI.ViewModels;
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
        public ResponseModel get()
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                responseModel.Data = _iListAllHotel.getAllHotels(); 
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
