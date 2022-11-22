using Microsoft.AspNetCore.Mvc;
using mvc_formy.Models;

namespace mvc_formy.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                return Redirect("../Home/Index");
            }
            return View(user);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                return Redirect("../Home/Index");
            }
            return View(user);
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
