using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class HotelImage
    {
        [Key]
        public int imageId { get; set; }
        public int hotelId { get; set; }
        //public Hotel Hotel { get; set; }
        public string imageTittle { get; set; }
        public string imageDescription { get; set; }
        public string imageUrl { get; set; }


    }
}
