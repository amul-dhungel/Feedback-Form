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
                chartreview2.DataSource = dt;
                chartreview2.Name = "StaffFriendliness";
                chartreview2.Series["Series2"].XValueMember = "StaffFriendliness";
                chartreview2.Series["Series2"].YValueMembers = "Count";

                this.chartreview2.Titles.Remove(this.chartreview2.Titles.FirstOrDefault());
                this.chartreview2.Titles.Add("Staff Friendliness");
                chartreview2.Series["Series2"].IsValueShownAsLabel = true;


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
                chartreview3.DataSource = dt;
                chartreview3.Name = "ValueForMoney";
                chartreview3.Series["Series3"].XValueMember = "ValueForMoney";
                chartreview3.Series["Series3"].YValueMembers = "Count";

                this.chartreview3.Titles.Remove(this.chartreview3.Titles.FirstOrDefault());
                this.chartreview3.Titles.Add("Value for money");
                chartreview3.Series["Series3"].IsValueShownAsLabel = true;


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
                chartreview4.DataSource = dt;
                chartreview4.Name = "Cleanliness";
                chartreview4.Series["Series4"].XValueMember = "Cleanliness";
                chartreview4.Series["Series4"].YValueMembers = "Count";

                this.chartreview4.Titles.Remove(this.chartreview4.Titles.FirstOrDefault());
                this.chartreview4.Titles.Add("Cleanliness");
                chartreview4.Series["Series4"].IsValueShownAsLabel = true;


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
                chartreview5.DataSource = dt;
                chartreview5.Name = "Cleanliness";
                chartreview5.Series["Series5"].XValueMember = "OrderAccuracy";
                chartreview5.Series["Series5"].YValueMembers = "Count";

                this.chartreview5.Titles.Remove(this.chartreview5.Titles.FirstOrDefault());
                this.chartreview5.Titles.Add("Order Accuracy");
                chartreview5.Series["Series5"].IsValueShownAsLabel = true;


            }
        }

        private void BindchartRestaurant(List<FeedbackClass> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.ResturantAmbainace)
                    .Select(c1 => new
                    {
                        ResturantAmbainace = c1.First().ResturantAmbainace,
                        Count = c1.Count().ToString()
                    }).ToList();

                DataTable dt = Reports.Utility.ConvertToDataTable(result);
                chartreview6.DataSource = dt;
                chartreview6.Name = "Cleanliness";
                chartreview6.Series["Series6"].XValueMember = "ResturantAmbainace";
                chartreview6.Series["Series6"].YValueMembers = "Count";

                this.chartreview6.Titles.Remove(this.chartreview6.Titles.FirstOrDefault());
                this.chartreview6.Titles.Add("Resturant Ambainace");
                chartreview6.Series["Series6"].IsValueShownAsLabel = true;


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
                        chartreview.Visible = true;
                        chartreview2.Visible = false;
                        chartreview3.Visible = false;
                        chartreview4.Visible = false;
                        chartreview5.Visible = false;
                        chartreview6.Visible = false;
                        Console.WriteLine("oho");
                    }
                    if (selected == "Staff Friendliness")
                    {
                        BindchartStaffFriendliness(listReview);
                        chartreview.Visible = false;
                        chartreview2.Visible = true;
                        chartreview3.Visible = false;
                        chartreview4.Visible = false;
                        chartreview5.Visible = false;
                        chartreview6.Visible = false;
                        Console.WriteLine("oho2");
                    }
                    if (selected == "Value For Money")
                    {
                        BindchartValueForMoney(listReview);
                        chartreview.Visible = false;
                        chartreview2.Visible = false;
                        chartreview3.Visible = true;
                        chartreview4.Visible = false;
                        chartreview5.Visible = false;
                        chartreview6.Visible = false;
                    }
                    if (selected == "Cleanliness")
                    {
                        BindchartCleanliness(listReview);
                        chartreview.Visible = false;
                        chartreview2.Visible = false;
                        chartreview3.Visible = false;
                        chartreview4.Visible = true;
                        chartreview5.Visible = false;
                        chartreview6.Visible = false;
                    }
                    if (selected == "Order Accuracy")
                    {
                        BindchartOrderAccuracy(listReview);
                        chartreview.Visible = false;
                        chartreview2.Visible = false;
                        chartreview3.Visible = false;
                        chartreview4.Visible = false;
                        chartreview5.Visible = true;
                        chartreview6.Visible = false;
                    }
                    if (selected == "Restaurant Ambainance")
                    {
                        BindchartRestaurant(listReview);
                        chartreview.Visible = false;
                        chartreview2.Visible = false;
                        chartreview3.Visible = false;
                        chartreview4.Visible = false;
                        chartreview5.Visible = false;
                        chartreview6.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void chartreview2_Click(object sender, EventArgs e)
        {

        }
    }
}
