using formularzDawid.Models;
using Microsoft.AspNetCore.Mvc;

namespace formularzDawid.Controllers
{
    public class RejestracjaController : Controller
    {
  
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    
        [HttpPost]
        public IActionResult Index(Rejestracja rejestracja)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Rejestracja zakończona pomyślnie!";
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Wyczyść()
        {
            return RedirectToAction("Index");
        }
    }
}
