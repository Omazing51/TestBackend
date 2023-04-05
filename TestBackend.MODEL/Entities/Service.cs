using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class Service
    {
        [Key]
        public int serviceId { get; set; }
        public string serviceName { get; set; }
        public string serviceDescription { get; set; }
    }
}
