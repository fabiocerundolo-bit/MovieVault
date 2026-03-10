using System;

namespace GestioneCinema
{
    public class Attore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Nazione Nazionalita { get; set; }

        public Attore(string nome, string cognome, Nazione nazionalita = null)
        {
            Nome = nome;
            Cognome = cognome;
            Nazionalita = nazionalita;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}" + (Nazionalita != null ? $" ({Nazionalita})" : "");
        }
    }
}