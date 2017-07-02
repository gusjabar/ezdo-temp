using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository;
//using ezDoctorOffice_2.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ezDoctorOffice_2.Controllers
{
    public class HomeController : Controller
    {
        DocOffContext _repository;
        IConfigurationRoot _config;
        public HomeController(DocOffContext repository, IConfigurationRoot config)
        {
            this._repository = repository;
            this._config = config;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Greetings = "Welcome";

            var users = this._repository.Users.ToList();

            return View(users);
        }
    }
}
