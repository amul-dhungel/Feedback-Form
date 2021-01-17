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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
           
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

          private void Bindchart(List<FeedbackClass> lst)
        { 
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.FoodQuality)
                    .Select(c1 => new
                    {
                        FoodQuality = c1.First().FoodQuality,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Report.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "FoodQuality";
                chartreview.Series["Series1"].XValueMember = "FoodQuality";
                chartreview.Series["Series1"].YValueMembers = "Count";

                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Food Quality");
                chartreview.Series["Series1"].IsValueShownAsLabel = true;


            }
        }

        FeedbackClass obj = new FeedbackClass();
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<FeedbackClass> listReview = obj.List();
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (selected == "Food Quality")
            {
                Bindchart(listReview);
            }
        }
    }
}
