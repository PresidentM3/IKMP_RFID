using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMP_RFID.Klase
{
    internal class Korisnik
    {
        public Korisnik(string id_kartice, string ime, string prezime, string tip_kartice, DateTime vazi_do)
        {
            this.id_kartice = id_kartice;
            this.ime = ime; 
            this.prezime = prezime;
            this.tip_kartice = tip_kartice; 
            this.vazi_do = vazi_do;
            
        }

        private string id_kartice;
        private string ime;
        private string prezime;
        private string tip_kartice;
        private DateTime vazi_do;

        public DateTime VaziDo
        {
            get { return vazi_do; }
        }

        public string Tip_kartice
        {
            get { return tip_kartice; }
        }
        public string Prezime
        {
            get { return prezime; }
        }
        public string Ime
        {
            get { return ime; }
        }
        public string IdKartice
        {
            get { return id_kartice; }
        }


    }
}
