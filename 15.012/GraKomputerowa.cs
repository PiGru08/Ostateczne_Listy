using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._012
{

    public class GraKomputerowa
    {
       public static int wszystkieGry { get; set; }
        private string _nazwa;
        public string Nazwa
        {
            get { return _nazwa; }
            set { _nazwa = value; }
        }


        //public string Nazwa { get; set; }
        public string Gatunek { get; set; }
        public int Wiek { get; set; }

        public bool Multiplayer { get; set; }
        public int id { get; set; }
        public GraKomputerowa(string nazwa, string gatunek, int wiek, bool multiplayer)
        {
            Nazwa = nazwa;
            Gatunek = gatunek;
            Wiek = wiek;
            Multiplayer = multiplayer;
            id = wszystkieGry;
            wszystkieGry++;

            
           
        }
    }
}
