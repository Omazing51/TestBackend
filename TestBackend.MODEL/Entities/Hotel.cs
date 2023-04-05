using System.ComponentModel.DataAnnotations;

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
        public int classId { get; set; }
        public HotelClass HotelClass { get; set; }  
        public int statusId { get; set; }
        public HotelStatus HotelStatus { get; set; }
    }
}
