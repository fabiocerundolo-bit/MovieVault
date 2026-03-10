using System;

namespace GestioneCinema
{
    public class Nazione
    {
        public string Nome { get; set; }

        public Nazione(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}