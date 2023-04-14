using Microsoft.AspNetCore.Mvc;

namespace Odev._14._04._2023.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
