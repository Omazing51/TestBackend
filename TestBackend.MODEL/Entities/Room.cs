namespace TestBackend.MODEL.Entities
{
    public class Room
    {
        public int idRoom { get; set; }
        public int idHotel { get; set; }
        public string nameRoom { get; set; }
        public string descriptionRoom { get; set;}
        public int idType { get; set; }
        public int idLocation { get; set; }
    }
}
