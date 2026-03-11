using System;
using System.Text.RegularExpressions;

namespace GestioneStudenti;

public class Studente
{
    private string nome;
    private string cognome;
    private int eta;

    public Studente(string nome, string cognome, int eta)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
    }

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Il nome non può essere vuoto o composto solo da spazi.");
            // Opzionale: solo lettere e spazi
            if (!Regex.IsMatch(value, @"^[a-zA-ZàèéìòùÀÈÉÌÒÙ\s]+$"))
                throw new ArgumentException("Il nome può contenere solo lettere e spazi.");
            nome = value.Trim(); // Rimuove spazi iniziali/finali
        }
    }

    public string Cognome
    {
        get { return cognome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Il cognome non può essere vuoto o composto solo da spazi.");
            if (!Regex.IsMatch(value, @"^[a-zA-ZàèéìòùÀÈÉÌÒÙ\s]+$"))
                throw new ArgumentException("Il cognome può contenere solo lettere e spazi.");
            cognome = value.Trim();
        }
    }

    public int Eta
    {
        get { return eta; }
        set
        {
            if (value < 0 || value > 120)
                throw new ArgumentOutOfRangeException(nameof(value), "L'età deve essere compresa tra 0 e 120.");
            eta = value;
        }
    }
}