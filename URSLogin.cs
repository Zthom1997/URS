using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URS.Model;

namespace URS
{
    public partial class URSLogin : Form
    {
        Employee emp;
        

        public URSLogin()
        {
            InitializeComponent();
        }

        //Method to load initial settings of form
        private void URSLogin_Load(object sender, EventArgs e)
        {
            //Dummy object to access and use class methods
            emp = new Employee(1, "URS", "URS", "URS", "URS");
        }

        //Method to activitate loginbutton
        private void loginButton_Click(object sender, EventArgs e)
        {
            //login procedure
            emp.userName = userNameTextBox.Text;
            emp.password = passwordTextBox.Text;
            string loggedIn = emp.Login(emp.userName, emp.password);
            List<string> empData = emp.ViewData(emp.employeeID);

            //If loggedIn is true than open new window for correct position of employee
            //Else show MessageBox with error and clear textboxes
            if(loggedIn == "U heeft toegang")
            {
                if(emp.position == "Manager".ToLower())
                {
                    Manager manager = new Manager(emp.employeeID, empData[0], empData[1], empData[2], empData[3]);
                    URSOverviewManager managerOverView = new URSOverviewManager(emp.employeeID, manager);
                    managerOverView.Show();
                    this.Hide();
                }
                else
                {
                    Employee employee = new Employee(emp.employeeID, empData[0], empData[1], empData[2], empData[3]);
                    URSOverviewEmployee employeeOverview = new URSOverviewEmployee(emp.employeeID, employee);
                    employeeOverview.Show();
                    this.Hide();
                }
            }
            else if(loggedIn == "U heeft geen toegang")
            {
                MessageBox.Show("De gebruikersnaam en-/of wachtwoord is onjuist", "URS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                userNameTextBox.Clear();
                passwordTextBox.Clear();
            }
            else
            {
                MessageBox.Show("De database kan niet benaderd worden. Neem contact op met uw beheerder", "URS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Method to activate the password forgotten link label
        private void passwordForgottenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("U kunt uw wachtwoord niet zelf aanpassen.\nNeem contact op met uw manager om een nieuw wachtwoord aan te vragen.", "URS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
