using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewSystem
{
    class CustomerReviewClass
    {
        public string _filePathCriteria = "Local Database/CriteriaDetials.json";
        public string _filePathRating = "Local Database/RatingDetials.json";
       

        // fetching columns
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

        // fetching rows
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
        // creating checkbox for columns with value assign
        public Type checkBox()
        {
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            return dgvCmb.ValueType;
        }

       
    }
}
