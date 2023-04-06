using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class HotelService
    {
        public int hotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int serviceId { get; set; }
        public Service Service { get; set; }

    }
}
