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
    public partial class URSOverviewManager : Form
    {
        int ID;
        Manager manager;

        public URSOverviewManager(int _ID, Manager _manager)
        {
            InitializeComponent();
            ID = _ID;
            manager = _manager;
        }

        //Method to load initial settings of form
        private void URSOverviewManager_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Welkom " + manager.firstName;
            RefreshHourDataGrid();
            hourOverviewDataGrid.Columns[6].MinimumWidth = 700;
            hourOverviewDataGrid.Enabled = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            RefreshWeeklyHours();
        }

        //Method to refresh the worked hours per week with help of a local DAL-session
        public void RefreshWeeklyHours()
        {
            DAL dal = new DAL();
            float hoursWorked = dal.GetWeeklyHours(ID);
            label1.Text = "U heeft deze week " + hoursWorked.ToString() + " uur gewerkt.";

            if(hoursWorked > 60)
            {
                MessageBox.Show("U heeft meer dan 60 uur gewerkt deze week.\nU kunt geen nieuwe uren meer boeken.", "URS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bookHoursButton.Enabled = false;
            }
            else
            {
                bookHoursButton.Enabled = true;
            }
        }

        //Method to refresh the datagrid
        public void RefreshHourDataGrid()
       {
            string dataAvailable = manager.ViewHours(manager, ID);
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
                for (int i = 0; i < manager.Hours.Count; i++)
                {
                    table.Rows.Add(manager.Hours[i].ID, manager.Hours[i].activityID, manager.Hours[i].date,
                       manager.Hours[i].duration, manager.Hours[i].location, manager.Hours[i].approved, manager.Hours[i].description);
                }

                //Synchronize datagrid to table and database
                //Refresh datagrid
                hourOverviewDataGrid.DataSource = table;
                hourOverviewDataGrid.Refresh();
                hourOverviewDataGrid.Columns[6].MinimumWidth = 700;
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

        //Method to activate logout button
        private void logOutButton_Click(object sender, EventArgs e)
        {
            URSLogin login = new URSLogin();
            this.Hide();
            login.Show();
        }

        //Method to activate employee data button
        private void employeeDataButton_Click(object sender, EventArgs e)
        {
            URSViewDataManager viewData = new URSViewDataManager(ID, manager);
            viewData.Show();
        }

        //Method to activate button to register employee
        private void registerEmployeeButton_Click(object sender, EventArgs e)
        {
            URSRegister registerEmployee = new URSRegister(ID, manager);
            registerEmployee.Show();
        }

        //Method to activate button to book hours
        private void bookHoursButton_Click(object sender, EventArgs e)
        {
            URSAddHoursManager addHours = new URSAddHoursManager(ID, this, manager);
            addHours.Show();
        }

        //Method to activate button to add activity
        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            URSAddActivity addActivity = new URSAddActivity(manager);
            addActivity.Show();
        }

        //Method to activate the button to approve hours
        private void approveHoursButton_Click(object sender, EventArgs e)
        {
            URSApproveHours approveHours = new URSApproveHours(ID, manager);
            approveHours.Show();
        }

        //Method to activate the button to edit hours
        private void editHoursButton_Click(object sender, EventArgs e)
        {
            URSModifyHoursManager modifyHours = new URSModifyHoursManager(this, manager, ID);
            modifyHours.Show();
        }

        //Method to activate the button to generate a report
        private void generateReportButton_Click(object sender, EventArgs e)
        {
            URSGenerateReport generateReport = new URSGenerateReport(ID, manager);
            generateReport.Show();
        }
    }
}
