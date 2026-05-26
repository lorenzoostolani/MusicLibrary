using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.MusicLibrary.Domain.Entities
{
    public class Brano
    {

        private string titolo;
        private string autore;
        private double durata; // in secondi


        public Brano(string titolo, string autore, double durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }


        public string GetTitolo() => titolo;
        public string GetAutore() => autore;
        public double GetDurata() => durata;

        public void SetTitolo(string nuovoTitolo)
        {
            if (string.IsNullOrWhiteSpace(nuovoTitolo))
                throw new ArgumentException("Il titolo non può essere vuoto");
            titolo = nuovoTitolo;
        }

        public void SetAutore(string nuovoAutore)
        {
            if (string.IsNullOrWhiteSpace(nuovoAutore))
                throw new ArgumentException("L'autore non può essere vuoto");
            autore = nuovoAutore;
        }

        public void SetDurata(double nuovaDurata)
        {
            if (nuovaDurata <= 0)
                throw new ArgumentException("La durata deve essere magggiore di 0");
            durata = nuovaDurata;
        }


        public override string ToString()
        {
            int minuti = (int)(durata / 60);
            int secondi = (int)(durata % 60);
            return $"[Brano] Titolo: \"{titolo}\" | Autore: {autore} | Durata: {minuti}:{secondi:D2}";
        }

        public bool ShortSong(double soglia)
        {
            return durata < soglia;
        }
    }

}
