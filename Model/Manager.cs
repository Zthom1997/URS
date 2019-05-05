using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS.Model
{
    public class Manager : Employee
    {
        public List<Employee> Employees = new List<Employee>();

        //Inheritance constructor for class Manager
        public Manager(int _employeeID, string _firstName, string _lastName, string _position, string _manager) :
            base(_employeeID, _firstName, _lastName, _position, _manager)
        { }

       //Method for manager to register a new employee
        public string registerEmployee(int _managerID, string _firstName, string _lastName, string _position, string _manager, string _kind, float _contractHours, float _distance, string _workHome, float _salary, string _loginName, string _password)
        {
            DAL dal = new DAL();
            string employeeCreated = dal.RegisterEmployee(_managerID, _firstName, _lastName, _position, _manager, _kind, _contractHours, _distance, _workHome, _salary, _loginName, _password);
            if(employeeCreated == "Medewerker is geregistreerd")
            {
                return employeeCreated;
            }
            else
            {
                return employeeCreated;
            }
        }

        //Method to update the data of the employee in the database
        public string UpdateEmployee(int _managerID, string _firstName, string _lastName, string _position, string _manager, string _kind, float _contractHours, float _distance, string _workHome, float _salary, string _loginName, string _password)
        {
            DAL dal = new DAL();
            string message = dal.UpdateEmployee(_managerID, _firstName, _lastName, _position, _manager, _kind, _contractHours, _distance, _workHome, _salary, _loginName, _password);
            return message;
        }

        //Method to delete an employee from the database
        public string DeleteEmployee(string _firstName)
        {
            DAL dal = new DAL();
            string message = dal.DeleteEmployee(_firstName);
            return message;
        }

        //Method for manager to add a new activity
        public string AddActivity(int _code, string _name, string _description)
        {
            DAL dal = new DAL();
            string activityAdded = dal.AddActivity(_code, _name, _description);
            if(activityAdded == "Activiteit toegevoegd")
            {
                return activityAdded;
            }
            else
            {
                return activityAdded;
            }
        }

        //Method for manager to get an overview of hours that have to be approved from his employees
        public List<Employee> ApproveHours(int _ID)
        {
            DAL dal = new DAL();
            List<Employee> Employees = new List<Employee>();
            Employees = dal.PopulateApproveHours(_ID);
            return Employees;

        }

        //Method to approve hours from employees that are working for the manager
        public string UpdateHours(int _ID, string _approved)
        {
            DAL dal = new DAL();
            string hoursUpdated = dal.UpdateHours(_ID, _approved);
            return hoursUpdated;
        }
    }
}
