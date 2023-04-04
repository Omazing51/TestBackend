namespace TestBackend.MODEL.Entities
{
    public class Hotel
    {
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string hotelDescription { get; set;}
        public int locationId { get; set; }
        public int classId { get; set; }
        public int statusId { get; set; }
    }
}
