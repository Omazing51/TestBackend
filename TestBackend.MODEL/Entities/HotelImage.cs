using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class HotelImage
    {
        [Key]
        public int imageId { get; set; }
        [ForeignKey("hotelId")]
        public Hotel Hotel { get; set; }
        public string imageTittle { get; set; }
        public string imageDescription { get; set; }
        public string imageUrl { get; set; }


    }
}
