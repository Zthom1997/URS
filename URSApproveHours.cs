using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using URS.Model;

namespace URS
{
    public partial class URSApproveHours : Form
    {
        int ID;
        List<Employee> Employees;
        Manager manager;
        public URSApproveHours(int _ID, Manager _manager)
        {
            ID = _ID;
            manager = _manager;
            InitializeComponent();
        }

        //Method to load initial settings of window
        private void URSApproveHours_Load(object sender, EventArgs e)
        {
            Employees = manager.ApproveHours(ID);
            foreach(Employee employee in Employees)
            {
                employeeComboBox.Items.Add(employee.employeeID);
            }
        }

        //Method to load datagrid with data from database
        public void LoadHoursInDataGrid(int _ID)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Medewerker-ID", typeof(int));
            table.Columns.Add("Activiteit-ID", typeof(int));
            table.Columns.Add("Datum", typeof(string));
            table.Columns.Add("Duur", typeof(float));
            table.Columns.Add("Locatie", typeof(string));
            table.Columns.Add("Goedgekeurd", typeof(string));
            table.Columns.Add("Omschrijving", typeof(string));
            table.Columns.Add("ID", typeof(int));

            //Fill Datagrid
            foreach(Employee employee in Employees)
            {
                if(employee.employeeID == _ID)
                {
                    foreach (Hour item in employee.Hours)
                    {
                        table.Rows.Add(item.employeeID, item.activityID, item.date, item.duration, item.location, item.approved, item.description, item.ID);
                    }
                }
            }

            dataGridHours.DataSource = table;
            dataGridHours.Refresh();
        }

        //Method to control combobox and data of Datagrid
        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear employeeTextbox if combobox is empty
            if (employeeComboBox.SelectedIndex == -1)
            {
                employeeTextBox.Text = "";

            }
            else
            {
                //Open local SQL-session to find name of employee with corresponding employee-ID
                //Show name of employee in employeeTextbox
                string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE employeeID ='" + employeeComboBox.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string id = (string)dr["employeeID"].ToString();
                    employeeComboBox.Text = id;

                    string name = (string)dr["firstName"].ToString() + " " + (string)dr["lastName"].ToString();
                    employeeTextBox.Text = name;
                }

            }

            //Fill datagrid with correct data from employee
            int employeeID = Int32.Parse(employeeComboBox.Text);
            LoadHoursInDataGrid(employeeID);
            InitItems();
        }

        //Method to add data from datagrid row to corresponding textboxes
        private void InitItems()
        {
            try
            {
                employeeIDTextBox.Text = dataGridHours[0, 0].Value.ToString();
                ActivityIDTextBox.Text = dataGridHours[1, 0].Value.ToString();
                dateTextBox.Text = dataGridHours[2, 0].Value.ToString();
                durationTextBox.Text = dataGridHours[3, 0].Value.ToString();
                locationTextBox.Text = dataGridHours[4, 0].Value.ToString();
                hoursApprovedTextBox.Text = dataGridHours[5, 0].Value.ToString();
                descriptionTextBox.Text = dataGridHours[6, 0].Value.ToString();
                IDTextBox.Text = dataGridHours[7, 0].Value.ToString();
            }
            catch
            {
                employeeIDTextBox.Clear();
                ActivityIDTextBox.Clear();
                dateTextBox.Clear();
                durationTextBox.Clear();
                locationTextBox.Clear();
                descriptionTextBox.Clear();
                hoursApprovedTextBox.Clear();
                IDTextBox.Clear();
            }
        }

        //Method to edit data in textboxes automatically if datagrid selection changes
        private void dataGridHours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                employeeIDTextBox.Text = dataGridHours[0, e.RowIndex].Value.ToString();
                ActivityIDTextBox.Text = dataGridHours[1, e.RowIndex].Value.ToString();
                dateTextBox.Text = dataGridHours[2, e.RowIndex].Value.ToString();
                durationTextBox.Text = dataGridHours[3, e.RowIndex].Value.ToString();
                locationTextBox.Text = dataGridHours[4, e.RowIndex].Value.ToString();
                hoursApprovedTextBox.Text = dataGridHours[5, e.RowIndex].Value.ToString();
                descriptionTextBox.Text = dataGridHours[6, e.RowIndex].Value.ToString();
                IDTextBox.Text = dataGridHours[7, e.RowIndex].Value.ToString();
            }
            catch
            {
                employeeIDTextBox.Clear();
                ActivityIDTextBox.Clear();
                dateTextBox.Clear();
                durationTextBox.Clear();
                locationTextBox.Clear();
                descriptionTextBox.Clear();
                hoursApprovedTextBox.Clear();
            }
        }

        //Method to activate the cancel button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Method to activate button to approve hours and refresh datagrid
        private void approveHoursButton_Click(object sender, EventArgs e)
        {
            string approved = "Ja";
            string hoursUpdated = manager.UpdateHours(Int32.Parse(IDTextBox.Text), approved);
            if (hoursUpdated == "Uren bijgewerkt")
            {
                RefreshData();
                employeeComboBox.Text = "1";
            }
            else
            {
                MessageBox.Show(hoursUpdated, "URS~Uren goedkeuren", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshData();
                employeeComboBox.Text = "1";
            }
        }

        //Method to refresh data of datagrid
        private void RefreshData()
        {
            DAL dal = new DAL();
            Employees = manager.ApproveHours(ID);
            LoadHoursInDataGrid(ID);
            InitItems();
        }
    }
}
