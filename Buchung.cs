using System;

namespace CCPTimer
{
    internal class Buchung
    {
        private string kunde;
        private string projekt;
        private string verrechnung;
        private DateTime now;

        public Buchung(string kundeString, string projektString, string verrechnungString, DateTime now)
        {
            this.kunde = kundeString;
            this.projekt = projektString;
            this.verrechnung = verrechnungString;
            this.now = now;
        }

        public string GetKunde()
        {
            return kunde;
        }
        public string GetProjekt()
        {
            return projekt;
        }
        public string GetVerrechnung()
        {
            return verrechnung;
        }

        public DateTime GetTimeStamp()
        {
            return now;
        }
    }
}