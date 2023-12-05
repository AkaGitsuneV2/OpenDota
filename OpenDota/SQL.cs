using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OpenDota
{
    public static class SQL
    {
        public static string connectionString = "Server=localhost;Database=dota;User Id=root;Password=;";

        public static List<string> getListData(string command)
        {
            try
            {

                List<string> query = new List<string>();
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand mySqlCommand = new MySqlCommand(command, con))
                    {
                        using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                query.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                return query;

            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка чтения из базы данных!", "Ошибка", MessageBoxButton.OK);
                return null;
            }
        }

        public static void Execute(string command)
        {
            try
            {


                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand mySqlCommand = new MySqlCommand(command, con))
                    {
                        mySqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка чтения из базы данных!", "Ошибка", MessageBoxButton.OK);

            }
        }

        public static string getStringData(string command)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand mySqlCommand = new MySqlCommand(command, con))
                    {
                        using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return reader.GetString(0);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка чтения из базы данных!", "Ошибка", MessageBoxButton.OK);
                return null;
            }
        }

        public static Image getImageFromBinaryArray(string command)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand mySqlCommand = new MySqlCommand(command, con))
                    {
                        using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] byteData = (byte[])reader[0];
                                using (MemoryStream ms = new MemoryStream(byteData))
                                {
                                    Image returnImage = Image.FromStream(ms);
                                    return returnImage;
                                }
                               
                                
                            }
                        }
                    }
                }
                return null;

            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка чтения из базы данных!", "Ошибка", MessageBoxButton.OK);
                return null;
            }
        }


    }
}
