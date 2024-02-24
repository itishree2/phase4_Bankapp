using Microsoft.AspNetCore.Mvc;

namespace WebAppBank.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index(string username)
        {
            ViewBag.Username = username;
            return View();
        }
        [HttpPost]
        public IActionResult Logout() 
        {
            return RedirectToAction("Login", "Home");
        }
    }
}
