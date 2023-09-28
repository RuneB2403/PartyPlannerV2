using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PartyPlannerV2.Models; // Zorg ervoor dat u de juiste namespace importeert voor uw ApplicationUser-model

namespace PartyPlannerV2.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public RegistrationController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(); // Dit retourneert de registratieweergave (Register.cshtml)
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Voeg anti-forgery token toe om CSRF-aanvallen te voorkomen
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.Role); // Voeg de rol toe aan de gebruiker

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home"); // Doorverwijzen naar de startpagina of een andere gewenste pagina na registratie
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model); // Als er validatiefouten zijn, toon het formulier opnieuw met fouten
        }

        public IActionResult Login()
        {
            return View(); // Dit retourneert de inlogweergave (Login.cshtml)
        }
    }
}