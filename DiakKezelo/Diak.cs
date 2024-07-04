using System;

namespace DiakKezelo {
    public class Diak {
        private string nev;
        private string szak;
        private int szuletesiEv;

        public string Nev => nev;
        public string Szak => szak;
        public int SzuletesiEv => szuletesiEv;
        public string NevEsSzak => $"{Nev} ({Szak})";
        public int Kor => DateTime.Now.Year - szuletesiEv;

        public Diak(string nev, string szak, int szuletesiEv)
        {
            this.nev = nev;
            this.szak = szak;
            this.szuletesiEv = szuletesiEv;
        }

        public override string ToString()
        {
            return $"{nev}({szak}), szül. éve: {szuletesiEv})";
        }
    }
}