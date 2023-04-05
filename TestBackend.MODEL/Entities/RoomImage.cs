using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class RoomImage
    {
        [Key]
        public int imageId { get; set; }
        public int roomId { get; set; }
        public Room Room { get; set; }
        public string imageTittle { get; set; }
        public string imageDescription { get; set; }
        public string imageUrl { get; set; }
    }
}
