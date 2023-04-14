using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class Room
    {
        [Key]
        public int roomId { get; set; }
        [ForeignKey("hotelId")]
        public Hotel Hotel { get; set; }
        public string roomName { get; set; }
        public string roomDescription { get; set;}
        [ForeignKey("roomTypeId")]
        public RoomType RoomType { get; set; }
        public string location { get; set; }
        [ForeignKey("roomStatusId")]
        public RoomStatus RoomStatus { get; set; }
        public int hotelId { get; set; }
        public int roomTypeId { get; set; }
        public int roomStatusId { get; set; }
        //public ICollection<RoomImage> RoomImages { get; set; }
    }
}
