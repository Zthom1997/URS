using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS.Model
{
    public class Hour
    {
        public int ID;
        public int employeeID;
        public int activityID;
        public string date;
        public float duration;
        public string location;
        public string description;
        public string approved;
        public Employee employee;

        //Constructor for class Hour
        public Hour(int _ID, int _employeeID, int _activityID, string _date, float _duration, string _location, string _description, string _approved, Employee _employee)
        {
            ID = _ID;
            employeeID = _employeeID;
            activityID = _activityID;
            date = _date;
            duration = _duration;
            location = _location;
            description = _description;
            approved = _approved;
            employee = _employee;
        }
    }
}
