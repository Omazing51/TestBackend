using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class HotelStatus
    {
        [Key]
        public int statusId { get; set; }
        public string statusDescription { get; set; }
    }
}
