using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class HotelClass
    {
        [Key]
        public int hotelClassId { get; set; }
        public string hotelClassName { get; set; }
        public string hotelClassDescription { get; set; }   
        //public ICollection<Hotel> Hotels { get; set; }
    }
}
