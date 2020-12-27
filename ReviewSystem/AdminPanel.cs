using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewSystem
{
    public partial class AdminPanel : Form
    {
        // creating utitlity class for stream methods
        public class Utility
        {
            public static void WriteToTextFile(string path, string data, bool append = true, int count = 1)
            {
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                using (StreamWriter writer = new StreamWriter(path, append: append))
                {
                    if (!append)
                    {
                        //remove opening bracket '[' from json format
                        data = data.Trim().Substring(1, data.Trim().Length - 1);

                        // remove closing brackt ']' from json format
                        data = data.Trim().Substring(0, data.Trim().Length - 1);
                    }
                    if (count != 0)
                    {
                        data = data + ",";
                    }
                    writer.WriteLine(data);
                }
            }

            // read data from file function
            public static string ReadFromTextFile(string path)
            {
                if (File.Exists(path))
                {
                    string data;
                    using (StreamReader r = new StreamReader(path))
                    {
                        data = r.ReadToEnd();
                    }
                    if (data != "")
                    {
                        data = data + "";
                    }
                    return data;
                }
                return null;
            }

            // convert to data table

            public static DataTable ConvertToDataTable<T>(IList<T> data,IList<T> data1)
            {
              
                DataTable table = new DataTable();
                table.Columns.Add("Criterias");
 
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(data[0].ToString());
                    
                    table.Rows.Add(data[i].ToString());
                    table.Columns.Add(data1[i].ToString());
                }
         
                return table;
            }

            public static DataTable ConvertToDataTable1<T>(IList<T> data)
            {

                DataTable table = new DataTable();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(data[0].ToString());

                    table.Columns.Add(data[i].ToString());
                }

                return table;
            }
        }
            public AdminPanel()
        {
            InitializeComponent();
            
            // adding criteria column when the form loads for the first time
            table.Columns.Add("Criteria");
            dataGridView1.DataSource = table;
        }

        DataTable table = new DataTable(); // data table

        // button method to add criteria
        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            try
            {
                AdminPanelClass adminPanelClass = new AdminPanelClass();

                adminPanelClass.Criteria = txtCriteria.Text;
                string flag = adminPanelClass.SaveCriteria(adminPanelClass);

                // table view of the rating type
                table.Rows.Add(txtCriteria.Text);
                dataGridView1.DataSource = table;

                if (flag == "Success")
                {
                    ClearForm();
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Error occured : " + ex);
            }
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            try
            {
                AdminPanelClass adminPanelClass = new AdminPanelClass();
                adminPanelClass.Rating = txtRating.Text;
                string flag = adminPanelClass.SaveRating(adminPanelClass);

                // table view of the criteria type
                
                table.Columns.Add(txtRating.Text);
                dataGridView1.DataSource = table;

                if (flag == "Success")
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured : " + ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        // method is clear all data in form
        public void ClearForm()
        {
            txtCriteria.Text = " ";
            txtRating.Text = " ";
          
        }

        // Bind the data in grid method
        private void BindGrid()
        {
            AdminPanelClass obj = new AdminPanelClass();
            List<string> listReview = obj.List();
            List<string> listReview1 = obj.List1();
            DataTable dt = Utility.ConvertToDataTable(listReview,listReview1);
            dataGridView1.DataSource = dt;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    
    }
}
