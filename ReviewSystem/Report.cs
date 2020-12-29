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
    public partial class Report : Form
    {
        public class Utility
        {

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
                        data = "[" + data + "]";
                    }
                    return data;
                }
                return null;
            }

            public static DataTable ConvertToDataTable<T>(IList<T> data)
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                DataTable table = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                    Console.WriteLine(prop.Name.ToString());
                }
                if (data != null)
                {
                    foreach (T item in data)
                    {
                        DataRow row = table.NewRow();
                        Console.WriteLine("hi");
                        foreach (PropertyDescriptor prop in properties)
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                        table.Rows.Add(row);
                    }
                }
                return table;
            }
        }
        public Report()
        {
            InitializeComponent();
            BindGrid();
        }

       

        private void BindGrid()
        {
            FeedbackClass obj = new FeedbackClass();
            List<FeedbackClass> listReview = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listReview);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
