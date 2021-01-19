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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            Load += AdminDashboard_Load;
        }

        private void pnlSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddFormDetails_Click(object sender, EventArgs e)
        {
            SetActivePanel(adminPanels1);
        }

        public void SetActivePanel(UserControl control)
        {
           adminPanels1.Visible = false;
           graphs1.Visible = false;
            home1.Visible = false;
            reports1.Visible = false;
            control.Visible = true;
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
           SetActivePanel(graphs1);
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
           SetActivePanel(home1);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //if (!pnlHome.Controls.Contains(UserControl1.Instance))
            //{
            //    pnlHome.Controls.Add(UserControl1.Instance);
            //    UserControl1.Instance.Dock = DockStyle.Fill;
            //    UserControl1.Instance.BringToFront();

            //}else
            //{
            //    UserControl1.Instance.BringToFront();
            //}
            SetActivePanel(reports1);
        }

        private void graphs1_Load(object sender, EventArgs e)
        {

        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
