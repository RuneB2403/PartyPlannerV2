using System;
using System.ComponentModel.DataAnnotations;

namespace PartyPlannerV2.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        // Gebruik het DateTime-gegevenstype voor de datum en tijd
        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required]
        public bool Payed { get; set; }

        // Voeg een constructor toe om de standaardwaarde in te stellen
        public Order()
        {
            // Stel de standaardwaarde in op de huidige datum en tijd wanneer een nieuw Order-object wordt gemaakt
            DateTime = DateTime.Now;
        }
    }
}