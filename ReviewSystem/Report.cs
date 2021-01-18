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
                }
                if (data != null)
                {
                    foreach (T item in data)
                    {
                        DataRow row = table.NewRow();
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
            Console.WriteLine(listReview.ToList());
            DataTable dt = Utility.ConvertToDataTable(listReview);
            dataGridView1.DataSource = dt;
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            FeedbackClass obj = new FeedbackClass();
            DateTime temp;
            DateTime oDate;
            List<FeedbackClass> listStudents = obj.List();
            DateTime[] arr1 = new DateTime[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].TotalRating;
                var date = listStudents[i].date;
                oDate = DateTime.Parse(date);
                arr1[i] = oDate;

            }
            int l = arr1.Length;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            List<FeedbackClass> listStudents2 = new List<FeedbackClass>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < listStudents.Count; j++)
                {
                    var id = listStudents[j].TotalRating;
                    DateTime name = DateTime.Parse(listStudents[j].date);
                    if (arr1[i] == name)
                    {
                        listStudents2.Add(listStudents[j]);
                    }
                }
            }
            DataTable dt = Utility.ConvertToDataTable(listStudents2);
            dataGridView1.DataSource = dt;

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
