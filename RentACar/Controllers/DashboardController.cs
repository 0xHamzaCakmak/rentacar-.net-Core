using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Context;

namespace RentACar.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            MasterContext masterContext = new MasterContext();

            
            return View(masterContext.CarModels.ToList());
        }

        public IActionResult KiralananArac()
        {
            return View();
        }
    }
}