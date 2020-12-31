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
            FeedbackClass obj = new FeedbackClass();
            List<FeedbackClass> listReview = obj.List();
            Bindchart(listReview);
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

          private void Bindchart(List<FeedbackClass> lst)
        { 
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => new { 
                        l.FoodQuality,
                        l.ValueForMoney,
                        l.StaffFriendliness,
                        l.OrderAccuracy,
                        l.ResturantAmbainace,
                        l.Cleanliness,
                        
                    })
                    .Select(c1 => new
                    {
                        FoodQuality = c1.First().FoodQuality,
                        ValueForMoney = c1.First().ValueForMoney,
                        StaffFriendliness = c1.First().StaffFriendliness,
                        OrderAccuracy = c1.First().OrderAccuracy,
                        ResturantAmbainace = c1.First().ResturantAmbainace,
                        Cleanliness = c1.First().Cleanliness,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Report.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "FoodQuality";
                chartreview.Series["Series1"].XValueMember = "FoodQuality";
                chartreview.Series["Series2"].XValueMember = "ValueForMoney";
                chartreview.Series["Series3"].XValueMember = "StaffFriendliness";
                chartreview.Series["Series4"].XValueMember = "OrderAccuracy";
                chartreview.Series["Series5"].XValueMember = "ResturantAmbainace";
                chartreview.Series["Series6"].XValueMember = "Cleanliness";
                chartreview.Series["Series1"].YValueMembers = "Count";
                chartreview.Series["Series2"].YValueMembers = "Count";
                chartreview.Series["Series3"].YValueMembers = "Count";
                chartreview.Series["Series4"].YValueMembers = "Count";
                chartreview.Series["Series5"].YValueMembers = "Count";
                chartreview.Series["Series6"].YValueMembers = "Count";
                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Rating");
                chartreview.Series["Series1"].IsValueShownAsLabel = true;
                chartreview.Series["Series2"].IsValueShownAsLabel = true;
                chartreview.Series["Series3"].IsValueShownAsLabel = true;
                chartreview.Series["Series4"].IsValueShownAsLabel = true;
                chartreview.Series["Series5"].IsValueShownAsLabel = true;
                chartreview.Series["Series6"].IsValueShownAsLabel = true;


                //var result2 = lst
                //   .GroupBy(l => l.ValueForMoney)
                //   .Select(c1 => new
                //   {
                //       ValueForMoney = c1.First().ValueForMoney,
                //       Count = c1.Count().ToString()
                //   }).ToList();

                //DataTable dt2 = Report.Utility.ConvertToDataTable(result2);
                //chartreview.DataSource = dt2;
                //chartreview.Name = "ValueForMoney";
                //chartreview.Series["Series2"].XValueMember = "ValueForMoney";
                //chartreview.Series["Series2"].YValueMembers = "Count";
                //this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                //this.chartreview.Titles.Add("Ratings");
                //chartreview.Series["Series2"].IsValueShownAsLabel = true;

            }
        } 
    }
}
