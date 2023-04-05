using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }
        [ForeignKey("hotelId")]
        public Hotel Hotel { get; set; }
        //[ForeignKey("bookingStatuslId")]
        //public BookingStatus BookingStatus { get; set; }
        //public ICollection<BookingDetail> BookingDetails { get; set;}


    }
}
