namespace TestBackend.MODEL.Entities
{
    public class Hotel
    {
        public int idHotel { get; set; }
        public string nameHotel { get; set; }
        public string descriptionHotel { get; set;}
        public int idLocation { get; set; }
        public int idClass { get; set; }
        public int idStatus { get; set; }
    }
}
