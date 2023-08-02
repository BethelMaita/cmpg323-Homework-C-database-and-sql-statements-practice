using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frmRegister = new Register();
            frmRegister.Show();
        }
    }
}
