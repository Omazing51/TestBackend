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
        public int locationId { get; set; }
        public Location Location { get; set; }
        public int hotelClassId { get; set; }
        public HotelClass HotelClass { get; set; }
        public int hotelStatusId { get; set; }
        public HotelStatus HotelStatus { get; set; }
        //public ICollection<Room> Rooms { get; set; }
        //public ICollection<Booking> Bookings { get; set; }
        //public ICollection<HotelImage> HotelImages { get; set; }
    }
}
