using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_2
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public int ObliczWiek()
        {
            return 2017 - rokUrodzenia;
        }
        public string Info()
        {
            if (plec == "K")
            {
                return "Dyrektorem jest Pani " + imie + " " + nazwisko;
            }
            else
            {
                return "Dyrektorem jest Pan " + imie + " " + nazwisko;
            }
        }

        //Cwiczenie 16 
        public int ObliczWiek2()
        {
            return  DateTime.Now.Year - rokUrodzenia;
        }
    }
}
