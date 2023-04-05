using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class RoomImage
    {
        [Key]
        public int imageId { get; set; }
        //[ForeignKey("roomId")]
        //public Room Room { get; set; }
        public string imageTittle { get; set; }
        public string imageDescription { get; set; }
        public string imageUrl { get; set; }
        //public ICollection<Room> Rooms { get; set; }
    }
}
