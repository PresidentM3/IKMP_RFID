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

        private void comboBoxPretraga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPretraga.ValueMember == "Prezime")
            {
                RFIDKontolaPristupa f1 = new();
                f1.print2list("Prezime za obrisati");
            }
        }
    }
}
