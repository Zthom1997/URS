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
    public partial class URSAddActivity : Form
    {
        Manager manager;   
        public URSAddActivity(Manager _manager)
        {
            manager = _manager;
            InitializeComponent();
        }

        //Methods to check if textboxes contain valid data
        private void activityCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(activityCodeTextBox.Text, "^[0-9]"))
            {
                activityCodeTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen getallen worden ingevoerd.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nameActivityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(nameActivityTextBox.Text, "^[a-zA-z]"))
            {
                nameActivityTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen letters worden ingevoerd.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(descriptionTextBox.Text, "^[a-zA-z]"))
            {
                descriptionTextBox.Clear();
                MessageBox.Show("In dit invoerveld mogen alleen letters worden ingevoerd.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method to activate cancel button 
        //Close Window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Method to activate button to add a new activity
        //Check if textbox is not empty before processing
        private void addActivityButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(activityCodeTextBox.Text))
            {
                MessageBox.Show("De activiteitcode is niet ingevuld.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(nameActivityTextBox.Text))
            {
                MessageBox.Show("De naam van de activiteit is niet ingevuld.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Er is geen omschrijving van de activiteit ingevoerd.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string activityAdded = manager.AddActivity(Int32.Parse(activityCodeTextBox.Text), nameActivityTextBox.Text, descriptionTextBox.Text);
                if (activityAdded == "Activiteit toegevoegd")
                {
                    MessageBox.Show("Activiteit " + nameActivityTextBox.Text + " is aangemaakt.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Activiteit kon niet toegevoegd worden. Geef de volgende foutmelding door aan uw beheerder.", "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(activityAdded, "URS ~ Activiteit toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
