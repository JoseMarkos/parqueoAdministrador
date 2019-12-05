using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueoAdministrator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Access();
        }

        private void Access()
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();

                Administrator admin = new Administrator();
                admin.Show();
            }

            else
            {
                labelNotification.Text = "The username and password do not match or you do not have an account yet.";
                //labelNotification.BackColor = Color.Yellow;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            CleanNotification();
        }

        private void CleanNotification()
        {
            labelNotification.Text = String.Empty;
            labelNotification.BackColor = Color.Transparent;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CleanNotification();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Access();
            }
        }
    }
}
