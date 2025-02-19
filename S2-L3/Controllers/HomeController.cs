using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S2_L3.Models;

namespace S2_L3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(DatiStatici.Sale);
        }

        public IActionResult Prenotazioni()
        {
            return View(DatiStatici.Biglietti);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
