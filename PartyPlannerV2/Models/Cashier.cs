using System.ComponentModel.DataAnnotations;

namespace PartyPlannerV2.Models
{
    public class Cashier
    {
        [Key]
        public int CashierId { get; set; }
        [Required]
        public string? Name { get; set; }

        public static void UpdateOrder(Order payed)
        {
            //If payed true
        }
    }
}
