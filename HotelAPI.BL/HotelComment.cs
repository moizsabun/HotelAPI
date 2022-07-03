using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.BO
{
    [Keyless]
    [Table("Hotel_Comments")]
    public partial class HotelComment
    {
        [Column("Comments_ID")]
        public int CommentsId { get; set; }
        [StringLength(500)]
        public string? CommentsbyUser { get; set; }
        public double? CommentsRating { get; set; }
        public int? CommentsGivenBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CommentsAddedDatetime { get; set; }
        [Column("Hotel_ID")]
        public int? HotelId { get; set; }
        public bool? CommentsStatus { get; set; }
    }
}
