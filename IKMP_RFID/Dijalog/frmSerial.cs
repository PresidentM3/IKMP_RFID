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
    public partial class FrmSerial : Form
    {
        private bool serialFrmClosed;

        public FrmSerial()
        {
            InitializeComponent();

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                comboBoxUlaz.Items.Add(ports[i]);
                comboBoxIzlaz.Items.Add(ports[i]);
                if (ports[i] == "COM9")
                {
                    comboBoxUlaz.SelectedIndex =i;
                    //comboBoxIzlaz.DisplayMember = ports[i];
                }
                else if (ports[i] == "COM23")
                {
                    comboBoxIzlaz.SelectedIndex = i;
                    //comboBoxIzlaz.DisplayMember = ports[i];
                } 
            }
            //comboBoxUlaz.SelectedIndex = 0;
            //comboBoxIzlaz.SelectedIndex = 0;
        }

        public string PortUlaz { get; set; }
        public string PortIzlaz { get; set; }

        public string IP { get; set; }
        public string Port { get; set; }

        public bool SerialFrmClosed
        {
            get { return serialFrmClosed; }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            PortUlaz = comboBoxUlaz.SelectedItem.ToString();
            PortIzlaz = comboBoxIzlaz.SelectedItem.ToString(); ;
            IP = textBoxIP.Text;
            Port = textBoxPort.Text;
            serialFrmClosed = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {

        }
    }
}
