using Microsoft.AspNetCore.Mvc;

namespace Odev._14._04._2023.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
