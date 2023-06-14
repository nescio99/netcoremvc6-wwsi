using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SimpleWebsite.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Sprawdź poprawność danych logowania (np. w bazie danych)
            if (IsValidUser(username, password))
            {
                // Utwórz listę roszczeń użytkownika
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

                // Utwórz obiekt tożsamości
                var identity = new ClaimsIdentity(claims, "MyCookieAuthenticationScheme");

                // Zaloguj użytkownika
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                // Przekieruj użytkownika na stronę główną lub inną chronioną stronę
                return RedirectToAction("Index", "Home");
            }

            // Nieprawidłowe dane logowania
            ModelState.AddModelError(string.Empty, "Nieprawidłowe dane logowania.");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            // Wyloguj użytkownika
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Przekieruj użytkownika na stronę główną lub inną publiczną stronę
            return RedirectToAction("Index", "Home");
        }

        private bool IsValidUser(string username, string password)
        {
            // Sprawdź poprawność danych logowania (np. w bazie danych)
            // Zwróć true, jeśli dane są poprawne, w przeciwnym razie false
            return (username == "admin" && password == "admin123");
        }
    }
}

