using Microsoft.AspNetCore.Mvc;
using S2_L3.Models;
using System;

namespace S2_L3.Controllers
{
    public class PrenotazioneController : Controller
    {
        [HttpPost]
        public IActionResult EffettuaPrenotazione(string nome, string cognome, string sala, string tipo)
        {
            try
            {
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome))
                {
                    TempData["ErrorMessage"] = "Nome e cognome sono obbligatori.";
                    return RedirectToAction("Index", "Home");
                }

                if (tipo != "Intero" && tipo != "Ridotto")
                {
                    TempData["ErrorMessage"] = "Tipo di biglietto non valido. Deve essere 'Intero' o 'Ridotto'.";
                    return RedirectToAction("Index", "Home");
                }

                Biglietto biglietto = new Biglietto(nome, cognome, tipo, sala);

                bool aggiunto = DatiStatici.AggiungiBiglietto(biglietto);
                if (!aggiunto)
                {
                    TempData["ErrorMessage"] = "Posti esauriti in questa sala.";
                    return RedirectToAction("Index", "Home");
                }

                TempData["SuccessMessage"] = "Prenotazione effettuata con successo!";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Errore interno: " + ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
