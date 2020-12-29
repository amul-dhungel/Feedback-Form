using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSystem
{
    class FeedbackClass
    {
        public string _filePathDatabase = "Local Database/FeedBack.json";
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }
        public int TotalRating { get; set; }
        public int FoodQuality { get; set; }
        public int StaffFriendliness { get; set; }
        public int Cleanliness { get; set; }
        public int OrderAccuracy { get; set; }
        public int ResturantAmbainace { get; set; }
        public int ValueForMoney { get; set; }
        public string date { get; set; }

      
        // wrting rating data in a text file
        public string Save(FeedbackClass r)
        {
            string data = JsonConvert.SerializeObject(r, Formatting.None);
            CustomerReview.Utility.WriteToTextFile(_filePathDatabase, data);
            return "Success";
        }

        // reading rating data from text file in list format
        public List<FeedbackClass> List()
        {
            string d = Report.Utility.ReadFromTextFile(_filePathDatabase);
            if (d != null)
            {
                List<FeedbackClass> lst = JsonConvert.DeserializeObject<List<FeedbackClass>>(d);
                return lst;
            }
            return null;
        }
    }
}
