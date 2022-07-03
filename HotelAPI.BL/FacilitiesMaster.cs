using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.BO
{
    [Keyless]
    [Table("Facilities_Master")]
    public partial class FacilitiesMaster
    {
        [Column("Facilities_ID")]
        public int FacilitiesId { get; set; }
        [Column("Facilities_Name")]
        [StringLength(500)]
        public string? FacilitiesName { get; set; }
        [Column("Facilities_AddedBy")]
        public int? FacilitiesAddedBy { get; set; }
        [Column("Facilities_AddedDateTime", TypeName = "datetime")]
        public DateTime? FacilitiesAddedDateTime { get; set; }
        [Column("Facilities_Status")]
        public bool? FacilitiesStatus { get; set; }
    }
}
