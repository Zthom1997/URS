using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using URS.Model;

namespace URS
{
    public partial class URSModifyHoursEmployee : Form
    {
        DAL dal = new DAL();
        List<Activity> Activities;
        URSOverviewEmployee employeeOverview;
        Employee employee;
        int ID;

        public URSModifyHoursEmployee(URSOverviewEmployee _employeeOverview, Employee _employee, int _ID)
        {
            ID = _ID;
            employeeOverview = _employeeOverview;
            employee = _employee;
            InitializeComponent();
        }
        //Method to load window with initial settings
        private void URSModifyHoursEmployee_Load(object sender, EventArgs e)
        {
            Activities = dal.ShowActivities();
            locationComboBox.Items.Add("Thuis");
            locationComboBox.Items.Add("Kantoor");

            foreach (Hour hour in employee.Hours)
            {
                updateHoursComboBox.Items.Add(hour.ID);
            }

            foreach (Activity activity in Activities)
            {
                activityIDComboBox.Items.Add(activity.activityID);
            }
        }

        //Method to check if textbox has invalid data
        private void numberOfHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(numberOfHoursTextBox.Text, "^[0-9]"))
            {
                MessageBox.Show("In dit veld mogen alleen getallen worden ingevoerd.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberOfHoursTextBox.Clear();
            }
        }

        //Method to sync comboboxes to textboxes with help of a local connection to the database
        private void updateHoursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Hours WHERE ID ='" + updateHoursComboBox.Text + "'", conn);
            conn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string employeeID = (string)dr["employeeID"].ToString();
                employeeIDTextBox.Text = employeeID;

                string activityID = (string)dr["activityID"].ToString();
                activityIDComboBox.Text = activityID;

                string date = (string)dr["date"].ToString();
                dateTimePicker.Text = date;

                string duration = (string)dr["duration"].ToString();
                numberOfHoursTextBox.Text = duration;

                string location = (string)dr["location"].ToString();
                locationComboBox.Text = location;

                string description = (string)dr["description"].ToString();
                descriptionTextBox.Text = description;
            }
            conn.Close();
        }

        //Method to sync combobox to textboxes
        private void activityIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Activity WHERE activityID ='" + activityIDComboBox.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader drActivity;
            drActivity = cmd.ExecuteReader();
            while (drActivity.Read())
            {
                string id = (string)drActivity["activityID"].ToString();
                activityIDComboBox.Text = id;

                string name = (string)drActivity["name"].ToString();
                nameOfActivityTextBox.Text = name;
            }
        }

        //Method to activate the button to update hours and also refresh it in the database
        private void updateHoursButton_Click(object sender, EventArgs e)
        {
            //Check if textboxes contain data and are not empty
            if (string.IsNullOrWhiteSpace(nameOfActivityTextBox.Text))
            {
                MessageBox.Show("De activiteit-ID is niet ingevuld.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(numberOfHoursTextBox.Text))
            {
                MessageBox.Show("Het aantal uren is niet ingevuld.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(locationComboBox.Text))
            {
                MessageBox.Show("Er is geen locatie ingevuld.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Er is geen omschrijving van de activiteit ingevuld.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = employee.ModifyHours(Int32.Parse(updateHoursComboBox.Text), Int32.Parse(employeeIDTextBox.Text), Int32.Parse(activityIDComboBox.Text), dateTimePicker.Text, float.Parse(numberOfHoursTextBox.Text), locationComboBox.Text, descriptionTextBox.Text);
                if (message == "Uren zijn bijgewerkt")
                {
                    MessageBox.Show("De uren van boeking-ID " + updateHoursComboBox.Text + " zijn bijgewerkt", "URS ~ Uren wijzigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    employeeOverview.RefreshHourDataGrid();
                    employeeOverview.RefreshWeeklyHours();
                }
                else
                {
                    MessageBox.Show(message, "URS ~ Uren wijzigen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Method to cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
