using Microsoft.AspNetCore.Mvc;
using mvc_formy.Models;
namespace mvc_formy.Controllers
{
    public class FormController : Controller
    {
        [HttpPost]
        public IActionResult Contact(Form form)
        {
            if (ModelState.IsValid)
            {
                return Redirect("../Home/Index");
            }
            return View(form);
        }
        public IActionResult Contact()
        {
            return View();
        }



        [HttpPost]
        public IActionResult ContactProduct(Form form)
        {
            if (ModelState.IsValid)
            {
                return Redirect("../Home/Index");
            }
            return View(form);
        }
        public IActionResult ContactProduct()
        {
            return View();
        }
    }
}
