using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class BlogMvcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}