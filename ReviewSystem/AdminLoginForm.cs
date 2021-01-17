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

        // Login session of the admin panel
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // fetching data from username field
            string password = txtPassword.Text; // fetching data form password field 

            // setting and validating username and password for admin

            if (username == "admin" && password == "admin")
            {
                AdminPanel obj = new AdminPanel(); // navigating to admin panel window
                obj.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }


        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        // Navigates to feedback panel
        private void btnFeedback_Click(object sender, EventArgs e) 
        {
            CustomerReview obj = new CustomerReview();
            obj.Show();
        }
    }
}
