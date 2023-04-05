using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class RoomBooking
    {
        [ForeignKey("roomId")]
        public Room Room { get; set; }
        [ForeignKey("bookingId")]
        public Booking Booking { get; set; }

    }
}
