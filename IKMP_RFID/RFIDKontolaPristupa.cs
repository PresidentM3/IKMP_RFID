using IKMP_RFID.Dijalog;
using IKMP_RFID.Klase;
using Npgsql;
using System.IO.Ports;
using System.Net.Sockets;
using System.Text;
using System.Timers;

namespace IKMP_RFID
{
    public partial class RFIDKontolaPristupa : Form
    {
        SerialPort _serialPort;
        SerialPort _serialPort2;
        TcpClient tCPclient;
        NetworkStream stream;
        private DateTime time_now;



        public RFIDKontolaPristupa()
        {
            InitializeComponent();
            initTimer();
            InitSerailPort();
            InitTCPIP();
        }

        private void initTimer()
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void InitSerailPort()
        {
            FrmSerial frmSerial = new FrmSerial();
            frmSerial.ShowDialog();
            try
            {
                _serialPort = new SerialPort(frmSerial.PortUlaz, 115200, Parity.None, 8, StopBits.One);
                _serialPort2 = new SerialPort(frmSerial.PortIzlaz, 9600, Parity.None, 8, StopBits.One);
                _serialPort.Open();
                _serialPort2.Open();
                _serialPort.DataReceived += SerialPort_DataReceived;
                _serialPort2.DataReceived += SerialPort2_DataReceived2;

                tCPclient = new TcpClient();
                tCPclient.Connect(frmSerial.IP, int.Parse(frmSerial.Port));

                stream = tCPclient.GetStream();

                byte[] data = Encoding.UTF8.GetBytes("Hello from rfid!" + "\r\n");
                stream.Write(data, 0, data.Length);

                print2list("Connected");


            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
  
            
        }

        private void InitTCPIP()
        {

        }

        private void SerialPort2_DataReceived2(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = _serialPort2.ReadLine();

            if (msg != null)
            {
                print2list(msg);
                izlazKontolaPristupa(msg);
                
            }
            

            
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = _serialPort.ReadLine();


            if (msg != null)
            {
                msg = msg.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
                msg = msg.TrimStart();
                ulazKontolaPristupa(msg);
                print2list(msg);
            }
      

        }

        private void ulazKontolaPristupa(string msg)
        {
            KorisniciDatabase korisniciDatabase = new KorisniciDatabase();
            Korisnik korisnik = korisniciDatabase.findUserFromID(msg);

            if (korisnik != null)
            {   
                if (korisnik.Tip_kartice == "povlascena")
                {
                    print2list("!!!!!!SLOBODAN ULAZ!!!!!!");
                }
                else if (korisnik.Tip_kartice == "obicna" && privjeraVremena())
                {
                    print2list("!!!!!!SLOBODAN ULAZ!!!!!!");
                }
                else if (korisnik.Tip_kartice == "obicna" && !privjeraVremena())
                {
                    print2list("!!!!!!ZABRANA!!!!!!");
                }


            }
            else
            {
                print2list("Kartica nije prinadjena u bazi.");
            }
            
        }

        private bool privjeraVremena()
        {
            TimeSpan start = new TimeSpan(7, 0, 0); //10 o'clock
            TimeSpan end = new TimeSpan(15, 0, 0); //12 o'cloc
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private void izlazKontolaPristupa(string msg)
        {
            KorisniciDatabase korisniciDatabase = new KorisniciDatabase();

            Korisnik korisnik = korisniciDatabase.findUserFromID(msg);

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
        private void prikazKorisniciBaze()
        {
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

        private void prikazEvidencijaBaze()
        {
            NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
            try
            {
                conn.Open();
                print2list("Konekcija otvorena...");
                string naredba = "SELECT rb, id_kartice, tip_kartice, ulaz_izlaz, ime, prezime, vrijeme, datum FROM public.evidencija ";
                NpgsqlCommand command = new NpgsqlCommand(naredba, conn);

                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {   
                    int rb = reader.GetInt32(0);
                    string id_kartice = reader.GetString(1); 
                    string tip_kartice = reader.GetString(2);
                    string ulaz_izlaz = reader.GetString(3);
                    string ime = reader.GetString(4);
                    string prezime = reader.GetString(5);
                    string vrijeme  = reader.GetString(6);
                    DateTime datum = reader.GetDateTime(7);
                    print2list($"{rb.ToString().PadLeft(10)} | {id_kartice.PadLeft(10)} | {tip_kartice.PadLeft(10)} | {ulaz_izlaz.PadLeft(5)} | {ime.PadLeft(5)} | {prezime.PadLeft(5)} | {datum.ToString()}");
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


        private void bntPrikazi_Click(object sender, EventArgs e)
        {
            clearList();
            prikazKorisniciBaze();
            //prikazEvidencijaBaze();


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
            //panelMain.Visible = true;
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
                    btnDodaj.Enabled = btnObrisi.Enabled = btnIzmjeni.Enabled = false;
                }

                loginToolStripMenuItem.Enabled = false;
            }
            else
            {
                panelMain.Visible = false;
            }
        }

        private void bntKraj_Click(object sender, EventArgs e)
        {
            YesNo yesNoDijalog = new YesNo();
            if (yesNoDijalog.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YesNo yesNoDijalog = new YesNo();
            if (yesNoDijalog.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            clearList();
        }

        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            string time = DateTime.Now.ToString("t");
            Console.WriteLine("The current time is {0}", time);
            labelTime.Text = time;
        }


        void timer_Tick(object sender, EventArgs e)
        {
            time_now = DateTime.Now;
            label1.Text = DateTime.Now.ToString("T");
            
        }

        private void sERIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSerial frmSerial = new FrmSerial();
            frmSerial.ShowDialog();
        }
    }
}