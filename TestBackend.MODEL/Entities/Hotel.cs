using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class Hotel
    {
        [Key]
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string hotelDescription { get; set;}
        //[ForeignKey("locationId")]
        //public Location Location { get; set; }
        //[ForeignKey("hotelClassId")]
        //public HotelClass HotelClass { get; set; }
        //[ForeignKey("hotelStatusId")]
        //public HotelStatus HotelStatus { get; set; }
        //public ICollection<Room> Rooms { get; set; }
        //public ICollection<Booking> Bookings { get; set; }
        //public ICollection<HotelImage> HotelImages { get; set; }
    }
}
