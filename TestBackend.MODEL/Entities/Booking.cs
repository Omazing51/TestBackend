namespace TestBackend.MODEL.Entities
{
    public class Booking
    {
        public int idBooking { get; set; }
        public int idHotel { get; set; }
        public int typeIdentification { get; set; }
        public int identificationUser { get; set; }
        public string firstName { get; set;}
        public string secondName { get; set;}   
        public string firstLastName { get; set;}
        public string secondLastName { get; set;}
        public string emailUser { get; set; }


    }
}
