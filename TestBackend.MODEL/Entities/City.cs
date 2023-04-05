using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBackend.MODEL.Entities
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        [ForeignKey("countryId")]
        public Country Country { get; set; }
        public string cityName { get; set; }

        //public ICollection<Location> Locations { get; set;}
    }
}
