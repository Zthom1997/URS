using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URS.Model
{
   public class Employee
    {
        public List<Hour> Hours = new List<Hour>();

        public int employeeID;
        public string userName;
        public string password;
        public string firstName;
        public string lastName;
        public string position;
        public float salary;
        public float contractHours;
        public string manager;

        //Constructor for class Employee
        public Employee(int _employeeID, string _firstName, string _lastName, string _position, string _manager)
        {
            employeeID = _employeeID;
            firstName = _firstName;
            lastName = _lastName;
            position = _position;
            manager = _manager;
        }

        //Overload constructor for class Employee 
        //This constructor is being used for creating reports
        public Employee(int _employeeID, string _firstName, string _lastName, float _contractHours,float _salary)
        {
            employeeID = _employeeID;
            firstName = _firstName;
            lastName = _lastName;
            contractHours = _contractHours;
            salary = _salary;
        }

        //Method to handle login request and position
        public string Login(string _loginName, string _password)
        {
            DAL dal = new DAL();
            int _employeeID = dal.Login(_loginName, _password);

            //if _employeeID > 0, check position of employee and return true
            //if _employeeeID =< 0, return false
            if(_employeeID > 0)
            {
                employeeID = _employeeID;
                string _position = dal.CheckPosition(_employeeID);
                position = _position;
                string message = "U heeft toegang";
                return message;
            }
            else if(_employeeID == 0)
            {
                string message = "U heeft geen toegang";
                return message;
            }
            else
            {
                string message = "Geen DB connectie";
                return message;
            }
        }

        //Method to select data from employee that is logged in from DAL
        //List employeeData contains exact same data as list in DAL
        public List<string> ViewData(int _ID)
        {
            DAL dal = new DAL();
            List<string> employeeData = dal.ViewData(_ID);
            return employeeData;
        }

        //Method to view hours from manager or employee
        //Select all hours from employee that is logged in from DAL
        public string ViewHours(Employee _emp, int _ID)
        {
            DAL dal = new DAL();
            string hoursAvailable = dal.PopulateGridFromDB(_emp, _ID);
            if(hoursAvailable == "Data beschikbaar")
            {
                for (int i = 0; i < dal.Hours.Count(); i++)
                {
                    Hours = dal.Hours;
                }
                return hoursAvailable;
            }
            else
            {
                return hoursAvailable;
            }
        }

        //Method to add worked hours from employee or manager
        public string AddHours(int _employeeID, int _activityID, string _date, float _duration, string _location, string _description)
        {
            DAL dal = new DAL();
            string hoursAdded = dal.AddHours(_employeeID, _activityID, _date, _duration, _location, _description);

            if(hoursAdded == "Uren toegevoegd")
            {
                return hoursAdded;
            }
            else
            {
                return hoursAdded;
            }
        }

        //Method to modify the hours
        public string ModifyHours(int _ID, int _employeeID, int _activityID, string _date, float _duration, string _location, string _description)
        {
            DAL dal = new DAL();
            string message = dal.ModifyHours(_ID, _employeeID, _activityID, _date, _duration, _location, _description);
            return message;
        }
    }
}
