using Npgsql;
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
    public partial class FrmIzmjeni : Form
    {

        private NpgsqlConnection conn;
        private NpgsqlCommand command;
        private NpgsqlDataReader reader;

        public FrmIzmjeni()
        {
            InitializeComponent();
            loadComboBox();

        }

        private string pretragaUnos;
        private string kriterijumIzmjena;
        private string unos;

        private void loadComboBox()
        {
            comboBoxKorisnik.Items.Clear();

            NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
            try
            {
                conn.Open();
                string naredba = "SELECT id_kartice, ime, prezime, tip_kartice, vazi_do FROM public.korisnici ";
                NpgsqlCommand command = new NpgsqlCommand(naredba, conn);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxKorisnik.Items.Add(reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                // obrada greske
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void comboBoxKorisnik_DropDownClosed(object sender, EventArgs e)
        {
            pretragaUnos = (string)comboBoxKorisnik.SelectedItem;
            NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
            try
            {
                conn.Open();
                string naredba = $"SELECT id_kartice, ime, prezime, tip_kartice, vazi_do FROM public.korisnici WHERE ime = '{pretragaUnos}';";
                NpgsqlCommand command = new NpgsqlCommand(naredba, conn);

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string id_kartice = reader.GetString(0);
                    string ime = reader.GetString(1);
                    string prezime = reader.GetString(2);
                    string tip_kartice = reader.GetString(3);
                    DateTime vazi_do = reader.GetDateTime(4);
                    labelKorisnik.Text = id_kartice + "|" + ime + "|" + prezime + "|" + tip_kartice + "|" + (string)vazi_do.ToString();
                }

            }
            catch (Exception ex)
            {
                // obrada greske
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void buttonOdkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {
            kriterijumIzmjena = (string)comboBoxIzmjena.SelectedItem;
            unos = textBoxUnos.Text;

            if (unos.Length > 0)
            {
                NpgsqlConnection conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
                try
                {
                    conn.Open();
                    string naredba = $"UPDATE public.korisnici SET {kriterijumIzmjena} = '{unos}' WHERE ime = '{pretragaUnos}';";
                    NpgsqlCommand command = new NpgsqlCommand(naredba, conn);
                    int brRedova = command.ExecuteNonQuery();

                    if (brRedova >= 1)
                    {
                        MessageBox.Show("Izmjena uspjesna");
                    }
                    else
                    {
                        MessageBox.Show("Greska");
                    }
                    //clear combobox and textbox
                    comboBoxKorisnik.SelectedIndex = -1;
                    textBoxUnos.Clear();
                }
                catch (Exception ex)
                {
                    // obrada greske
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Unos prazan!");
            }
        }

        private void comboBoxKorisnik_Click(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void FrmIzmjeni_Load(object sender, EventArgs e)
        {

        }
    }
}
