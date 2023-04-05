using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class Country
    {
        [Key]
        public int countryId { get; set; }
        public string countryName { get; set; }
        //public ICollection<City> Cities { get; set; }
    }
}
