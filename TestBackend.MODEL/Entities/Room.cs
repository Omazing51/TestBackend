namespace TestBackend.MODEL.Entities
{
    public class Room
    {
        public int roomId { get; set; }
        public int hotelId { get; set; }
        public string roomName { get; set; }
        public string roomDescription { get; set;}
        public int typeId { get; set; }
        public int locationId { get; set; }
        public int statusId { get; set; }
    }
}
