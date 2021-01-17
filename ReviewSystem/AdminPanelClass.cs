using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSystem
{
    class AdminPanelClass
    {
        public string _filePathCriteria = "Local Database/CriteriaDetials.json";
        public string _filePathRating = "Local Database/RatingDetials.json";
        public string Criteria { get; set; }
        public string Rating { get; set; }

        // initilazing function to write data in criteria Json file.
        public string SaveCriteria(AdminPanelClass r)
        {
            //string data = JsonConvert.SerializeObject(r.Criteria, Formatting.None);
           string data = r.Criteria;
            AdminPanel.Utility.WriteToTextFile(_filePathCriteria, data);
            return "Success";
        }
        // initilazing function to write data in rating Json file.
        public string SaveRating(AdminPanelClass r)
        {
            //string data = JsonConvert.SerializeObject(r.Rating, Formatting.None);
            string data = r.Rating;
            AdminPanel.Utility.WriteToTextFile(_filePathRating, data);
            return "Success";
        }

        // Read data in the form of list
        public List<string> ListCriteria()
        {
            string d = AdminPanel.Utility.ReadFromTextFile(_filePathCriteria);
            if (d != null)
            {
                List<string> lst = d.Split(',').ToList();
                return lst;
            }
            return null;
        }

        public List<string> ListRating()
        {
            string d = AdminPanel.Utility.ReadFromTextFile(_filePathRating);
            if (d != null)
            {
                List<string> lst = d.Split(',').ToList();
                return lst;
            }
            return null;
        }

    }


}

