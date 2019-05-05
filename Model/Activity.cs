using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS.Model
{
    class Activity
    {
        public List<Hour> Hours = new List<Hour>();
        public int activityID;
        public int code;
        public string name;
        public string description;

        //Constructor for class Activity
        public Activity(int _activityID, int _code, string _name, string _description)
        {
            activityID = _activityID;
            code = _code;
            name = _name;
            description = _description;
        }
    }
}
