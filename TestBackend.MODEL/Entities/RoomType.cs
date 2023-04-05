using System.ComponentModel.DataAnnotations;

namespace TestBackend.MODEL.Entities
{
    public class RoomType
    {
        [Key]
        public int typeId { get; set; }
        public string DescriptionType { get; set; }
        public int totalPerson { get; set; }
        public int? totalToilet { get; set; }
        public int? totalJacuzzi { get; set; }
        public int? totalTv { get; set; }
        public decimal totalValue { get; set; }
    }
}
