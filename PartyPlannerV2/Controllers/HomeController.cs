using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartyPlannerV2.Data;
using PartyPlannerV2.Models;
using System.Diagnostics;

namespace PartyPlannerV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PartyPlannerDbV2 _context;

        public HomeController(ILogger<HomeController> logger, PartyPlannerDbV2 context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult EventList()
        {
            // Haal evenementen op uit de database en geef ze door aan de weergave
            List<Event> events = _context.Events.ToList();
            return View(events);
        }
        
        public IActionResult CashRegister()
        {
            // Haal evenementen op uit de database en geef ze door aan de weergave
            List<Order> orders = _context.Orders.ToList();
            return View(orders);
        }
        [HttpPost]
        public IActionResult UpdatePaymentStatus(int orderId, bool isChecked)
        {
            // Zoek de order in de database op basis van orderId en werk de betaalstatus bij
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                order.Payed = isChecked;
                _context.SaveChanges(); // Opslaan van de wijziging in de database
                return Ok(); // Terugkeren met een succesvolle status (HTTP 200 OK)
            }
            return NotFound(); // Order niet gevonden
        }
    }
}