using System.ComponentModel.DataAnnotations;

namespace PartyPlannerV2.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? InfoText { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public string? DateTime { get; set; }
        [Required]
        public float Costs { get; set; }
        [Required]
        public int Maxparticipants { get; set; }
        [Required]
        public int CurrentParticipants { get; set; }
        public List<Participant> Participants { get; set; } = new List<Participant>();
        public List<Cashier> Cashiers { get; set; } = new List<Cashier>();
        public void ReduceAvailableSpots()
        {
            if (CurrentParticipants < Maxparticipants)
            {
                Maxparticipants--;
            }
            else
            {
                throw new InvalidOperationException("Er zijn geen beschikbare plaatsen meer voor dit evenement.");
            }
        }
    }
}
