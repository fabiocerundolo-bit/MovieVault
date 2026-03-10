using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneCinema
{
    public class Film
    {
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public Regista Regista { get; set; }
        public List<Attore> Attori { get; private set; } = new List<Attore>();
        public Nazione NazioneProduzione { get; set; }
        public List<Localita> Location { get; private set; } = new List<Localita>();

        public Film(string titolo, int anno)
        {
            Titolo = titolo;
            Anno = anno;
        }

        public void AggiungiAttore(Attore attore)
        {
            Attori.Add(attore);
        }

        public void AggiungiLocation(Localita localita)
        {
            Location.Add(localita);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Film: {Titolo} ({Anno})");
            
            if (Regista != null)
                sb.AppendLine($"Regista: {Regista}");
            
            if (NazioneProduzione != null)
                sb.AppendLine($"Nazione di produzione: {NazioneProduzione}");
            
            if (Attori.Count > 0)
            {
                sb.AppendLine("Attori:");
                foreach (var attore in Attori)
                    sb.AppendLine($"  - {attore}");
            }
            
            if (Location.Count > 0)
            {
                sb.AppendLine("Location:");
                foreach (var loc in Location)
                    sb.AppendLine($"  - {loc}");
            }
            
            return sb.ToString();
        }
    }
}