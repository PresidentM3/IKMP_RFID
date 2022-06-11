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
    public partial class FormObrisi : Form
    {
        public FormObrisi()
        {
            InitializeComponent();
        }

        private string pretragaKriterijum;

        public string PretragaKriterijum
        {
            get { return pretragaKriterijum; }
        }

        private string unos;
        public string Unos
        { 
            get { return unos; } 

        }


        private void comboBoxPretra_DropDownClosed(object sender, EventArgs e)
        {

            pretragaKriterijum = (string)comboBoxPretraga.SelectedItem;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUnos.Text.Length > 0) 
            {
                unos = textBoxUnos.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Unos prazan!");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
