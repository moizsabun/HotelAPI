using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Model
{
    [Keyless]
    [Table("Hotel_Booking")]
    public partial class HotelBooking
    {
        [Column("Booking_ID")]
        public int BookingId { get; set; }
        [Column("Hotel_ID")]
        public int? HotelId { get; set; }
        [Column("Hotel_BookBy")]
        public int? HotelBookBy { get; set; }
        [Column("Hotel_BookingDate", TypeName = "datetime")]
        public DateTime? HotelBookingDate { get; set; }
        [Column("Hotel_Checkout", TypeName = "datetime")]
        public DateTime? HotelCheckout { get; set; }
        [Column("Hotel_CustomerName")]
        [StringLength(200)]
        public string? HotelCustomerName { get; set; }
        [Column("Hotel_CustomerIdentification_ID")]
        public int? HotelCustomerIdentificationId { get; set; }
    }
}
