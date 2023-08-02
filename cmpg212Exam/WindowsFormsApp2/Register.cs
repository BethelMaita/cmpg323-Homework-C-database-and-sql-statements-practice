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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bethel\Documents\cmpg212 exam\final exam\31709974_BZvomuno_cmpg212Exam\WindowsFormsApp2\User.mdf"";Integrated Security=True";
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNo = txtPhoneNo.Text;
            string password = txtPassword.Text;
            string conPassword = txtConPassword.Text;
            string membership = comboBox1.SelectedItem.ToString();

            // Validate if required fields are filled
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNo) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(conPassword) ||
                string.IsNullOrEmpty(membership))
            {
                MessageBox.Show("Please fill all the required fields.");
                return;
            }

            // Validate if password and confirm password match
            if (password != conPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }
            string userId = GenerateRandomUserId();
            // Insert the user data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO [User] (Id_User,FirstName, LastName, Email, PhoneNo, Password, Membership) " +
                                   "VALUES (@UserId,@FirstName, @LastName, @Email, @PhoneNo, @Password, @Membership)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Membership", membership);

                    command.ExecuteNonQuery();

                    MessageBox.Show("User registration successful!");
                    ClearFields();
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

        private void ClearFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtPassword.Text = string.Empty;

        }
        private string GenerateRandomUserId()
        {
            // Generate a random number for the User ID
            Random random = new Random();
            int userId = random.Next(1000, 9999);

            // Convert the random number to a string and return it
            return userId.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
