using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Formularios_de_datos.Models;
using ASP.NET_Core_Formularios_de_datos.Models.Services;
using ASP.NET_Core_Formularios_de_datos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Formularios_de_datos.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        IUserServices m_userServices;

        public UserController(IUserServices services)
        {
            m_userServices = services;
        }
        
        [Route("profile")]
        public IActionResult Edit()
        {
            ViewBag.UserTypes = UserType.GetUserTypes();
            return View(new UserViewModel());
        }

        [HttpPost]
        [Route("profile")]
        public IActionResult Edit(UserViewModel vm)
        {
            //Comprobacion de disponibilidad (aunque se comprueba en remote, tengo que comprobarlo en el controlador tambien)
            if (m_userServices.Exists(vm.Nickname))
                ModelState.AddModelError("Nickname", "El nombre ya esta ocupado");
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

        public JsonResult AvailableNickname(string Nickname)
        {
            return Json(!m_userServices.Exists(Nickname));
        }
    }
}