namespace TestBackend.MODEL.Entities
{
    public class BookingDetail
    {
        public int idBookingDetail { get; set; }
        public int idBooking { get; set; }
        public int typeIdentification { get; set; }
        public int identificationUser { get; set; }
        public string firstName { get; set; }
        public string? secondName { get; set; }
        public string firstLastName { get; set; }
        public string? secondLastName { get; set; }
        public DateTime birthdayUser { get; set; }
        public string emailUser { get; set; }
        public string phoneNumberUser { get; set; }
        public string contactName { get; set; }
        public string phoneNumberContact { get; set; }
        public DateTime startBooking { get; set; }
        public DateTime endBooking { get; set; }
    }
}
