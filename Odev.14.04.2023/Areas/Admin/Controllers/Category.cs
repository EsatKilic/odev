﻿using Microsoft.AspNetCore.Mvc;

namespace Odev._14._04._2023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
