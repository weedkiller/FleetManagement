﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessFlow.Models;
using BusinessFlow.Data;

namespace BusinessFlow.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Support()
        {
            ViewData["Message"] = "Please contact us if you need any technical support.";

            return View();
        }
 
        public IActionResult Error()
        {
            return View();
        }
    }
}
