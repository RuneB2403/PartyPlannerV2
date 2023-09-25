using Microsoft.AspNetCore.Mvc;

namespace PartyPlannerV2.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Party()
        {
            return View();
        }
    }
}