using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}