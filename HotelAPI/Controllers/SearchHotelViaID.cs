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
    public class SearchHotelViaID : ControllerBase
    {
        private readonly ISearchHotel _IsearchHotel;
        public SearchHotelViaID(ISearchHotel iSearchHotel)
        {
            _IsearchHotel = iSearchHotel;
        }
        [HttpGet]
        public ResponseModel get(int Id)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                responseModel.Data = _IsearchHotel.getAllHotelviaID(Id);
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
