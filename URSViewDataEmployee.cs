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
    public partial class URSViewDataEmployee : Form
    {
        int ID;
        Employee employee;
        public URSViewDataEmployee(int _ID, Employee _employee)
        {
            ID = _ID;
            employee = _employee;
            InitializeComponent();
        }

        //Method to set initial settings of form
        private void URSViewDataEmployee_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            positionTextBox.Enabled = false;
            managerTextBox.Enabled = false;
            kindTextBox.Enabled = false;
            contractHoursTextBox.Enabled = false;
            distanceTextBox.Enabled = false;
            workHomeTextBox.Enabled = false;
            salaryTextBox.Enabled = false;

            //Show data in textboxes from managerData list
            List<string> managerData = employee.ViewData(ID);
            firstNameTextBox.Text = managerData[0];
            lastNameTextBox.Text = managerData[1];
            positionTextBox.Text = managerData[2];
            managerTextBox.Text = managerData[3];
            kindTextBox.Text = managerData[4];
            contractHoursTextBox.Text = managerData[5];
            distanceTextBox.Text = managerData[6];
            workHomeTextBox.Text = managerData[7];
            salaryTextBox.Text = managerData[8];
        }

        //Method to activate OK button
        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
