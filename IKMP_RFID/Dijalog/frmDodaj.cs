using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKMP_RFID.Dijalog
{
    public partial class FrmDodaj : Form
    {

        private string ime;
        private string prezime;
        private string idKartice;
        private string tipKorisnika;
        private DateTime vaziDo;

        public string Ime
        {
            get { return ime; }
        }
        public string Prezime
        {
            get { return prezime; }
        }
        public string IDKartice
        {
            get { return idKartice; }
        }

        public string TipKorisnika
        {
            get { return tipKorisnika; }    
        }

        public DateTime VaziDo
        {
            get { return vaziDo; }
        }

        public FrmDodaj()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text.Length == 0)
            {
                MessageBox.Show("Morate uneti ime");
                textBoxIme.Focus();
                return;
            }
            else if (textBoxPrezime.Text.Length == 0)
            {
                MessageBox.Show("Morate uneti prezime");
                textBoxPrezime.Focus();
                return;
            }
            else if (textBoxTipKorisnika.Text.Length == 0)
            {
                MessageBox.Show("Morate uneti tip korisnika");
                textBoxTipKorisnika.Focus();
                return;
            }
            else if (textBoxIDKartice.TextLength == 0)
            {
                MessageBox.Show("Morate uneti ID kartice");
                textBoxIDKartice.Focus();
                return;
            }

            ime = textBoxIme.Text;
            prezime = textBoxPrezime.Text;
            tipKorisnika = textBoxTipKorisnika.Text;   
            idKartice = textBoxIDKartice.Text;
            vaziDo = dateTimePickerVaziDo.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
