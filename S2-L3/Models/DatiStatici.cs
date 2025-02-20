using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_L3.Models
{
    public static class DatiStatici
    {
        public static readonly List<Sala> Sale = new List<Sala>
        {
            new Sala("SALA NORD"),
            new Sala("SALA EST"),
            new Sala("SALA SUD")
        };

        public static readonly List<Biglietto> Biglietti = new List<Biglietto>();

        public static Sala TrovaSala(string nome)
        {
            var sala = Sale.FirstOrDefault(s => s.Nome == nome);
            if (sala == null)
            {
                throw new KeyNotFoundException($"La sala '{nome}' non esiste.");
            }
            return sala;
        }

        public static bool AggiungiBiglietto(Biglietto biglietto)
        {
            if (biglietto == null)
            {
                throw new ArgumentNullException(nameof(biglietto), "Il biglietto non può essere null.");
            }

            var sala = TrovaSala(biglietto.Sala);
            if (sala != null && sala.Disponibile())
            {
                bool aggiunto = sala.AggiungiBiglietto(biglietto.Tipo == "Ridotto");
                if (aggiunto)
                {
                    Biglietti.Add(biglietto);
                    return true;
                }
            }
            return false;
        }
    }
}
