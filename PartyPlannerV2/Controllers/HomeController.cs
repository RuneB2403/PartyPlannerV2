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
    }
}