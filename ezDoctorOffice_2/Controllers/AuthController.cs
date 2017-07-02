using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ezDoctorOffice_2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ezDoctorOffice_2.Controllers
{
    public class AuthController : Controller
    {
        SignInManager<DocOffUser> _manager;
        public AuthController(SignInManager<DocOffUser> manager)
        {
            _manager = manager;
        }

        // GET: /<controller>/
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View();

            var signInResult =  await _manager.PasswordSignInAsync(model.UserName, model.Password, true, false);

            if (signInResult.Succeeded)
            {
                if (string.IsNullOrWhiteSpace(returnUrl))
                    return RedirectToAction("Home", "Index");
                else
                    return Redirect(returnUrl);
            }
            if (signInResult.IsLockedOut)
            {
                ModelState.TryAddModelError("", "User account locked out.");
			}
            else
            {
                ModelState.TryAddModelError("","Username or password incorrect.");   
            }
            return View();

        }
    }
}
