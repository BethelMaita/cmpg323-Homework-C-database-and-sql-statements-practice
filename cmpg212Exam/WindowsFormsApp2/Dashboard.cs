using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bethel\Documents\cmpg212 exam\final exam\31709974_BZvomuno_cmpg212Exam\WindowsFormsApp2\User.mdf"";Integrated Security=True";

        private bool CheckUserPremiumStatus(string email)
        {
            bool isPremium =true;

            // Query the database to check the user's premium status
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Membership FROM [User] WHERE Email = @Email";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string membership = result.ToString();
                        // Assuming "Premium" indicates premium membership
                        if (membership == "Premium")
                        {
                            isPremium = true;
                        }
                        else
                            isPremium= false;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }

            return isPremium;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            // Retrieve user information from the database
            string userEmail = txtEnteredEmail.Text; 
            bool isPremium = CheckUserPremiumStatus(userEmail);

            // Hide the TabPage based on the user's premium status
            if (!isPremium)
            {
                tabControl1.TabPages.Remove(tabPage2); // Hide the tabPage2

            }
        }

        private DataTable GetUserInformation(string email)
        {
            DataTable userTable = new DataTable();

            // Query the database to retrieve user information from the "User" table for the specified email
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT FirstName, LastName, Email, PhoneNo, Password, Membership FROM [User] WHERE Email = @Email";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(userTable);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }

            return userTable;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Clear the existing items in the ListBox
            listBox1.Items.Clear();

            // Retrieve the entered email
            string userEmail = txtEnteredEmail.Text;

            // Retrieve user information from the "User" table for the specified email
            DataTable userTable = GetUserInformation(userEmail);

            // Display the user information in the ListBox
            foreach (DataRow row in userTable.Rows)
            {
                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();
                string email = row["Email"].ToString();
                string phoneNo = row["PhoneNo"].ToString();
                string password = row["Password"].ToString();
                string membership = row["Membership"].ToString();

                listBox1.Items.Add($"First Name: {firstName}");
                listBox1.Items.Add($"Last Name: {lastName}");
                listBox1.Items.Add($"Email: {email}");
                listBox1.Items.Add($"Phone No: {phoneNo}");
                listBox1.Items.Add($"Password: {password}");
                listBox1.Items.Add($"Membership: {membership}");
                listBox1.Items.Add("----------------------");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve the entered email
            string userEmail = txtEnteredEmail.Text;

            // Retrieve the updated password and membership values
            string updatedPassword = txtPassword.Text;
            string updatedMembership = comboBox3.SelectedItem?.ToString();

            // Validate if required fields are filled
            if (string.IsNullOrEmpty(updatedPassword) || string.IsNullOrEmpty(updatedMembership))
            {
                MessageBox.Show("Please fill all the required fields.");
                return;
            }

            // Update the user information in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE [User] SET Password = @Password, Membership = @Membership WHERE Email = @Email";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Password", updatedPassword);
                    command.Parameters.AddWithValue("@Membership", updatedMembership);
                    command.Parameters.AddWithValue("@Email", userEmail);

                    command.ExecuteNonQuery();

                    MessageBox.Show("User information updated successfully!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void btnViewEvnt_Click(object sender, EventArgs e)
        {
            // Clear the existing items in the ListBox
            listBox1.Items.Clear();

            // Query the database to retrieve data from the "Event" table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT EventName, Description, DateTime, Venue, Capacity, AdditionalRequirements FROM [Event]";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    // Read the data from the reader and display it in the ListBox
                    while (reader.Read())
                    {
                        string eventName = reader["EventName"].ToString();
                        string description = reader["Description"].ToString();
                        DateTime dateTime = Convert.ToDateTime(reader["DateTime"]);
                        string venue = reader["Venue"].ToString();
                        int capacity = Convert.ToInt32(reader["Capacity"]);
                        string additionalRequirements = reader["AdditionalRequirements"].ToString();

                        listBox1.Items.Add($"Event Name: {eventName}");
                        listBox1.Items.Add($"Description: {description}");
                        listBox1.Items.Add($"Date and Time: {dateTime}");
                        listBox1.Items.Add($"Venue: {venue}");
                        listBox1.Items.Add($"Capacity: {capacity}");
                        listBox1.Items.Add($"Additional Requirements: {additionalRequirements}");
                        listBox1.Items.Add("----------------------");
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Clear the existing items in the ListBox
            listBox1.Items.Clear();

            // Get today's date
            DateTime today = DateTime.Today;

            // Query the database to retrieve data from the "Event" table before today's date
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT EventName, Description, DateTime, Venue, Capacity, AdditionalRequirements FROM [Event] WHERE DateTime < @Today";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Today", today);

                    SqlDataReader reader = command.ExecuteReader();

                    // Read the data from the reader and display it in the ListBox
                    while (reader.Read())
                    {
                        string eventName = reader["EventName"].ToString();
                        string description = reader["Description"].ToString();
                        DateTime dateTime = Convert.ToDateTime(reader["DateTime"]);
                        string venue = reader["Venue"].ToString();
                        int capacity = Convert.ToInt32(reader["Capacity"]);
                        string additionalRequirements = reader["AdditionalRequirements"].ToString();

                        listBox1.Items.Add($"Event Name: {eventName}");
                        listBox1.Items.Add($"Description: {description}");
                        listBox1.Items.Add($"Date and Time: {dateTime}");
                        listBox1.Items.Add($"Venue: {venue}");
                        listBox1.Items.Add($"Capacity: {capacity}");
                        listBox1.Items.Add($"Additional Requirements: {additionalRequirements}");
                        listBox1.Items.Add("----------------------");
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            // Check if an event is selected
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }

            // Get the selected event name from the ListBox
            string eventName = listBox2.SelectedItem.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Delete the selected event from the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM [Event] WHERE EventName = @EventName";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@EventName", eventName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event deleted successfully!");
                            listBox2.Items.Remove(eventName);
                        }
                        else
                        {
                            MessageBox.Show("Event not found.");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnAddEvnt_Click(object sender, EventArgs e)
        {
            // Retrieve the input values
            string eventName = txtEvntName.Text;
            string description = txtEvntDescr.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string venue = comboBox1.SelectedItem.ToString();
            int capacity = Convert.ToInt32(txtCapacity.Text);
            string additionalRequirements = txtAddReq.Text;

            int venueCapacity = 0;

            // Determine the maximum capacity based on the selected venue
            if (venue == "Crystal Gardens Convention Center")
            {
                venueCapacity = 1000;
            }
            else if (venue == "Starlight Ballroom")
            {
                venueCapacity = 500;
            }
            else if (venue == "Serenity Plaza")
            {
                venueCapacity = 300;
            }
            else if (venue == "Golden Pavilion")
            {
                venueCapacity = 250;
            }
            else if (venue == "Emerald Hall")
            {
                venueCapacity = 200;
            }
            else if (venue == "Moonbeam Theater")
            {
                venueCapacity = 150;
            }
            else if (venue == "Harmony Lounge")
            {
                venueCapacity = 100;
            }
            else
            {
                MessageBox.Show("Invalid venue selection.");
                return;
            }

            // Check if the selected venue exceeds its maximum capacity
            if (capacity > venueCapacity)
            {
                MessageBox.Show("The selected venue cannot accommodate the specified capacity.");
                return;
            }

            // Insert the event data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO [Event] (EventName, Description, DateTime, Venue, Capacity, AdditionalRequirements) " +
                                   "VALUES (@EventName, @Description, @DateTime, @Venue, @Capacity, @AdditionalRequirements)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventName", eventName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@DateTime", dateTime);
                    command.Parameters.AddWithValue("@Venue", venue);
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@AdditionalRequirements", additionalRequirements);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Event added successfully!");
                        listBox2.Items.Add(eventName); // Add the event to the ListBox
                    }
                    else
                    {
                        MessageBox.Show("Event not added.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void btnUpdateEvnt_Click(object sender, EventArgs e)
        {
            // Retrieve the input values
            string eventName = txtEvntName.Text;
            string description = txtEvntDescr.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string venue = comboBox1.SelectedItem.ToString();
            int capacity = Convert.ToInt32(txtCapacity.Text);
            string additionalRequirements = txtAddReq.Text;

            int venueCapacity = 0;

            // Determine the maximum capacity based on the selected venue
            if (venue == "Crystal Gardens Convention Center")
            {
                venueCapacity = 1000;
            }
            else if (venue == "Starlight Ballroom")
            {
                venueCapacity = 500;
            }
            else if (venue == "Serenity Plaza")
            {
                venueCapacity = 300;
            }
            else if (venue == "Golden Pavilion")
            {
                venueCapacity = 250;
            }
            else if (venue == "Emerald Hall")
            {
                venueCapacity = 200;
            }
            else if (venue == "Moonbeam Theater")
            {
                venueCapacity = 150;
            }
            else if (venue == "Harmony Lounge")
            {
                venueCapacity = 100;
            }
            else
            {
                MessageBox.Show("Invalid venue selection.");
                return;
            }

            // Check if the selected venue exceeds its maximum capacity
            if (capacity > venueCapacity)
            {
                MessageBox.Show("The selected venue cannot accommodate the specified capacity.");
                return;
            }

            // Update the event data in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE [Event] SET Description = @Description, DateTime = @DateTime, Venue = @Venue, " +
                                   "Capacity = @Capacity, AdditionalRequirements = @AdditionalRequirements " +
                                   "WHERE EventName = @EventName";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@DateTime", dateTime);
                    command.Parameters.AddWithValue("@Venue", venue);
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@AdditionalRequirements", additionalRequirements);
                    command.Parameters.AddWithValue("@EventName", eventName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Event updated successfully!");
                        // You can update the event details in the ListBox here if needed
                    }
                    else
                    {
                        MessageBox.Show("Event not found.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        //show users all events
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the selected date and venue
            DateTime selectedDate = dateTimePicker2.Value.Date;
            string selectedVenue = comboBox2.SelectedItem?.ToString();

            // Query the database to retrieve events based on the selected date and venue
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT EventName, Description, DateTime, Venue, Capacity, AdditionalRequirements " +
                                   "FROM [Event] " +
                                   "WHERE CONVERT(DATE, DateTime) = @SelectedDate AND Venue = @SelectedVenue";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    command.Parameters.AddWithValue("@SelectedVenue", selectedVenue);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable eventTable = new DataTable();
                    adapter.Fill(eventTable);

                    // Clear existing items in the ListBox
                    listEvent1.Items.Clear();

                    // Display the events in the ListBox
                    foreach (DataRow row in eventTable.Rows)
                    {
                        string eventName = row["EventName"].ToString();
                        string description = row["Description"].ToString();
                        DateTime dateTime = (DateTime)row["DateTime"];
                        string venue = row["Venue"].ToString();
                        int capacity = (int)row["Capacity"];
                        string additionalRequirements = row["AdditionalRequirements"].ToString();

                        listEvent1.Items.Add("Event Name: " + eventName);
                        listEvent1.Items.Add("Description: " + description);
                        listEvent1.Items.Add("Date and Time: " + dateTime.ToString());
                        listEvent1.Items.Add("Venue: " + venue);
                        listEvent1.Items.Add("Capacity: " + capacity);
                        listEvent1.Items.Add("Additional Requirements: " + additionalRequirements);
                        listEvent1.Items.Add("----------------------");
                    }

                    if (eventTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No events found on the selected date and venue.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        //let normal users register for events
        private void btnRegisterForEvent_Click(object sender, EventArgs e)
        {
            // Retrieve the selected event and attendee details
            string selectedEvent = listEvent1.SelectedItem?.ToString();
            string attendeeName = textBox1.Text;
            string additionalDetails = richTextBox1.Text;

            if (string.IsNullOrEmpty(selectedEvent))
            {
                MessageBox.Show("Please select an event from the list.");
                return;
            }

            if (string.IsNullOrEmpty(attendeeName))
            {
                MessageBox.Show("Please enter the attendee name.");
                return;
            }

            // Insert the attendee data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO EventAttendee (EventName, AttendeeName, AdditionalDetails) " +
                                   "VALUES (@EventName, @AttendeeName, @AdditionalDetails)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventName", selectedEvent);
                    command.Parameters.AddWithValue("@AttendeeName", attendeeName);
                    command.Parameters.AddWithValue("@AdditionalDetails", additionalDetails);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendee registered successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to register attendee.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        //display reports for normal users
        private void btnReport_Click(object sender, EventArgs e)
        {
            // Query the database to retrieve data from the EventAttendee table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT EventName, AttendeeName, AdditionalDetails FROM EventAttendee";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable attendeeTable = new DataTable();
                    adapter.Fill(attendeeTable);

                    // Display the retrieved data in the DataGridView
                    dataGridView1.DataSource = attendeeTable;

                    if (attendeeTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No attendee data found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        }
    }

