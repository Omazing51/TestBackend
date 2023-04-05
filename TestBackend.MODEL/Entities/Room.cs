using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class Room
    {
        [Key]
        public int roomId { get; set; }
        public int hotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string roomName { get; set; }
        public string roomDescription { get; set;}
        public int typeId { get; set; }
        public RoomType RoomType { get; set; }
        public int location { get; set; }
        public int statusId { get; set; }
        public RoomStatus RoomStatus { get; set; }
    }
}
