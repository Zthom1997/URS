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
    public partial class URSRegister : Form
    {
        int ID;
        Manager manager;
        public URSRegister(int _ID, Manager _manager)
        {
            ID = _ID;
            manager = _manager;
            InitializeComponent();
        }

        //Preload the URSRegister form
        private void URSRegister_Load(object sender, EventArgs e)
        {
            idTextBox.Text = ID.ToString();
            managerTextBox.Text = manager.firstName;
            kindComboBox.Items.Add("Intern");
            kindComboBox.Items.Add("Extern");
            workHomeComboBox.Items.Add("Ja");
            workHomeComboBox.Items.Add("Nee");

            string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT firstName from Employee", conn);
            conn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                firstNameComboBox.Items.Add(dr["firstName"].ToString());
            }
        }

        //Method to connect combobox to textboxes
        private void firstNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Employee WHERE firstName ='" + firstNameComboBox.Text + "'", conn);
            conn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string last_name = (string)dr["lastName"].ToString();
                lastNameTextBox.Text = last_name;

                string _position = (string)dr["position"].ToString();
                positionTextBox.Text = _position;

                string _manager = (string)dr["manager"].ToString();
                managerTextBox.Text = _manager;

                string _managerID = (string)dr["managedBy"].ToString();
                managerTextBox.Text = _managerID;

                string _kind = (string)dr["kind"].ToString();
                kindComboBox.Text = _kind;

                string contract_Hours = (string)dr["contractHours"].ToString();
                contractHoursTextBox.Text = contract_Hours;

                string _distance = (string)dr["distance"].ToString();
                distanceTextBox.Text = _distance;

                string work_Home = (string)dr["workHome"].ToString();
                workHomeComboBox.Text = work_Home;

                string _salary = (string)dr["salary"].ToString();
                salaryTextBox.Text = _salary;

                string _password = (string)dr["password"].ToString();
                passwordTextBox.Text = _password;
                confirmPasswordTextBox.Text = _password;
            }
        }

        //Methods to check if textboxes contain valid data
        private void firstNameComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(firstNameComboBox.Text, "^[a-zA-Z]"))
            {
                firstNameComboBox.Items.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen letters ingevoerd worden", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "^[a-zA-Z]"))
            {
                lastNameTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen letters ingevoerd worden", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void positionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(positionTextBox.Text, "^[a-zA-Z]"))
            {
                positionTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen letters ingevoerd worden", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void contractHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(contractHoursTextBox.Text, "^[0-9]"))
            {
                contractHoursTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen nummers ingevoerd worden", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void distanceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(distanceTextBox.Text, "^[0-9]"))
            {
                distanceTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen nummers ingevoerd worden", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(salaryTextBox.Text, "^[0-9]"))
            {
                salaryTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen nummers ingevoerd worden", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method to activate cancel button
        //Return to main screen if button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Button to activate register button
        //Check if all textboxes contain correct input
        //Use local SQL-session to determine if user is in the system already
        private void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=URS_Database;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT firstName from Employee WHERE firstName = @firstName", conn))
                {
                    if (string.IsNullOrWhiteSpace(firstNameComboBox.Text))
                    {
                        MessageBox.Show("Er is geen voornaam ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
                    {
                        MessageBox.Show("Er is geen achternaam ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(positionTextBox.Text))
                    {
                        MessageBox.Show("Er is geen functie ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(kindComboBox.Text))
                    {
                        MessageBox.Show("Er is niet ingevuld om medewerker intern-/extern is.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(contractHoursTextBox.Text))
                    {
                        MessageBox.Show("Het aantal contracturen is niet ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(distanceTextBox.Text))
                    {
                        MessageBox.Show("Er is geen werkafstand ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(workHomeComboBox.Text))
                    {
                        MessageBox.Show("Er is niet ingevuld of de medewerker thuis mag werken.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(salaryTextBox.Text))
                    {
                        MessageBox.Show("Er is geen salaris ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                    {
                        MessageBox.Show("Er is geen wachtwoord ingevuld.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (confirmPasswordTextBox.Text != passwordTextBox.Text)
                    {
                        MessageBox.Show("De wachtwoorden komen niet overeen.", "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        confirmPasswordTextBox.Clear();
                    }
                    else
                    {
                        //Check if employee exists in database 
                        //If employee exists, then call update method
                        cmd.Parameters.AddWithValue("@firstName", firstNameComboBox.Text);
                        conn.Open();
                        if (cmd.ExecuteScalar() != null)
                        {
                            string loginName = firstNameComboBox.Text.ToLower() + "." + lastNameTextBox.Text.ToLower();
                            string message = manager.UpdateEmployee(Int32.Parse(idTextBox.Text), firstNameComboBox.Text, lastNameTextBox.Text, positionTextBox.Text, managerTextBox.Text, kindComboBox.Text, float.Parse(contractHoursTextBox.Text), float.Parse(distanceTextBox.Text), workHomeComboBox.Text, float.Parse(salaryTextBox.Text), loginName, passwordTextBox.Text);
                            conn.Close();

                            if(message == "Medewerker is aangepast")
                            {
                                MessageBox.Show("Medewerker " + loginName + " is succesvol aangepast.", "URS ~ Medewerker registeren/wijzigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(message, "URS ~ Medewerker registeren/wijzigen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Create loginname and create employee
                            string loginName = firstNameComboBox.Text.ToLower() + "." + lastNameTextBox.Text.ToLower();
                            string employeeRegistered = manager.registerEmployee(Int32.Parse(idTextBox.Text), firstNameComboBox.Text, lastNameTextBox.Text, positionTextBox.Text, managerTextBox.Text, kindComboBox.Text, float.Parse(contractHoursTextBox.Text), float.Parse(distanceTextBox.Text), workHomeComboBox.Text, float.Parse(salaryTextBox.Text), loginName, passwordTextBox.Text);
                            if (employeeRegistered == "Medewerker is geregistreerd")
                            {
                                MessageBox.Show("Account voor " + firstNameComboBox.Text + " " + lastNameTextBox.Text + "is succesvol aangemaakt.\n Inlognaam is " + loginName, "URS ~ Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(employeeRegistered, "URS~Medewerker registeren", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                conn.Dispose();
            }
        }

        //Method to activate the delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string message = manager.DeleteEmployee(firstNameComboBox.Text);
            if(message == "Medewerker verwijderd")
            {
                MessageBox.Show("Medewerker " + firstNameComboBox.Text + " is succesvol verwijderd.", "URS ~ Medewerker verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "URS ~ Medewerker registeren/wijzigen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
