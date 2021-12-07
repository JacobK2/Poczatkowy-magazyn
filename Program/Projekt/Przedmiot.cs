using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Przedmiot
    {
        Pracownik pracownik;
        string nazwaPrzedmiotu;
        decimal waga;
        bool delikatny;
        static List<Przedmiot> listaWszystkichPrzedmiotów = new List<Przedmiot>();

        public Przedmiot(Pracownik pracownik)
        {
            this.pracownik = pracownik;
            pracownik.ListaPrzedmiotów.Add(this);
        }
        internal Pracownik Pracownik { get => pracownik; }
        public string NazwaPrzedmiotu { get => nazwaPrzedmiotu; set => nazwaPrzedmiotu = value; }
        public decimal Waga { get => waga; set => waga = value; }
        public bool Delikatny { get => delikatny; set => delikatny = value; }
        internal static List<Przedmiot> ListaWszystkichPrzedmiotów { get => listaWszystkichPrzedmiotów; }
        public object[] ObjTblPrzedmioty
        {
            get
            {
                string deli = "";
                if (Delikatny)
                    deli = "Tak";
                else
                    deli = "Nie";
                return new object[] { NazwaPrzedmiotu, Waga, Pracownik,deli };
            }
        }
    }
}
