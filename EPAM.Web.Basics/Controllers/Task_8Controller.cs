﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPAM.Web.Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace EPAM.Web.Basics.Controllers
{
    public class Task_8Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Task8_1()
        {
            List<Product> products = new List<Product>()
            {
                new Product() {Id = 1, Name = "Азу по-татарски" },
                new Product() {Id = 2, Name = "Зразы" },
                new Product() {Id = 3, Name = "Баранья грудинка, тушенная с картофелем" },
                new Product() {Id = 4, Name = "Бефстроганов" },
                new Product() {Id = 5, Name = "Бивштекс с яйцом" }
            };

            return View(products);
        }

        public IActionResult Task8_2()
        {
            return View();
        }

        public IActionResult Task8_3()
        {
            return View();
        }

        public IActionResult Task8_4()
        {
            return View();
        }

        public IActionResult Task8_5()
        {
            return View();
        }

        public IActionResult Task8_6()
        {
            return View();
        }

        public IActionResult Task8_7()
        {
            return View();
        }

        public IActionResult Task8_8()
        {
            return View();
        }

        public IActionResult Task8_9()
        {
            return View();
        }
    }
}