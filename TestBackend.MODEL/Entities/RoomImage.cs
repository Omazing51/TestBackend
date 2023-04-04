namespace TestBackend.MODEL.Entities
{
    public class RoomImage
    {
        public int imageId { get; set; }
        public int roomId { get; set; }
        public string imageTittle { get; set; }
        public string imageDescription { get; set; }
        public string imageUrl { get; set; }
    }
}
