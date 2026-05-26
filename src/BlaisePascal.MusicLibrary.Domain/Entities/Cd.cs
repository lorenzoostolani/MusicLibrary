using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.MusicLibrary.Domain.Entities
{
    public class Cd
    {
        public string Autore;
        public string Titolo;
        public List<Brano> Brani;
        public Cd(string titolo, string autore, List<Brano> brani)
        {
            
        }
        public string GetTitolo() => Titolo;
        public string GetAutore() => Autore;
        public void SetTitolo(string nuovoTitolo)
        {
            if (string.IsNullOrWhiteSpace(nuovoTitolo))
                throw new ArgumentException("Il titolo non può essere vuoto");
            Titolo = nuovoTitolo;
        }

        public void SetAutore(string nuovoAutore)
        {
            if (string.IsNullOrWhiteSpace(nuovoAutore))
                throw new ArgumentException("L'autore non può essere vuoto");
            Autore = nuovoAutore;
        }
        public override string ToString()
        {
            string nomiBrani = string.Empty;
            if (Brani != null) return string.Empty;
            foreach(var brano in Brani)
            {
                nomiBrani += brano.GetTitolo();
            }
            return nomiBrani;
        }
        public double Durata()
        {
            double durata = 0;
            foreach (var brano in Brani)
            {
                durata += brano.GetDurata();
            }
           return durata;
        }
    }
}
