using System.Collections.Generic;

namespace CCPTimer
{
    internal class Kunde
    {
        private readonly string name;
        private readonly List<Projekt> projektListe;

        public Kunde(string name, List<Projekt> projektListe)
        {
            this.name = name;
            this.projektListe = projektListe;
        }

        public List<Projekt> GetProjekte()
        {
            return projektListe;
        }

        public string GetName()
        {
            return name;
        }
    }
}