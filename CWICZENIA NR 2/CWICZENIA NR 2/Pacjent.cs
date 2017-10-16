using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_2
{
    class Pacjent
    {
        public string imie;
        public string nazwisko;
        public int waga;
        public double wzrost;

        public double obliczWskaznik()
        {
            return waga / (wzrost * wzrost);
        }
    }
}
