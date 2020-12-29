﻿using System;
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
                for (int i = 0; i < 6; i++)
                {

                    table.Rows.Add(data[i].ToString());

                }

                for(int j = 0; j < 4; j++)
                {
                       table.Columns.Add(data1[j].ToString(), obj.checkBox());
                   
                }

                return table;
            }

        }

        public CustomerReview()
        {
            InitializeComponent();
            BindGrid();
        }
        FeedBackRatingVariables o = new FeedBackRatingVariables();
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
                    r.TotalRating = 0;
                    o.good = 0;
                    o.dissastisfied = 0;
                    o.average = 0;
                    o.excellent = 0;
                    //foreach (DataGridViewCell cell in dataGridView1.SelectAll())
                    //{
                    //    cell.Value = false;
                    //}
                    
                    
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

            // for column excellence 

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                //Use index of TimeOut column 
                        if ((bool)this.dataGridView1.CurrentCell.Value == true)
                        {
                    o.excellent = 5;
                    if (e.RowIndex == 0)
                        {
                           
                            r.TotalRating = r.TotalRating + o.excellent;
                            r.FoodQuality = o.excellent;
                        }
                    if (e.RowIndex == 1)
                    {

                        r.TotalRating = r.TotalRating + o.excellent;
                        r.StaffFriendliness = o.excellent;
                    }
                    if (e.RowIndex == 2)
                    {
                        r.TotalRating = r.TotalRating + o.excellent;
                        r.Cleanliness = o.excellent;
                    }
                    if (e.RowIndex == 3)
                    {
                        r.TotalRating = r.TotalRating + o.excellent;
                        r.OrderAccuracy = o.excellent;
                    }
                    if (e.RowIndex == 4)
                    {
                        r.TotalRating = r.TotalRating + o.excellent;
                        r.ResturantAmbainace = o.excellent;
                    }
                    if (e.RowIndex == 5)
                    {
                        r.TotalRating = r.TotalRating + o.excellent;
                        r.ValueForMoney = o.excellent;
                    }
                }
                else
                {
                    r.TotalRating = r.TotalRating - o.excellent;
                }

            }

            // for column good

            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                //Use index of TimeOut column 
                if ((bool)this.dataGridView1.CurrentCell.Value == true)
                {
                    o.good = 3;
                    if (e.RowIndex == 0)
                    {

                        r.TotalRating = r.TotalRating + o.good;
                        r.FoodQuality = o.good;
                    }
                    if (e.RowIndex == 1)
                    {

                        r.TotalRating = r.TotalRating + o.good;
                        r.StaffFriendliness = o.good;
                    }
                    if (e.RowIndex == 2)
                    {
                        r.TotalRating = r.TotalRating + o.good;
                        r.Cleanliness = o.good;
                    }
                    if (e.RowIndex == 3)
                    {
                        r.TotalRating = r.TotalRating + o.good;
                        r.OrderAccuracy = o.good;
                    }
                    if (e.RowIndex == 4)
                    {
                        r.TotalRating = r.TotalRating + o.good;
                        r.ResturantAmbainace = o.good;
                    }
                    if (e.RowIndex == 5)
                    {
                        r.TotalRating = r.TotalRating + o.good;
                        r.ValueForMoney = o.good;
                    }
                }
                else
                {
                    r.TotalRating = r.TotalRating - o.good;
                }

            }

            // for column average

            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                //Use index of TimeOut column 
                if ((bool)this.dataGridView1.CurrentCell.Value == true)
                {
                    o.average = 2;
                    if (e.RowIndex == 0)
                    {

                        r.TotalRating = r.TotalRating + o.average;
                        r.FoodQuality = o.average;
                    }
                    if (e.RowIndex == 1)
                    {

                        r.TotalRating = r.TotalRating + o.average;
                        r.StaffFriendliness = o.average;
                    }
                    if (e.RowIndex == 2)
                    {
                        r.TotalRating = r.TotalRating + o.average;
                        r.Cleanliness = o.average;
                    }
                    if (e.RowIndex == 3)
                    {
                        r.TotalRating = r.TotalRating + o.average;
                        r.OrderAccuracy = o.average;
                    }
                    if (e.RowIndex == 4)
                    {
                        r.TotalRating = r.TotalRating + o.average;
                        r.ResturantAmbainace = o.average;
                    }
                    if (e.RowIndex == 5)
                    {
                        r.TotalRating = r.TotalRating + o.average;
                        r.ValueForMoney = o.average;
                    }
                }
                else
                {
                    r.TotalRating = r.TotalRating - o.average;
                }
    

            }

            // for column dissatisfied

            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                //Use index of TimeOut column 
                if ((bool)this.dataGridView1.CurrentCell.Value == true)
                {
                    o.dissastisfied = 1;
                    if (e.RowIndex == 0)
                    {

                        r.TotalRating = r.TotalRating + o.dissastisfied;
                        r.FoodQuality = o.dissastisfied;
                    }
                    if (e.RowIndex == 1)
                    {

                        r.TotalRating = r.TotalRating + o.dissastisfied;
                        r.StaffFriendliness = o.dissastisfied;
                    }
                    if (e.RowIndex == 2)
                    {
                        r.TotalRating = r.TotalRating + o.dissastisfied;
                        r.Cleanliness = o.dissastisfied;
                    }
                    if (e.RowIndex == 3)
                    {
                        r.TotalRating = r.TotalRating + o.dissastisfied;
                        r.OrderAccuracy = o.dissastisfied;
                    }
                    if (e.RowIndex == 4)
                    {
                        r.TotalRating = r.TotalRating + o.dissastisfied;
                        r.ResturantAmbainace = o.dissastisfied;
                    }
                    if (e.RowIndex == 5)
                    {
                        r.TotalRating = r.TotalRating + o.dissastisfied;
                        r.ValueForMoney = o.dissastisfied;
                    }
                }
                else
                {
                    r.TotalRating = r.TotalRating - o.dissastisfied;
                }

            }

        }

        // clear form button
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
} 
    

