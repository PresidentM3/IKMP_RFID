using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMP_RFID.Klase
{
    internal class KorisniciDatabase
    {
        NpgsqlConnection conn;

        public KorisniciDatabase()
        {
            conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
        }


        public Korisnik? findUserFromID(string card_id)
        {
            
            try
            {
                conn.Open();
                string naredba = $"SELECT id_kartice, ime, prezime, tip_kartice, vazi_do FROM public.korisnici WHERE id_kartice = '{card_id}';";
                NpgsqlCommand command = new NpgsqlCommand(naredba, conn);

                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();
                
                string id_kartice = reader.GetString(0);
                string ime = reader.GetString(1);
                string prezime = reader.GetString(2);
                string tip_kartice = reader.GetString(3);
                DateTime vazi_do = reader.GetDateTime(4);

                Korisnik korsinik = new Korisnik(id_kartice, ime, prezime, tip_kartice, vazi_do);

                return korsinik;
                

            }
            catch (Exception ex)
            {
                // obrada greske
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        //public string displayDatabase()
        //{
        //    string prikaz;
        //    try
        //    {
        //        conn.Open();
        //        string naredba = "SELECT id_kartice, ime, prezime, tip_kartice, vazi_do FROM public.korisnici ";
        //        NpgsqlCommand command = new NpgsqlCommand(naredba, conn);

            //        NpgsqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            string id_kartice = reader.GetString(0);
            //            string ime = reader.GetString(1);
            //            string prezime = reader.GetString(2);
            //            string tip_kartice = reader.GetString(3);
            //            DateTime vazi_do = reader.GetDateTime(4);
            //            prikaz = ($"{id_kartice.PadLeft(10)} | {ime.PadLeft(10)} | {prezime.PadLeft(10)} | {tip_kartice.PadLeft(5)} | {vazi_do.ToString().PadLeft(5)} ");

            //            return prikaz;
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        // obrada greske
            //        print2list(ex.Message);
            //    }
            //    finally
            //    {
            //        conn.Close();
            //        conn.Dispose();
            //    }
            //}



        }
}
