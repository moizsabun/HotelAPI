using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Model
{
    [Keyless]
    [Table("Hotel_Master")]
    public partial class HotelMaster
    {
        [Column("Hotel_ID")]
        public int HotelId { get; set; }
        [Column("Hotel_Name")]
        [StringLength(100)]
        public string? HotelName { get; set; }
        [Column("Hotel_Address")]
        [StringLength(300)]
        public string? HotelAddress { get; set; }
        [Column("Hotel_Description")]
        [StringLength(300)]
        public string? HotelDescription { get; set; }
        [Column("Hotel_Ratings")]
        public int? HotelRatings { get; set; }
        [Column("Hotel_Review")]
        public int? HotelReview { get; set; }
        [Column("Hotel_Facilities")]
        [StringLength(200)]
        public string? HotelFacilities { get; set; }
        [Column("Hotel_Charges")]
        public int? HotelCharges { get; set; }
        [Column("Hotel_AddedBy")]
        public int? HotelAddedBy { get; set; }
        [Column("Hotel_AddedDatetime", TypeName = "datetime")]
        public DateTime? HotelAddedDatetime { get; set; }
        [Column("Hotel_Status")]
        public bool? HotelStatus { get; set; }
        [Column("Hotel_Rooms")]
        public int? HotelRooms { get; set; }
        [Column("Hotel_Image_1")]
        public string? HotelImage1 { get; set; }
        [Column("Hotel_Image_2")]
        public string? HotelImage2 { get; set; }
        [Column("Hotel_Image_3")]
        public string? HotelImage3 { get; set; }
    }
}
