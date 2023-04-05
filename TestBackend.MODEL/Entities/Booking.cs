using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }
        public int hotelId { get; set; }
        //public Hotel Hotel { get; set; }
        public int statusId { get; set; }
        //public BookingStatus BookingStatus { get; set; }    

    }
}
