﻿using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class BookingStatus
    {
        [Key]
        public int statusId { get; set; }
        public string statusDescription { get; set; }
        //public ICollection<Booking>Bookings { get;}
    }
}
