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
using System.Data.SqlClient;

namespace URS
{
    public partial class URSAddHoursManager : Form
    {
        DAL dal = new DAL();
        List<Activity> Activities;
        URSOverviewManager managerOverview;
        Manager manager;
        int ID;

        public URSAddHoursManager(int _ID, URSOverviewManager _managerOverview, Manager _manager)
        {
            InitializeComponent();
            managerOverview = _managerOverview;
            manager = _manager;
            ID = _ID;
        }

        //Initial settings when form is loaded
        private void URSAddHours_Load(object sender, EventArgs e)
        {
            Activities = dal.ShowActivities();
            employeeIDTextBox.Text = ID.ToString();
            locationComboBox.Items.Add("Thuis");
            locationComboBox.Items.Add("Kantoor");

            foreach(Activity item in Activities)
            {
                nameOfActivityComboBox.Items.Add(item.name);
            }
        }

        //Method to synchronize combobox and textbox with available activitydata
        //Use local databaseconnection to synchronize combobox with textbox
        private void activityIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameOfActivityComboBox.SelectedIndex == -1)
            {
                IDOfActivityTextBox.Text = "";

            }
            else
            {
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

        //Check if textbox contains invalid data type
        private void numberOfHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(numberOfHoursTextBox.Text, "^[0-9]"))
            {
                MessageBox.Show("In dit veld mogen alleen getallen worden ingevoerd.", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberOfHoursTextBox.Clear();
            }
        }

        //Method to activate cancelbutton
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Method to activate button to add hours to the database
        //Check if textboxes contain data before proceeding
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
                string hoursAdded = manager.AddHours(Int32.Parse(employeeIDTextBox.Text), Int32.Parse(IDOfActivityTextBox.Text), dateTimePicker.Text, float.Parse(numberOfHoursTextBox.Text), locationComboBox.Text, descriptionTextBox.Text);
                if (hoursAdded == "Uren toegevoegd")
                {
                    MessageBox.Show("De uren van " + dateTimePicker.Text + " zijn toegevoegd", "URS ~ Uren boeken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    managerOverview.RefreshHourDataGrid();
                    managerOverview.RefreshWeeklyHours();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(hoursAdded, "URS ~ Uren toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
