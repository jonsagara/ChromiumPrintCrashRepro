﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChromiumPrintCrashRepro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Print()
        {
            return View();
        }
    }
}
