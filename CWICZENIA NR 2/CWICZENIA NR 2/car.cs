using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWICZENIA_NR_2
{
    class car
    {
        //modyfikatory dostepu
        //public - publiczny
        //private - prywatny, niedostepny dla innych klas
        //internal - "w ramach projektu"
        //protected - "dla klas potomnych"

        //mod typ nazwaPola
        //poleZmienna = nazwaZmiennej
        //klasa Nazwa = class Nazwa

        public string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double srednieSpalanie;

        public void UstawRokProdukcji(int rok)
        {
           this.rokProdukcji = rok;
        }

        public string Info()
        {
            return marka + " " + rokProdukcji;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }
        public double ObliczKosztPaliwa(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

    }
}
