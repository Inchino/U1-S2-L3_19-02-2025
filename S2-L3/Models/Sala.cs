namespace S2_L3.Models
{
    public class Sala
    {
        public string Nome { get; set; }
        public int CapienzaMassima { get; set; } = 120;
        public int BigliettiVenduti { get; set; } = 0;
        public int BigliettiRidotti { get; set; } = 0;

        public Sala(string nome)
        {
            Nome = nome;
        }

        public bool Disponibile()
        {
            return BigliettiVenduti < CapienzaMassima;
        }

        public void AggiungiBiglietto(bool ridotto)
        {
            if (Disponibile())
            {
                BigliettiVenduti++;
                if (ridotto) BigliettiRidotti++;
            }
        }
    }
}
