using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
            MessageBox.Show("Login Successful!");
            this.Hide();
            MainForm mainForm = new MainForm ();
            mainForm.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or password Please try again.");
            }

        }
    }
}
