using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class RoomStatus
    {
        [Key]
        public int statusId {  get; set; }
        public string statusDescription { get; set; }
        //public ICollection<Room> Rooms { get; set; }
    }
}
