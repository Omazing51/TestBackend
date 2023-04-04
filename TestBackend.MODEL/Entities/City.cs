namespace TestBackend.MODEL.Entities
{
    public class City
    {
        public int cityId { get; set; }
        public int countryId { get; set; }
        public Country Country { get; set; }
        public string cityName { get; set; }
    }
}
