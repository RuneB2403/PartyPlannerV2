using System.ComponentModel.DataAnnotations;

namespace PartyPlannerV2.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string? DateTime { get; set; }
        [Required]
        public int EventId { get; set; }
        [Required]
        public bool Payed { get; set; }
    }
}
