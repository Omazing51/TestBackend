using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class Location
    {
        [Key]
        public int locationId {  get; set; }
        public int cityId { get; set; }
        public City City { get; set; }
        public string? postalCode { get; set; }
        public string locationDescription { get; set; } 

    }
}
