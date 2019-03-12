using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Activities
    {
        public int ActivityID { get; set; }
        public string Date { get; set; }
        public bool Always { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }

        public Activities(int activityid, string date, bool always, string time, string description, int userid)
        {
            ActivityID = activityid;
            Date = date;
            Always = always;
            Time = time;
            Description = description;
            UserID = userid;
        }

        public Activities( string date, bool always, string time, string description)
        {
            
            Date = date;
            Always = always;
            Time = time;
            Description = description;
            
        }
    }
}
