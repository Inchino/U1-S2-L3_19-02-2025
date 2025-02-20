using System;
using System.ComponentModel.DataAnnotations;

namespace S2_L3.Models
{
    public class Biglietto
    {
        [Required(ErrorMessage = "Il nome è obbligatorio.")]
        [MinLength(2, ErrorMessage = "Il nome deve contenere almeno 2 caratteri.")]
        [MaxLength(50, ErrorMessage = "Il nome non può superare i 50 caratteri.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Il cognome è obbligatorio.")]
        [MinLength(2, ErrorMessage = "Il cognome deve contenere almeno 2 caratteri.")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Il tipo di biglietto è obbligatorio.")]
        [RegularExpression("Intero|Ridotto", ErrorMessage = "Il tipo deve essere 'Intero' o 'Ridotto'.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La sala è obbligatoria.")]
        public string Sala { get; set; }

        public Biglietto() { }

        public Biglietto(string nome, string cognome, string tipo, string sala)
        {
            Nome = !string.IsNullOrWhiteSpace(nome) ? nome : throw new ArgumentException("Il nome non può essere vuoto.");
            Cognome = !string.IsNullOrWhiteSpace(cognome) ? cognome : throw new ArgumentException("Il cognome non può essere vuoto.");
            Tipo = tipo == "Intero" || tipo == "Ridotto" ? tipo : throw new ArgumentException("Tipo di biglietto non valido.");
            Sala = !string.IsNullOrWhiteSpace(sala) ? sala : throw new ArgumentException("La sala non può essere vuota.");
        }
    }
}
