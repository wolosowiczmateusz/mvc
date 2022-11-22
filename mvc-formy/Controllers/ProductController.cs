using Microsoft.AspNetCore.Mvc;
using mvc_formy.Models;

namespace mvc_formy.Controllers
{
    public class ProductController : Controller
    {
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                return Redirect("../Home/Index");
            }
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
