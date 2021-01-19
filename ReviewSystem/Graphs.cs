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
    public partial class Graphs : UserControl
    {
        public Graphs()
        {
            InitializeComponent();
        }
        private void BindchartFoodQuality(List<FeedbackClass> lst)
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

                DataTable dt = Reports.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "FoodQuality";
                chartreview.Series["Series1"].XValueMember = "FoodQuality";
                chartreview.Series["Series1"].YValueMembers = "Count";

                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Food Quality");
                chartreview.Series["Series1"].IsValueShownAsLabel = true;


            }
        }

        // chart for staff friendliness

        private void BindchartStaffFriendliness(List<FeedbackClass> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.StaffFriendliness)
                    .Select(c1 => new
                    {
                        StaffFriendliness = c1.First().StaffFriendliness,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Reports.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "StaffFriendliness";
                chartreview.Series["Series2"].XValueMember = "StaffFriendliness";
                chartreview.Series["Series2"].YValueMembers = "Count";

                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Staff Friendliness");
                chartreview.Series["Series2"].IsValueShownAsLabel = true;


            }
        }

        // chart for value for money

        private void BindchartValueForMoney(List<FeedbackClass> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.ValueForMoney)
                    .Select(c1 => new
                    {
                        ValueForMoney = c1.First().ValueForMoney,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Reports.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "ValueForMoney";
                chartreview.Series["Series3"].XValueMember = "ValueForMoney";
                chartreview.Series["Series3"].YValueMembers = "Count";

                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Value for money");
                chartreview.Series["Series3"].IsValueShownAsLabel = true;


            }
        }
        // chart for cleanliness

        private void BindchartCleanliness(List<FeedbackClass> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.Cleanliness)
                    .Select(c1 => new
                    {
                        Cleanliness = c1.First().Cleanliness,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Reports.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "Cleanliness";
                chartreview.Series["Series4"].XValueMember = "Cleanliness";
                chartreview.Series["Series4"].YValueMembers = "Count";

                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Cleanliness");
                chartreview.Series["Series4"].IsValueShownAsLabel = true;


            }
        }

        // chart for order accuracy
        private void BindchartOrderAccuracy(List<FeedbackClass> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.OrderAccuracy)
                    .Select(c1 => new
                    {
                        OrderAccuracy = c1.First().OrderAccuracy,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Reports.Utility.ConvertToDataTable(result);
                chartreview.DataSource = dt;
                chartreview.Name = "Cleanliness";
                chartreview.Series["Series5"].XValueMember = "OrderAccuracy";
                chartreview.Series["Series5"].YValueMembers = "Count";

                this.chartreview.Titles.Remove(this.chartreview.Titles.FirstOrDefault());
                this.chartreview.Titles.Add("Order Accuracy");
                chartreview.Series["Series5"].IsValueShownAsLabel = true;


            }
        }
        FeedbackClass obj = new FeedbackClass();
        // chart for food review


        private void chartreview_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    List<FeedbackClass> listReview = obj.List();
                    string selected = this.comboBox.GetItemText(this.comboBox.SelectedItem);
                    if (selected == "Food Quality")
                    {
                        BindchartFoodQuality(listReview);
                    }
                    if (selected == "Staff Friendliness")
                    {
                        BindchartStaffFriendliness(listReview);
                    }
                    if (selected == "Value For Money")
                    {
                        BindchartValueForMoney(listReview);
                    }
                    if (selected == "Cleanliness")
                    {
                        BindchartCleanliness(listReview);
                    }
                    if (selected == "Order Accuracy")
                    {
                        BindchartOrderAccuracy(listReview);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
