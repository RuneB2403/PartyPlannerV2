using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartyPlannerV2.Models;
using PartyPlannerV2.Data;

namespace PartyPlannerV2.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly PartyPlannerDbV2 _dbContext; // Voeg je DbContext toe

        public RegistrationController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, PartyPlannerDbV2 dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext; // Injecteer de DbContext
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(string rol, string name)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = name, NormalizedUserName = name.ToUpper() };
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    // Voeg de gebruiker toe aan de gewenste rol
                    await _userManager.AddToRoleAsync(user, rol);

                    // Voeg de gebruiker handmatig toe aan de Organizer- of Participant-tabel
                    if (rol == "organizer")
                    {
                        var organizer = new Organizer
                        {
                            Name = name,
                            // Vul andere eigenschappen van de organizer in
                        };
                        _dbContext.Organizers.Add(organizer);
                        await _dbContext.SaveChangesAsync();
                    }
                    else if (rol == "participant")
                    {
                        var participant = new Participant
                        {
                            Name = name,
                            // Vul andere eigenschappen van de participant in
                        };
                        _dbContext.Participants.Add(participant);
                        await _dbContext.SaveChangesAsync();
                    }

                    // Voer hier andere logica uit, bijvoorbeeld door te verwijzen naar een inlogpagina.
                    return RedirectToAction("Login", "Account"); // Pas dit aan naar de gewenste inlogpagina.
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Als er een fout is opgetreden, blijf op het registratieformulier.
            return View("Register"); // Zorg ervoor dat je de juiste viewnaam hier gebruikt.
        }
    }
}
