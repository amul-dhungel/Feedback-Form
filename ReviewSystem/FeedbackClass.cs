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
        public int totalRating { get; set; }
        public int good { get; set; }
        public int bad { get; set; }
        public int average { get; set; }
        public string date { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }

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
            string d = CustomerReview.Utility.ReadFromTextFile(_filePathDatabase);
            if (d != null)
            {
                List<FeedbackClass> lst = JsonConvert.DeserializeObject<List<FeedbackClass>>(d);
                return lst;
            }
            return null;
        }
    }
}
