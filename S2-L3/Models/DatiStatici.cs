using System.Collections.Generic;
using System.Linq;

namespace S2_L3.Models
{
    public static class DatiStatici
    {
        public static List<Sala> Sale = new List<Sala>
        {
            new Sala("SALA NORD"),
            new Sala("SALA EST"),
            new Sala("SALA SUD")
        };

        public static List<Biglietto> Biglietti = new List<Biglietto>();

        public static Sala TrovaSala(string nome)
        {
            return Sale.FirstOrDefault(s => s.Nome == nome);
        }

        public static void AggiungiBiglietto(Biglietto biglietto)
        {
            var sala = TrovaSala(biglietto.Sala);
            if (sala != null && sala.Disponibile())
            {
                sala.AggiungiBiglietto(biglietto.Tipo == "Ridotto");
                Biglietti.Add(biglietto);
            }
        }
    }
}
