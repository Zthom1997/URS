using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace URS.Model
{
    class DAL
    {
        public List<Hour> Hours = new List<Hour>();
        public List<Report> Reports = new List<Report>();

        string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";

        //Method for employee to log in to application
        //Validate employee from database
        public int Login(string _userName, string _password)
        {
            int userID;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SElECT employeeID from Employee where loginName = @loginName and password = @password ";
                        cmd.Parameters.AddWithValue("@loginName", _userName);
                        cmd.Parameters.AddWithValue("@password", _password);
                        if (cmd.ExecuteScalar() == null)
                        {
                            userID = 0;
                            return userID;
                        }
                        else
                        {
                            userID = (int)cmd.ExecuteScalar();
                            return userID;
                        }
                    }
                }
            }
            catch
            {
                userID = -1;
                return userID;
            }
        }

        //Check position of employee in database who makes login request
        public string CheckPosition(int _employeeID)
        {
            string _position;
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SElECT position from Employee where employeeID = @employeeID";
                    cmd.Parameters.AddWithValue("@employeeID", _employeeID);
                    _position = (string)cmd.ExecuteScalar().ToString().ToLower();
                    return _position;
                }
            }
        }

        //Method to extract all data from database
        public List<string> ViewData(int _ID)
        {
            //Put data in list with EmployeeData
            List<string> employeeData = new List<string>();

            try
            {
                //Open SQL-session
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * from Employee WHERE employeeID = @employeeID";
                        cmd.Parameters.AddWithValue("@employeeID", _ID);

                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                //Add all relevant data from employee to list
                                employeeData.Add(dataReader[2].ToString());
                                employeeData.Add(dataReader[3].ToString());
                                employeeData.Add(dataReader[4].ToString());
                                employeeData.Add(dataReader[5].ToString());
                                employeeData.Add(dataReader[6].ToString());
                                employeeData.Add(dataReader[7].ToString());
                                employeeData.Add(dataReader[8].ToString());
                                employeeData.Add(dataReader[9].ToString());
                                employeeData.Add(dataReader[10].ToString());
                            }
                        }

                        //Return list with EmployeeData to Employee class
                        return employeeData;
                    }
                }
            }
            catch(SqlException ex)
            {
                employeeData.Add("Geen data");
                employeeData.Add(ex.ToString());
                return employeeData;
            }
        }

        //Method to extract Hours from database and add them to list from database
        public string PopulateGridFromDB(Employee _emp, int _ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * from Hours WHERE employeeID = @employeeID ";
                        cmd.Parameters.AddWithValue("@employeeID", _ID);

                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                //Add Hour data from Database to list Hours and change data to Hours object
                                Hours.Add(new Hour(Int32.Parse(dataReader[0].ToString()), Int32.Parse(dataReader[1].ToString()), Int32.Parse(dataReader[2].ToString()),
                                 dataReader[3].ToString(), float.Parse(dataReader[4].ToString()), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), _emp));
                            }
                        }
                    }
                }
                string message = "Data beschikbaar";
                return message;
            }
            catch(SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method to process & add a new employee to the database
        public string RegisterEmployee(int _managerID, string _firstName, string _lastName, string _position, string _manager, string _kind, float _contractHours, float _distance, string _workHome, float _salary, string _loginName, string _password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO Employee (managedBy, firstName, lastName, position, manager, kind, contractHours, distance, workHome, salary, loginName, password) VALUES (@managedBy, @firstName, @lastName, @position, @manager, @kind, @contractHours, @distance, @workHome, @salary, @loginName, @password) ";

                        //Data that must be added to database
                        cmd.Parameters.AddWithValue("@managedBy", _managerID);
                        cmd.Parameters.AddWithValue("@firstName", _firstName);
                        cmd.Parameters.AddWithValue("@lastName", _lastName);
                        cmd.Parameters.AddWithValue("@position", _position);
                        cmd.Parameters.AddWithValue("@manager", _manager);
                        cmd.Parameters.AddWithValue("@kind", _kind);
                        cmd.Parameters.AddWithValue("@contractHours", _contractHours);
                        cmd.Parameters.AddWithValue("@distance", _distance);
                        cmd.Parameters.AddWithValue("@workHome", _workHome);
                        cmd.Parameters.AddWithValue("@salary", _salary);
                        cmd.Parameters.AddWithValue("@loginName", _loginName);
                        cmd.Parameters.AddWithValue("@password", _password);

                        cmd.ExecuteNonQuery();
                        string message = "Medewerker is geregistreerd";
                        return message;
                    }
                }
            }
            catch(SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method to show activities from database
        public List<Activity> ShowActivities()
        {
            List<Activity> Activities = new List<Activity>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * from Activity";
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                //Convert data to Activity object and add to list of Activities
                                Activities.Add(new Activity(Int32.Parse(dataReader[0].ToString()), Int32.Parse(dataReader[1].ToString()), dataReader[2].ToString(), dataReader[3].ToString()));
                            }
                        }
                    }
                }
                return Activities;
            }
            catch (SqlException ex)
            {
                Activities.Add(new Activity(0, 0, "Geen data beschikbaar", ex.ToString()));
                return Activities;
            }
        }

        //Method to add hours for a employee based on the employee ID to the database
        public string AddHours(int _employeeID, int _activityID, string _date, float _duration, string _location, string _description)
        {
            try
            {
                string approved = "Nee";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO Hours (employeeID, activityID, date, duration, location, description, approved) VALUES (@employeeID, @activityID, @date, @duration, @location, @description, @approved)";

                        //Values that must be added to register hours
                        cmd.Parameters.AddWithValue("@employeeID", _employeeID);
                        cmd.Parameters.AddWithValue("@activityID", _activityID);
                        cmd.Parameters.AddWithValue("@date", _date);
                        cmd.Parameters.AddWithValue("@duration", _duration);
                        cmd.Parameters.AddWithValue("@location", _location);
                        cmd.Parameters.AddWithValue("@description", _description);
                        cmd.Parameters.AddWithValue("@approved", approved);

                        cmd.ExecuteNonQuery();
                    }
                }

                string message = "Uren toegevoegd";
                return message;
            }
            catch (SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method to add an activity to the database
        public string AddActivity(int _code, string _name, string _description)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO Activity (code, name, description) VALUES (@code, @name, @description) ";

                        //Values that must be added to register activity
                        cmd.Parameters.AddWithValue("@code", _code);
                        cmd.Parameters.AddWithValue("@name", _name);
                        cmd.Parameters.AddWithValue("@description", _description);

                        cmd.ExecuteNonQuery();
                    }
                }
                string message = "Activiteit toegevoegd";
                return message;
            }
            catch (SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method for selecting all employees and hours from database
        public List<Employee> PopulateApproveHours(int _ID)
        {
            Employee emp;
            List<Employee> Employees = new List<Employee>();

            //Select employees from database by manager ID
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT employeeID, firstName, lastName, position, manager From Employee WHERE managedBy = @managedBy";
                        cmd.Parameters.AddWithValue("@managedBy", _ID);
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                emp = new Employee(Int32.Parse(dataReader[0].ToString()), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
                                Employees.Add(emp);
                            }
                        }
                    }
                }

                //Fill Hours of employee
                for (int i = 0; i < Employees.Count; i++)
                {
                    //Select hours from database by Employee
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            conn.ConnectionString = connectionString;
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT * FROM Hours WHERE employeeID = @employeeID AND approved = 'Nee' ";
                            cmd.Parameters.AddWithValue("@employeeID", Employees[i].employeeID);
                            using (SqlDataReader dataReader = cmd.ExecuteReader())
                            {
                                while (dataReader.Read())
                                {
                                    Employees[i].Hours.Add(new Hour(Int32.Parse(dataReader[0].ToString()), Int32.Parse(dataReader[1].ToString()), Int32.Parse(dataReader[2].ToString()), dataReader[3].ToString(), float.Parse(dataReader[4].ToString()), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), Employees[i]));
                                }
                            }
                        }
                    }

                }
                return Employees;
            }
            catch (SqlException ex)
            {
                Employees.Add(new Employee(0, ex.ToString(), "Error", 0, 0));
                return Employees;
            }
        
        }


        //Method to update hours with the approvement of the manager
        public string UpdateHours(int _ID, string _approved)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE Hours SET approved = @approved WHERE ID = @ID";
                        cmd.Parameters.AddWithValue("@ID", _ID);
                        cmd.Parameters.AddWithValue("@approved", _approved);
                        cmd.ExecuteNonQuery();
                    }
                }
                string message = "Uren bijgewerkt";
                return message;
            }
            catch (SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method to modify the submitted hours and add these modifications to the database
        public string ModifyHours(int _ID, int _employeeID, int _activityID, string _date, float _duration, string _location, string _description)
        {
            string message;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE Hours Set employeeID = @employeeID, activityID = @activityID, date = @date, duration = @duration, location = @location, description = @description WHERE ID = @ID ";
                        cmd.Parameters.AddWithValue("@ID", _ID);
                        cmd.Parameters.AddWithValue("@employeeID", _employeeID);
                        cmd.Parameters.AddWithValue("@activityID", _activityID);
                        cmd.Parameters.AddWithValue("@date", _date);
                        cmd.Parameters.AddWithValue("@duration", _duration);
                        cmd.Parameters.AddWithValue("@location", _location);
                        cmd.Parameters.AddWithValue("@description", _description);
                        cmd.ExecuteNonQuery();
                    }
                }
                message = "Uren zijn bijgewerkt";
                return message;
            }
            catch(SqlException ex)
            {
                message = ex.ToString();
                return message;
            }
        }

        //Method to update the data of an employee and save these changes to the database
        public string UpdateEmployee(int _managerID, string _firstName, string _lastName, string _position, string _manager, string _kind, float _contractHours, float _distance, string _workHome, float _salary, string _loginName, string _password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE Employee SET managedBy = @managedBy, firstName = @firstName, lastName = @lastName, position = @position, manager = @manager, kind = @kind, contractHours = @contractHours, distance = @distance, workHome = @workHome, salary = @salary, loginName = @loginName, password = @password WHERE firstName = @firstName ";

                        //Data that must be added to database
                        cmd.Parameters.AddWithValue("@managedBy", _managerID);
                        cmd.Parameters.AddWithValue("@firstName", _firstName);
                        cmd.Parameters.AddWithValue("@lastName", _lastName);
                        cmd.Parameters.AddWithValue("@position", _position);
                        cmd.Parameters.AddWithValue("@manager", _manager);
                        cmd.Parameters.AddWithValue("@kind", _kind);
                        cmd.Parameters.AddWithValue("@contractHours", _contractHours);
                        cmd.Parameters.AddWithValue("@distance", _distance);
                        cmd.Parameters.AddWithValue("@workHome", _workHome);
                        cmd.Parameters.AddWithValue("@salary", _salary);
                        cmd.Parameters.AddWithValue("@loginName", _loginName);
                        cmd.Parameters.AddWithValue("@password", _password);

                        cmd.ExecuteNonQuery();
                    }
                }
                string message = "Medewerker is aangepast";
                return message;
            }
            catch(SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method to delete an employee permanently from the database
        public string DeleteEmployee(string _firstName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM Employee WHERE firstName = @firstName ";
                        cmd.Parameters.AddWithValue("@firstName", _firstName);
                        cmd.ExecuteNonQuery();
                    }
                }
                string message = "Medewerker verwijderd";
                return message;
            } 
            catch(SqlException ex)
            {
                string message = ex.ToString();
                return message;
            }
        }

        //Method to get all data from employees and the worked hours of the employees from the database
        //This method is primary used for generating reports with databasedata
        public List<Employee> GetAllData()
        {
            List<Employee> EmployeeList = new List<Employee>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * From employee";
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                EmployeeList.Add(new Employee(Int32.Parse(dataReader[0].ToString()), dataReader[2].ToString(), dataReader[3].ToString(), float.Parse(dataReader[7].ToString()), float.Parse(dataReader[10].ToString())));
                            }
                        }
                    }
                }

                //Fill Hours of employee
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    //Select hours from database by Employee
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            conn.ConnectionString = connectionString;
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT * FROM Hours WHERE employeeID = @employeeID ";
                            cmd.Parameters.AddWithValue("@employeeID", EmployeeList[i].employeeID);
                            using (SqlDataReader dataReader = cmd.ExecuteReader())
                            {
                                while (dataReader.Read())
                                {
                                    EmployeeList[i].Hours.Add(new Hour(Int32.Parse(dataReader[0].ToString()), Int32.Parse(dataReader[1].ToString()), Int32.Parse(dataReader[2].ToString()), dataReader[3].ToString(), float.Parse(dataReader[4].ToString()), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), EmployeeList[i]));
                                }
                            }
                        }
                    }
                }

                return EmployeeList;
            }
            catch (SqlException ex)
            {
                EmployeeList.Add(new Employee(0, ex.ToString(), "Error", 0, 0));
                return EmployeeList;
            }
        }

        //Method to get the hours worked per employee per week
        //Database checks data from worked hours that is in current week
        public float GetWeeklyHours(int _ID)
        {
            float hoursOfWeek = 0;
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT hrs.* from hours hrs where employeeID = @employeeID and datepart(week, convert(datetime, hrs.date,105)) = datepart(week,getdate())";
                        cmd.Parameters.AddWithValue("@employeeID", _ID);
                        using(SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                hoursOfWeek += float.Parse(dataReader[4].ToString());
                            }
                        }

                    }
                }
                return hoursOfWeek;
            }
            catch
            {
                return hoursOfWeek;
            }
        }
    }
}
