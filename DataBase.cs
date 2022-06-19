using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetClub
{
    class DataBase // Работа с базой данных 
    {
        public bool ExecuteCommand(MySqlCommand command)
        {
            bool bl = true;
            try
            {
                Variables.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception x) { MessageBox.Show(x.ToString()); bl = false; }
            if (Variables.Connection.State == ConnectionState.Open)
                Variables.Connection.Close();
            return bl;
        }

        public void FillConnection(string server, string port, string database, string username, string password)
        {
            Variables.Connection = new MySqlConnection(@"Server = '" + server + "'; Port = '" + port + "'; Database = '" + database + "'; UserID = '" + username + "'; Password = '" + password + "'; CharSet=utf8");
        }

        public bool TestConnection()
        {
            bool success = true;
            try
            {
                Variables.Connection.Open();
            }
            catch
            {
                MessageBox.Show("Подключение неудалось.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            if (Variables.Connection.State == ConnectionState.Open)
                Variables.Connection.Close();
            return success;
        }

        public void SaveConnection(string server, string port, string database, string username, string password)
        {
            if (!(Directory.Exists(Path.GetDirectoryName(Variables.filepath))))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Variables.filepath));
                using (FileStream fs = File.Create(Variables.filepath)) { }
            }
            else if(!(File.Exists(Variables.filepath)))
                using (FileStream fs = File.Create(Variables.filepath)) { }
            try
            {
                using (FileStream fs = File.Open(Variables.filepath, FileMode.Open)) { fs.SetLength(0);}
                using (StreamWriter sw = new StreamWriter(Variables.filepath))
                {
                    sw.WriteLine(server);
                    sw.WriteLine(port);
                    sw.WriteLine(database);
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                }
            }
            catch
            {
                MessageBox.Show("Невозмжно получить доступ к файлу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadConnection(TextBox server, TextBox port, TextBox datebase, TextBox username, TextBox password)
        {
            if (File.Exists(Variables.filepath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Variables.filepath))
                    {
                        server.Text = sr.ReadLine();
                        port.Text = sr.ReadLine();
                        datebase.Text = sr.ReadLine();
                        username.Text = sr.ReadLine();
                        password.Text = sr.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно получить доступ к файлу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Файл сохранения не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void OpenDirectory()
        {
            if (Directory.Exists(Path.GetDirectoryName(Variables.filepath)))
                Process.Start(Path.GetDirectoryName(Variables.filepath));
            else
                MessageBox.Show("Файл сохранения не найдены.", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool AuthCheck(string login, string password)
        {
            DataTable result = Select("users", "*", "login = '" + login + "' AND password = '" + password + "' AND endbled = 1"); 
            if (result.Rows.Count == 1)
            {
                Variables.User.Fill(Convert.ToInt32(result.Rows[0][0]), result.Rows[0][2].ToString() + " " + result.Rows[0][3].ToString() + " " + result.Rows[0][4].ToString(), login, result.Rows[0][1].ToString());
                return true;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
                return false;
            }
        }

        public DataTable Selecting(string sql)
        {
            DataTable result = new DataTable();
            try
            {
                Variables.Connection.Open();
                MySqlCommand command = new MySqlCommand(sql, Variables.Connection);
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            if (Variables.Connection.State == ConnectionState.Open)
                Variables.Connection.Close();
            return result;
        }

        public DataTable Select(string table)
        {
            return Selecting("SELECT * FROM '" + table + "'");
        }
        public DataTable Select(string table, string attributes)
        {
            return Selecting("SELECT " + attributes + " FROM '" + table + "'");
        }
        public DataTable Select(string table, string attributes, string where)
        {
            return Selecting("SELECT " + attributes + " FROM " + table + " WHERE " + where);
        }

    }

    
    
}
