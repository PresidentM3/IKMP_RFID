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
    public partial class FrmLogin : Form
    {
        private string userName;
        private string password;

        public string UserName
        {
            get { return userName; }
        }
        public string Password
        {
            get { return password; }
        }


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            password = txtSifra.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
