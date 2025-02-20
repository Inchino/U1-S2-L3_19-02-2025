using Microsoft.AspNetCore.Mvc;
using S2_L3.Models;
using S2_L3.Models.ViewModel;
using System.Collections.Generic;

namespace S2_L3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Cinema Multisala";

            var model = new SaleViewModel
            {
                Sale = DatiStatici.Sale ?? new List<Sala>()
            };

            return View(model);
        }

        public IActionResult Prenotazioni()
        {
            ViewData["Title"] = "Prenotazioni Effettuate";
            return View(GetPrenotazioniViewModel());
        }

        private PrenotazioniViewModel GetPrenotazioniViewModel()
        {
            return new PrenotazioniViewModel
            {
                Biglietti = DatiStatici.Biglietti ?? new List<Biglietto>(),
                Sale = DatiStatici.Sale ?? new List<Sala>()
            };
        }
    }
}
