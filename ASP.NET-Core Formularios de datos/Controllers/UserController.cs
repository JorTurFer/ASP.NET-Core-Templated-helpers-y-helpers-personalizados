using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Formularios_de_datos.Models;
using ASP.NET_Core_Formularios_de_datos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Formularios_de_datos.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("edit")]
        public IActionResult Edit()
        {
            ViewBag.UserTypes = UserType.GetUserTypes();
            return View(new UserViewModel());
        }

        [HttpPost]
        [Route("edit")]
        public IActionResult Edit(UserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Content("All right");
            }
            else
            {
                ViewBag.UserTypes = UserType.GetUserTypes();
                return View(vm);
            }
        }
    }
}