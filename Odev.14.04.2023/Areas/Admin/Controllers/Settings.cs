using Microsoft.AspNetCore.Mvc;

namespace Odev._14._04._2023.Areas.Admin.Controllers
{
    public class Settings : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
