using System;

namespace GestioneCinema
{
    public class Localita
    {
        public string Nome { get; set; }
        public Nazione Nazione { get; set; }

        public Localita(string nome, Nazione nazione = null)
        {
            Nome = nome;
            Nazione = nazione;
        }

        public override string ToString()
        {
            return Nome + (Nazione != null ? $", {Nazione}" : "");
        }
    }
}