﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class Location
    {
        [Key]
        public int locationId {  get; set; }
        //[ForeignKey("cityId")]
        //public City City { get; set; }
        public string? postalCode { get; set; }
        public string locationDescription { get; set; }
        //public ICollection<Hotel> Hotels { get; set; }

    }
}
