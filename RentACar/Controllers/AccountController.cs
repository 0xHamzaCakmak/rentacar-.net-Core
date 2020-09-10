using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Context;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            using (MasterContext context = new MasterContext())
            {

            }
            return View();
        }

    }
}