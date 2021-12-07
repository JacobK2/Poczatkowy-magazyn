using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Pracownik
    {
        List<Przedmiot> listaPrzedmiotów = new List<Przedmiot>();
        static List<Pracownik> listaPracowników = new List<Pracownik>();
        string imie, nazwisko;
        int wiek;
        bool doświadczenie;
        
        internal List<Przedmiot> ListaPrzedmiotów
        {
            get
            {
                return listaPrzedmiotów;
            }
        }
        internal static List<Pracownik> ListaPracowników { get => listaPracowników; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public bool Doświadczenie { get => doświadczenie; set => doświadczenie = value; }
        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }
        int liczbaPrzedmiotów
        {
            get
            {
                int liczbaPrzedmiotów = 0;
                foreach (Przedmiot p in listaPrzedmiotów)
                    liczbaPrzedmiotów++;
                return liczbaPrzedmiotów;
            }
        }
        decimal Premia
        {
            get
            {
                decimal premia = 0;
                foreach (Przedmiot p in listaPrzedmiotów)
                {
                    if (p.Waga>50)
                    {
                        premia += 2;
                    }
                    if (p.Delikatny)
                    {
                        premia += 3;
                    }

                }
                if (liczbaPrzedmiotów>15)
                {
                    premia += 5;
                }
                if (Doświadczenie)
                {
                    premia = premia * 1.1M;
                }
                return premia;

            }
        }
        public object [] ObjTblPracownicy
        {
            get
            {
                string dośw = "";
                if (Doświadczenie)
                    dośw = "Tak";
                else
                    dośw = "Nie";
                return new object[] { Imie, Nazwisko, Wiek, dośw, liczbaPrzedmiotów, Premia.ToString("0.00")+" zł" };
            }
        }
    }

}
