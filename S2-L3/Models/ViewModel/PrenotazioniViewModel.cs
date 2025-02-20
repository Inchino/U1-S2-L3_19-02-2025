namespace S2_L3.Models.ViewModel
{
    public class PrenotazioniViewModel
    {
        public List<Biglietto> Biglietti { get; set; } = new();
        public List<Sala> Sale { get; set; } = new();

        public PrenotazioniViewModel() { }

        public PrenotazioniViewModel(List<Biglietto> biglietti, List<Sala> sale)
        {
            Biglietti = biglietti ?? new List<Biglietto>();
            Sale = sale ?? new List<Sala>();
        }
    }
}
