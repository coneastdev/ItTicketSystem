using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.DataFormats;

namespace Netheret
{
    public partial class Login : Form
    {
        private const string SALT = "7fd0ff24c5af99ae8842814eb993d7dc9e419b52710392961356edfeb2281e56";

        public Login()
        {
            InitializeComponent();
        }

        private static string compute_hash(string sourceData)
        {
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(sourceData);
            tmpHash = MD5.HashData(tmpSource);

            if (tmpHash != null)
            {
                static string ByteArrayToString(byte[] arrInput)
                {
                    int i;
                    StringBuilder sOutput = new StringBuilder(arrInput.Length);
                    for (i = 0; i < arrInput.Length; i++)
                    {
                        sOutput.Append(arrInput[i].ToString("X2"));
                    }
                    return sOutput.ToString();
                }

                return ByteArrayToString(tmpHash);
            }
            else
            {
                return "";
            }
        }

        private static string check_user_data(string email, string password)
        {
            
            try
            {
                using var connection = new SqliteConnection("Data Source=database.db");
                connection.Open();

                // 1. Change this line to use a parameter (@email) instead of {}
                string query = "SELECT * FROM Users WHERE email = @email";

                using var command = new SqliteCommand(query, connection);

                // 2. Add the parameter value safely
                command.Parameters.AddWithValue("@email", email);

                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        // Note: column indexes start at 0. If password is your 3rd column, use reader.GetString(2)
                        var dbPassword = reader.GetString(2);
                        var userPassword = compute_hash(password + email + SALT);

                        if (userPassword == dbPassword)
                        {
                            return "valid details";
                        }
                        else
                        {
                            Debug.WriteLine(dbPassword);
                            Debug.WriteLine(userPassword);
                            return "invalid password";
                        }
                    }
                }
                else
                {
                    return "invalid email";
                }
            }
            catch (SqliteException e)
            {
                Debug.WriteLine(e.Message);
            }
            return "error";
        }

        private static bool add_user(string email, string password)
        {
            try
            {
                string query = $"INSERT INTO Users (email, password) VALUES (@email, @password)";

                using (var connection = new SqliteConnection("Data Source=database.db"))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameters properly using AddWithValue
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", compute_hash(password + email + SALT));

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                return true;
            }
            catch (SqliteException e)
            {
                Debug.WriteLine(e.Message);
            }
            return false;
        }

        private static bool emailValid(string email)
        {
            Regex re = new Regex("[^\\s@]+@[^\\s@]+\\.[^\\s@]+");
            if (re.IsMatch(email))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your email is not formated corectly.");
                return false;
            }
        }

        private static bool passwordValid(string password)
        {
            Regex re = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            if (re.IsMatch(password))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your password must contain 8 characters, one capital, one lower case and one number.");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get deatils
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

            // check user deatils are valid
            if (email != null || password != null)
            {
                switch (check_user_data(email, password))
                {
                    case "valid details":
                        Debug.WriteLine("Valid account");
                        UserDash dash = new UserDash(email);
                        dash.Show();
                        this.Hide();
                        dash.FormClosed += (s, args) => this.Close();
                        break;
                    case "invalid password":
                        Debug.WriteLine("Invalid password");
                        break;
                    case "invalid email":
                        Debug.WriteLine("Invalid email");
                        break;
                    case "error":
                        Debug.WriteLine("error");
                        break;
                    default:
                        Debug.WriteLine("ERROR: Failed to comapre entry data to db");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR: Invalid data entry");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get deatils
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

            // check user deatils are valid
            if (email != null && password != null)
            {
                if (emailValid(email) == true && passwordValid(password) == true)
                {
                    switch (check_user_data(email, password))
                    {
                        case "valid details":
                            Debug.WriteLine("Account already exists");
                            break;
                        case "invalid password":
                            Debug.WriteLine("Account alredy exists");
                            break;
                        case "invalid email":
                            Debug.WriteLine("Account does not exist");
                            if (add_user(email, password) == true)
                            {
                                Debug.WriteLine("Users added");
                                button1_Click(sender, e);
                            }
                            else
                            {
                                Debug.WriteLine("User was not added");
                            }
                            break;
                        case "error":
                            Debug.WriteLine("error");
                            break;
                        default:
                            Debug.WriteLine("ERROR: Failed to comapre entry data to db");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid data entry");
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !TxtPassword.UseSystemPasswordChar;
        }
    }
}
