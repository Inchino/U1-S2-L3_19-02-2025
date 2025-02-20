using System;

namespace S2_L3.Models
{
    public class Sala
    {
        public string Nome { get; set; }
        public int CapienzaMassima { get; set; } = 120;
        public int BigliettiVenduti { get; private set; } = 0;
        public int BigliettiRidotti { get; private set; } = 0;

        public int PostiDisponibili => CapienzaMassima - BigliettiVenduti;

        public Sala() { }

        public Sala(string nome)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "Il nome della sala non può essere nullo.");
        }

        public bool Disponibile()
        {
            return BigliettiVenduti < CapienzaMassima;
        }

        public bool AggiungiBiglietto(bool ridotto)
        {
            if (!Disponibile())
            {
                return false; 
            }

            BigliettiVenduti++;
            if (ridotto) BigliettiRidotti++;
            return true;
        }
    }
}
