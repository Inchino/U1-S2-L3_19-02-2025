using Microsoft.AspNetCore.Mvc;
using S2_L3.Models;

namespace S2_L3.Controllers
{
    public class PrenotazioneController : Controller
    {
        [HttpPost]
        public IActionResult EffettuaPrenotazione(string nome, string cognome, string sala, string tipo)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cognome))
            {
                Biglietto biglietto = new Biglietto(nome, cognome, tipo, sala);
                DatiStatici.AggiungiBiglietto(biglietto);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
