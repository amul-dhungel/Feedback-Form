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
    public partial class CustomerReview : Form
    {


        public class Utility
        {
            // write into text file
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

            // read from text file method
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

            public static DataTable ConvertToDataTable<T>(IList<T> data, IList<T> data1)
            {

                DataTable table = new DataTable();
                table.Columns.Add("Criterias");
                CustomerReviewClass obj = new CustomerReviewClass();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(data[0].ToString());

                    table.Rows.Add(data[i].ToString());

                    //table.Columns.Add(data1[i].ToString());

                    table.Columns.Add(data1[i].ToString(), obj.checkBox());

                }

                return table;
            }

        }

        public CustomerReview()
        {
            InitializeComponent();
            BindGrid();
        }
        FeedbackClass r = new FeedbackClass();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            

                r.CustomerName = txtName.Text;
                r.CustomerEmail = txtEmail.Text;
                r.CustomerNumber = txtNumber.Text;
                DateTime date = DateTime.Now;  //get current datetime 
                r.date = date.Date.Month + "/" + date.Date.Day + "/" + date.Date.Year;

                string flag = r.Save(r);
                if (flag == "Success")
                {
                    ClearForm(); 
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured ");
            }



        }

        // clearing form
        public void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
            // dataGridView1.CurrentCell.Value = false;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BindGrid()
        {
            CustomerReviewClass obj = new CustomerReviewClass();
            List<string> listReview = obj.ListCriteria();
            List<string> listReview1 = obj.ListRating();
            DataTable dt = Utility.ConvertToDataTable(listReview, listReview1);
            dataGridView1.DataSource = dt;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        // data grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
       
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if ((bool)this.dataGridView1.CurrentCell.Value == true)
                {
                    //Use index of TimeOut column  
                    r.good = 1;
                    r.totalRating = r.totalRating + r.good;

                }
            }
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if ((bool)this.dataGridView1.CurrentCell.Value == true)
                {
                    //Use index of TimeOut column  
                    r.bad = 2;
                    r.totalRating = r.totalRating + r.bad;
                }
            }

            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if ((bool)this.dataGridView1.CurrentCell.Value == true)
                {
                    //Use index of TimeOut column
                   r.average = 3;
                    r.totalRating = r.totalRating + r.average;
                }
            }
        }

        // clear form button
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
} 
    

