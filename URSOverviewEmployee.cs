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
    public partial class URSOverviewEmployee : Form
    {
        int ID;
        Employee employee;

        public URSOverviewEmployee(int _ID, Employee _employee)
        {
            InitializeComponent();
            ID = _ID;
            employee = _employee;
        }

        //Method to load initial settings of form
        private void URSOverviewEmployee_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Welkom " + employee.firstName;
            RefreshHourDataGrid();
            hourOverviewDataGrid.Columns[6].MinimumWidth = 700;
            hourOverviewDataGrid.Enabled = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            RefreshWeeklyHours();
        }

        public void RefreshWeeklyHours()
        {
            DAL dal = new DAL();
            float hoursWorked = dal.GetWeeklyHours(ID);
            label1.Text = "U heeft deze week " + hoursWorked.ToString() + " uur gewerkt.";

            if (hoursWorked > 60)
            {
                MessageBox.Show("U heeft meer dan 60 uur gewerkt deze week.\nU kunt geen nieuwe uren meer boeken.", "URS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bookHoursButton.Enabled = false;
            }
            else
            {
                bookHoursButton.Enabled = true;
            }
        }

        //Method to refresh the datagrid with registred hours
        public void RefreshHourDataGrid()
        {
            string dataAvailable = employee.ViewHours(employee, ID);

            if(dataAvailable == "Data beschikbaar")
            {
                DataTable table = new DataTable();
                table.Columns.Add("Boeking-ID", typeof(int));
                table.Columns.Add("Activiteit-ID", typeof(int));
                table.Columns.Add("Datum", typeof(string));
                table.Columns.Add("Duur", typeof(float));
                table.Columns.Add("Locatie", typeof(string));
                table.Columns.Add("Goedgekeurd", typeof(string));
                table.Columns.Add("Omschrijving", typeof(string));

                //Fill Datagrid
                for (int i = 0; i < employee.Hours.Count; i++)
                {
                    table.Rows.Add(employee.Hours[i].ID, employee.Hours[i].activityID, employee.Hours[i].date,
                       employee.Hours[i].duration, employee.Hours[i].location, employee.Hours[i].approved, employee.Hours[i].description);
                }

                //Set datasource of Datagrid to table & database
                //Refresh the datagrid
                hourOverviewDataGrid.DataSource = table;
                hourOverviewDataGrid.Refresh();
            }
            else
            {
                DataTable table = new DataTable();
                table.Columns.Add("Boeking-ID", typeof(int));
                table.Columns.Add("Activiteit-ID", typeof(int));
                table.Columns.Add("Datum", typeof(string));
                table.Columns.Add("Duur", typeof(float));
                table.Columns.Add("Locatie", typeof(string));
                table.Columns.Add("Goedgekeurd", typeof(string));
                table.Columns.Add("Omschrijving", typeof(string));

                hourOverviewDataGrid.DataSource = table;
                hourOverviewDataGrid.Refresh();

                MessageBox.Show(dataAvailable, "URS~Urenoverzicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to activate the button to book hours
        private void bookHoursButton_Click(object sender, EventArgs e)
        {
            URSAddHoursEmployee addHours = new URSAddHoursEmployee(ID, this, employee);
            addHours.Show();
        }

        //Method to activate the button to show employee data
        private void employeeDataButton_Click(object sender, EventArgs e)
        {
            URSViewDataEmployee viewEmployeeData = new URSViewDataEmployee(ID, employee);
            viewEmployeeData.Show();
        }

        //Method to activate logout button
        private void logOutButton_Click(object sender, EventArgs e)
        {
            URSLogin login = new URSLogin();
            this.Hide();
            login.Show();
        }

        //Method to activate the button to update hours
        private void UpdateHoursButton_Click(object sender, EventArgs e)
        {
            URSModifyHoursEmployee modifyHours = new URSModifyHoursEmployee(this, employee, ID);
            modifyHours.Show();
        }
    }
}
