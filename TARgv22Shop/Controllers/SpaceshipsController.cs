﻿using Microsoft.AspNetCore.Mvc;

namespace TARgv22Shop.Controllers
{
    public class SpaceshipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
