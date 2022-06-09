using IKMP_RFID.Dijalog;
using Npgsql;
using System.IO.Ports;

namespace IKMP_RFID
{
    public partial class RFIDKontolaPristupa : Form
    {
        SerialPort _serialPort;

        public RFIDKontolaPristupa()
        {
            InitializeComponent();
            InitSerailPort();
        }

        private void InitSerailPort()
        {
            try
            {
                _serialPort = new SerialPort("COM17", 9600, Parity.None, 8, StopBits.One);
                _serialPort.Open();
                _serialPort.DataReceived += SerialPort_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = _serialPort.ReadLine();
            print2list(msg);

        }


        public void print2list(string poruka)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    //listBox1.Items.Add("InvokeRequired");
                    listBox1.Items.Add(poruka);
                }));
            }
            else
            {
                listBox1.Items.Add(poruka);
            }


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            FrmDodaj frmDodaj = new FrmDodaj();
            DialogResult rez = frmDodaj.ShowDialog();
            if (rez == DialogResult.OK)
            {
                // ako je kliknuo ok, uradi INSERT INTO .....
                NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
                try
                {
                    // regularni kod
                    conn.Open();
                    string naredba = $"INSERT INTO public.korisnici(ID_kartice, ime, prezime, tip_kartice, vazi_do) VALUES " +
                        $"('{frmDodaj.IDKartice}', '{frmDodaj.Ime}', '{frmDodaj.Prezime}', '{frmDodaj.TipKorisnika}', '{frmDodaj.VaziDo.ToString("yyyy-MM-dd")}');";
                    NpgsqlCommand command = new NpgsqlCommand(naredba, conn);
                    int brRedova = command.ExecuteNonQuery();

                    if (brRedova >= 1)
                    {
                        print2list($"Korisnik id: {frmDodaj.IDKartice} je dodat");
                    }
                    else
                    {
                        print2list("Korisnik nije pronadjen");
                    }
                }
                catch (Exception ex)
                {
                    // obrada greske
                    print2list(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            FormObrisi frmObrisi = new();
            DialogResult rez = frmObrisi.ShowDialog();

        }
    }
}