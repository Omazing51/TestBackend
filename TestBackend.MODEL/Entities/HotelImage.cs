using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class HotelImage
    {
        [Key]
        public int imageId { get; set; }
        public int hotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string imageTittle { get; set; }
        public string extensionI { get; set; }
        public byte[] imageUrl { get; set; }


    }
}
