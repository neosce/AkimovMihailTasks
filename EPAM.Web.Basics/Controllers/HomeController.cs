using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPAM.Web.Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace EPAM.Web.Basics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}