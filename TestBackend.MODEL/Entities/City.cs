using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        public int countryId { get; set; }
        //public Country Country { get; set; }
        public string cityName { get; set; }
    }
}
