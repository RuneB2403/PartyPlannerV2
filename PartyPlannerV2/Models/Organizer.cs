using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PartyPlannerV2.Models
{
    public class Organizer : IdentityUser
    {
        [Key]
        public int OrganizerId { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<Event> events { get; set; } = new List<Event>();

        public static void CreateEvent()
        {
            //Create event
        }
        public static void UpdateEvent(Event eventId)
        {
            //Update event information
        }
        public static void DeleteEvent(Event eventId)
        {
            //Delete entire event
        }
        public static void CreateCashier()
        {
            //Create event
        }
        public static void UpdateCashier(Cashier cashierId)
        {
            //Update Cashier with Id
        }
        public static void DeleteCashier(Cashier cashierId)
        {
            //Delete Cashier with Id
        }
    }
}
