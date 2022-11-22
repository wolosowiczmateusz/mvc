//2. Kontekst aplikacji
using Microsoft.AspNetCore.Mvc;

namespace mvc_formy.Controllers
{
    public class CounterController : Controller
    {
       /* public ActionResult AppTest()
        {
            var app = HttpContext.Application;

            if (app["licznik_odwiedzin"] == null)
                ViewBag.Message = "Kontekst aplikacji jest pusty";
            else
                ViewBag.Message = app["licznik_odwiedzin"];
            
            return View();
        }

        [HttpPost]
        public ActionResult AppTest(string val)
        {
            
            var app = HttpContext.Application;

            if (!String.IsNullOrEmpty(val))
            {
                app["licznik_odwiedzin"] = val;

                return RedirectToAction("AppTest");
            }

            return View();
        }*/
    }
}