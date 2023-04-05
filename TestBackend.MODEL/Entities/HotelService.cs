using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class HotelService
    {
        [ForeignKey("hotelId")]
        public Hotel Hotel { get; set; }
        [ForeignKey("serviceId")]
        public Service Service { get; set; }

    }
}
