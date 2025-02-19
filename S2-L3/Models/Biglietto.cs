namespace S2_L3.Models
{
    public class Biglietto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Tipo { get; set; }
        public string Sala { get; set; }

        public Biglietto(string nome, string cognome, string tipo, string sala)
        {
            Nome = nome;
            Cognome = cognome;
            Tipo = tipo;
            Sala = sala;
        }
    }
}
