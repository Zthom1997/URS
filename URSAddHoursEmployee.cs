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
    public partial class URSAddHoursEmployee : Form
    {
        DAL dal = new DAL();
        List<Activity> Activities;
        URSOverviewEmployee employeeOverview;
        Employee employee;
        int ID;

        public URSAddHoursEmployee(int _ID, URSOverviewEmployee _employeeOverview, Employee _employee)
        {
            ID = _ID;
            employeeOverview = _employeeOverview;
            employee = _employee;
            InitializeComponent();
        }

        //Method to load initial settings of window
        private void URSAddHoursEmployee_Load(object sender, EventArgs e)
        {
            Activities = dal.ShowActivities();
            employeeIDTextBox.Text = ID.ToString();
            locationComboBox.Items.Add("Thuis");
            locationComboBox.Items.Add("Kantoor");

            foreach (Activity item in Activities)
            {
                nameOfActivityComboBox.Items.Add(item.name);
            }
        }

        //Method to check if textbox does contain valid data
        private void numberOfHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(numberOfHoursTextBox.Text, "^[0-9]"))
            {
                MessageBox.Show("In dit veld mogen alleen getallen worden ingevoerd.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberOfHoursTextBox.Clear();
            }
        }

        //Method to synchronize combobox with textbox
        //Local connection to database via Data Access Layer to available activities

        //Method to activate button to add hours
        private void addHoursButton_Click(object sender, EventArgs e)
        {
            //Check if textboxes contain data and are not empty
            if (string.IsNullOrWhiteSpace(nameOfActivityComboBox.Text))
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
                string hoursAdded = employee.AddHours(Int32.Parse(employeeIDTextBox.Text), Int32.Parse(IDOfActivityTextBox.Text), dateTimePicker.Text, float.Parse(numberOfHoursTextBox.Text), locationComboBox.Text, descriptionTextBox.Text);
                if (hoursAdded == "Uren toegevoegd")
                {
                    MessageBox.Show("De uren van " + dateTimePicker.Text + " zijn toegevoegd", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    employeeOverview.RefreshHourDataGrid();
                    employeeOverview.RefreshWeeklyHours();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(hoursAdded, "URS~Uren toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Method to activate cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void activityIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make textbox empty
            if (nameOfActivityComboBox.SelectedIndex == -1)
            {
                IDOfActivityTextBox.Text = "";

            }
            else
            {
                //Synchronize textbox with dropbox by appropriate Activity-ID
                //Local connection to Data Access Layer and database
                string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Activity WHERE name ='" + nameOfActivityComboBox.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string name = (string)dr["name"].ToString();
                    nameOfActivityComboBox.Text = name;

                    string id = (string)dr["activityID"].ToString();
                    IDOfActivityTextBox.Text = id;
                }

            }
        }
    }
}
