using IKMP_RFID.Dijalog;
using IKMP_RFID.Klase;
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

            if (rez == DialogResult.OK)
            {
                // ako je kliknuto obrisi, uradi INSERT INTO .....
                NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
                try
                {
                    conn.Open();
                    print2list("Konekcija otvorena...");
                    string naredba = $"DELETE FROM public.korisnici WHERE '{frmObrisi.PretragaKriterijum}' = '{frmObrisi.Unos}';";
                    NpgsqlCommand command = new NpgsqlCommand(naredba, conn);
                    int brRedova = command.ExecuteNonQuery();

                    if (brRedova >= 1)
                    {
                        print2list($"Korisnik obrisan");
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

        private void bntPrikazi_Click(object sender, EventArgs e)
        {
            clearList();
            NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
            try
            {
                conn.Open();
                print2list("Konekcija otvorena...");
                string naredba = "SELECT id_kartice, ime, prezime, tip_kartice, vazi_do FROM public.korisnici ";
                NpgsqlCommand command = new NpgsqlCommand(naredba, conn);

                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id_kartice = reader.GetString(0);
                    string ime = reader.GetString(1);
                    string prezime = reader.GetString(2);
                    string tip_kartice = reader.GetString(3);
                    DateTime vazi_do = reader.GetDateTime(4);
                    print2list($"{id_kartice.PadLeft(10)} | {ime.PadLeft(10)} | {prezime.PadLeft(10)} | {tip_kartice.PadLeft(5)} | {vazi_do.ToString().PadLeft(5)} ");
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

        private void clearList()
        {
            listBox1.Items.Clear();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            FrmIzmjeni frmIzmjeni = new();
            DialogResult rez = frmIzmjeni.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            FrmLogin frmLogin = new();
            int uloga;

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                LoginDatabase logindtb = new();
                uloga = logindtb.CheckAccessCredentials(frmLogin.UserName, frmLogin.Password);
                dozvoliPrikaz(uloga);
            }

        }
        private void dozvoliPrikaz(int uloga)
        {
            if (uloga > 0)
            {
                panelMain.Visible = true;

                if (uloga == 2)
                {
                    btnDodaj.Visible = btnObrisi.Visible = btnIzmjeni.Visible = false;
                }

                //loginToolStripMenuItem.Text = "Logout";
                loginToolStripMenuItem.Enabled = false;
            }
            else
            {
                panelMain.Visible = false;
            }
        }

    }
}