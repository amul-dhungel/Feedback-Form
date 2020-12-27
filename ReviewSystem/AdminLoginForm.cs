using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewSystem
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // fetching data from username field
            string password = txtPassword.Text; // fetching data form password field 

            // setting and validating username and password for admin

            if (username == "admin" && password == "admin")
            {
                AdminPanel obj = new AdminPanel(); // moving to admin panel window
                obj.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
