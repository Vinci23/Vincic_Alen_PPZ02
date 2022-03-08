using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincic_Alen_PPZ02
{
    internal class Pica
    {
        string naziv, pakiranje, cijena,kolicina,postotak;

        public Pica(string naziv, string pakiranje, string cijena, string kolicina)
        {
            this.naziv = naziv;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
            this.kolicina = kolicina;
            
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public string Cijena { get => cijena; set => cijena = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public override string ToString()
        {
            String ispis = "Naziv: " + this.Naziv + "\nPakiranje: " + this.Pakiranje + "\nCijena: " + this.Cijena + "\nKolicina: " + this.Kolicina;
            return ispis;
        }

    }

    class Gazirana : Pica
    {
        public Gazirana(string naziv, string pakiranje, string cijena, string kolicina) : base(naziv, pakiranje, cijena, kolicina)
        {

        }
        public override string ToString()
        {
            String ispis = "Naziv: " + this.Naziv + "\nPakiranje: " + this.Pakiranje + "\nCijena: " + this.Cijena + "\nKolicina: " + this.Kolicina;
            return ispis;
        }
    }

    class Negazirana : Pica
    {
        public Negazirana(string naziv, string pakiranje, string cijena, string kolicina) : base(naziv, pakiranje, cijena, kolicina)
        {

        }
        public override string ToString()
        {
            String ispis = "Naziv: " + this.Naziv + "\nPakiranje: " + this.Pakiranje + "\nCijena: " + this.Cijena + "\nKolicina: " + this.Kolicina;
            return ispis;
        }

    }
    class Alkoholna : Pica
    {
        string postotak;

        public Alkoholna(string naziv, string pakiranje, string cijena, string kolicina,string postotak) : base(naziv, pakiranje, cijena, kolicina)
        {
        }

        public string Postotak { get => postotak; set => postotak = value; }

        public override string ToString()
        {
            String ispis= "Naziv: " + this.Naziv + "\nPakiranje: " + this.Pakiranje + "\nCijena: " + this.Cijena + "\nKolicina: " + this.Kolicina+ "Postotak: " + this.Postotak + "%";
            return ispis;
        }
    }
}
