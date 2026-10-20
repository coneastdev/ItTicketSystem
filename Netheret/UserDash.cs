using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Netheret
{
    public partial class UserDash : Form
    {
        string Email;
        public UserDash(string email)
        {
            Email = email;
            InitializeComponent();
            refreshTickets();
        }

        private static string getUserId(string email)
        {
            try
            {
                using var connection = new SqliteConnection("Data Source=database.db");
                connection.Open();

                string query = "SELECT * FROM Users WHERE email = @email";

                using var command = new SqliteCommand(query, connection);

                command.Parameters.AddWithValue("@email", email);

                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
                else
                {
                    return "null";
                }
            }
            catch (SqliteException e)
            {
                Debug.WriteLine(e.Message);
            }
            return "null";
        }

        private void refreshTickets()
        {
            try
            {
                using var connection = new SqliteConnection("Data Source=database.db");
                connection.Open();
                string query = "SELECT * FROM Tickets WHERE user_id = @user_id";
                using var command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@user_id", getUserId(Email));
                using var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    lbTickets.Items.Clear();
                    while (reader.Read())
                    {
                        var ticketId = reader.GetInt64(0);
                        var userId = reader.GetInt64(1);
                        var open = reader.GetBoolean(2);
                        var issueType = reader.GetInt64(3);
                        var status = reader.GetInt64(4);
                        var priority = reader.GetInt64(5);
                        var severity = reader.GetInt64(6);
                        var impact = reader.GetInt64(7);
                        var content = reader.GetString(8);
                        var location = reader.GetString(9);
                        var area = reader.GetString(10);
                        var dateSent = reader.GetDateTime(11);
                        string dateAssigned = "Not Assigned";
                        string dateRecived = "Unresolved";
                        try
                        {
                            dateAssigned = reader.GetDateTime(12).ToString();
                            dateRecived = reader.GetDateTime(13).ToString();
                        }
                        catch
                        {
                            Debug.WriteLine("Missing dates");
                        }

                        lbTickets.Items.Add($"Ticket ID: {ticketId}, User ID: {userId}, Open: {open}, Issue Type: {issueType}, Status: {status}, Priority: {priority}, Severity: {severity}, Impact: {impact}, Content: {content}, Location: {location}, Area: {area}, Date Sent: {dateSent}, Date Assigned: {dateAssigned}, Date Received: {dateRecived}");
                    }
                }
            }
            catch (SqliteException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private static bool add_ticket(string userId, int issueType, int severity, int impact, string issueDescription, string location, string area)
        {
            try
            {
                string query = $"INSERT INTO Tickets (user_id, open, status, issue_type, priority, severity, impact, content, location, area, date_sent) VALUES (@user_id, @open, @status, @issue_type, @priority, @severity, @impact, @content, @location, @area, @date_sent)";

                using (var connection = new SqliteConnection("Data Source=database.db"))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Add parameters properly using AddWithValue
                        command.Parameters.AddWithValue("@user_id", userId);
                        command.Parameters.AddWithValue("@open", true);
                        command.Parameters.AddWithValue("@status", 0);
                        command.Parameters.AddWithValue("@issue_type", issueType);
                        command.Parameters.AddWithValue("@priority", severity + impact);
                        command.Parameters.AddWithValue("@severity", severity);
                        command.Parameters.AddWithValue("@impact", impact);
                        command.Parameters.AddWithValue("@content", issueDescription);
                        command.Parameters.AddWithValue("@location", location);
                        command.Parameters.AddWithValue("@area", area);
                        command.Parameters.AddWithValue("@date_sent", DateTime.Now);

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitIssue_Click(object sender, EventArgs e)
        {
            int issueType = cbIssueType.SelectedIndex;
            int severity = cbSeverity.SelectedIndex + 1;
            int impact = cbImpact.SelectedIndex + 1;

            string issueDescription = txtIssueDescription.Text;
            string location = txtLocation.Text;
            string area = txtArea.Text;

            string userId = getUserId(Email);

            if (userId != "null")
            {
                add_ticket(userId, issueType, severity, impact, issueDescription, location, area);
                refreshTickets();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshTickets();
        }
    }
}
