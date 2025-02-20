using System;

namespace S2_L3.Models
{
    public class Sala
    {
        public string Nome { get; set; }
        public int CapienzaMassima { get; set; } = 120;
        public int BigliettiVenduti { get; private set; } = 0;
        public int BigliettiRidotti { get; private set; } = 0;

        // Nuova proprietà calcolata per i posti disponibili
        public int PostiDisponibili => CapienzaMassima - BigliettiVenduti;

        // Costruttore vuoto richiesto da ASP.NET Core
        public Sala() { }

        // Costruttore con nome obbligatorio
        public Sala(string nome)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "Il nome della sala non può essere nullo.");
        }

        // Controlla se ci sono posti disponibili
        public bool Disponibile()
        {
            return BigliettiVenduti < CapienzaMassima;
        }

        // Aggiunge un biglietto e restituisce true se l'operazione ha avuto successo
        public bool AggiungiBiglietto(bool ridotto)
        {
            if (!Disponibile())
            {
                return false; // Nessun posto disponibile
            }

            BigliettiVenduti++;
            if (ridotto) BigliettiRidotti++;
            return true; // Biglietto aggiunto con successo
        }
    }
}
