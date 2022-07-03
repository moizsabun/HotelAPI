using HotelAPI.DA;
using HotelAPI.Model;
using HotelAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Service
{
    public class AddBookingService : baseClass , IAddBooking
    {
        public AddBookingService(AppDBContext DBCONTEXT) : base(DBCONTEXT)
        {

        }

        public int addBooking(HotelBooking bookingdata)
        {
            HotelBooking data = new HotelBooking()
            {
                HotelId = bookingdata.HotelId,
                HotelBookBy = bookingdata.HotelBookBy,
                HotelBookingDate = bookingdata.HotelBookingDate,
                BookingId = 0,
                HotelCheckout = bookingdata.HotelCheckout,
                HotelCustomerIdentification = bookingdata.HotelCustomerIdentification,
                HotelCustomerName = bookingdata.HotelCustomerName,
            };
            try
            {
                _appDBContext.HotelBookings.Add(data);
                _appDBContext.SaveChanges();
                return data.BookingId;


            }
            catch (Exception ex)
            {

                throw new Exception("Error while inserting data",ex);
            }
        }
    }
}
