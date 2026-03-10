using System;

namespace GestioneCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creazione nazioni
            Nazione italia = new Nazione("Italia");
            Nazione francia = new Nazione("Francia");
            Nazione usa = new Nazione("Stati Uniti");

            // Creazione località
            Localita roma = new Localita("Roma", italia);
            Localita parigi = new Localita("Parigi", francia);
            Localita newYork = new Localita("New York", usa);

            // Creazione regista
            Regista tarantino = new Regista("Quentin", "Tarantino", usa);

            // Creazione attori
            Attore travolta = new Attore("John", "Travolta", usa);
            Attore jackson = new Attore("Samuel L.", "Jackson", usa);
            Attore thurman = new Attore("Uma", "Thurman", usa);

            // Creazione film
            Film pulpFiction = new Film("Pulp Fiction", 1994);
            pulpFiction.Regista = tarantino;
            pulpFiction.NazioneProduzione = usa;
            pulpFiction.AggiungiAttore(travolta);
            pulpFiction.AggiungiAttore(jackson);
            pulpFiction.AggiungiAttore(thurman);
            pulpFiction.AggiungiLocation(newYork);
            pulpFiction.AggiungiLocation(roma); // solo per esempio

            // Produciamo la stringa completa con tutte le informazioni del film
            // che include automaticamente i dettagli di regista, attori, nazioni e località collegate
            string risultato = pulpFiction.ToString();

            // Aggiungiamo anche informazioni su altre nazioni/località non direttamente nel film
            risultato += $"\nAltre nazioni presenti nel database: {italia}, {francia}\n";
            risultato += $"Altre località: {parigi}";

            Console.WriteLine(risultato);
        }
    }
}