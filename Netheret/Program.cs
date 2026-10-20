using Microsoft.Data.Sqlite;

namespace Netheret
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                using var connection = new SqliteConnection("Data Source=database.db");
                connection.Open();

                // force foreign keys
                string query = @"
                    PRAGMA foreign_keys = ON;
                ";

                using var enforceForeignKeys = new SqliteCommand(query, connection);
                enforceForeignKeys.ExecuteNonQuery();

                // create users table
                query = @"CREATE TABLE IF NOT EXISTS Users (
	                user_id INTEGER PRIMARY KEY AUTOINCREMENT,
   	                email varchar(255) NOT NULL,
	                password varchar(255) NOT NULL
                )";

                using var createUsers = new SqliteCommand(query, connection);
                createUsers.ExecuteNonQuery();

                // create tickets table
                query = @"CREATE TABLE IF NOT EXISTS Tickets (
                    ticket_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL,
                    open INTEGER NOT NULL,
                    issue_type INTEGER NOT NULL,
                    status INTEGER NOT NULL,
                    priority INTEGER NOT NULL,
                    severity INTEGER NOT NULL,
                    impact INTEGER NOT NULL,
                    content TEXT NOT NULL,
                    location TEXT NOT NULL,
                    area TEXT NOT NULL,
                    date_sent VARCHAR(255),
                    date_asigned VARCHAR(255),
                    date_resolved VARCHAR(255),
                    FOREIGN KEY (user_id) REFERENCES Users(user_id) 
                );";

                using var createTicket = new SqliteCommand(query, connection);
                createTicket.ExecuteNonQuery();

                connection.Close();
            }
            catch (SqliteException e)
            {
                Console.WriteLine(e.Message);
            }

            Application.Run(new Login());
        }
    }
}