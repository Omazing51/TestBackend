namespace TestBackend.MODEL.Entities
{
    public class RoomBooking
    {
        public int roomId { get; set; }
        public Room Room { get; set; }
        public int bookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
