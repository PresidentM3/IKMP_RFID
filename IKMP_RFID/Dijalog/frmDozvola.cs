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
    public partial class FrmDozvola : Form
    {
        public string id_kartice;
        public FrmDozvola(string id_kartice, int uloga)
        {
            InitializeComponent();
            this.id_kartice = id_kartice;
            labeldKarticeTxt.Text = id_kartice;
            if (uloga < 111)
            {
                button2.Enabled = false;
            }
        }

        private bool dozvola;
        public bool Dozvola
        {
            get { return dozvola; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dozvola = true;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOdkazi_Click(object sender, EventArgs e)
        {
            dozvola = false;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
