using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMP_RFID.Klase
{
    internal class LoginDatabase
    {
        NpgsqlConnection conn;
        public LoginDatabase()
        {
             conn = new NpgsqlConnection($"Host = localhost; Port = 5432; Username = postgres; Password = 14235; Database = postgres");
        }

        public int CheckAccessCredentials(string userName, string password)
        {
            try
            {
                // regularni kod
                conn.Open();
                int uloga = -1;

                string naredba = $"SELECT uloga FROM login WHERE username = '{userName}' and password = '{password}'";
                NpgsqlCommand command = new NpgsqlCommand(naredba, conn);

                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    uloga = reader.GetInt32(0);
                }
                return uloga;

            }
            catch (Exception ex)
            {
                // obrada greske
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
                conn.Dispose(); 
            }

            
        }

    }

   


}
