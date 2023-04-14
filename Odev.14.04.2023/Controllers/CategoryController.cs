using Microsoft.AspNetCore.Mvc;

namespace Odev._14._04._2023.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
