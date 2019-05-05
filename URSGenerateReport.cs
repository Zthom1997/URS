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
    public partial class URSGenerateReport : Form
    {
        int ID;
        Manager manager;
        public URSGenerateReport(int _ID, Manager _manager)
        {
            ID = _ID;
            manager = _manager;
            InitializeComponent();
        }

        //Method to load the initial settings of the form
        private void URSGenerateReport_Load(object sender, EventArgs e)
        {
            reportsComboBox.Items.Add("Rapportage Bezettingsgraad");
            reportsComboBox.Items.Add("Rapportage Maandoverzicht");
        }

        //Method to activate the button to generate reports
        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            URSOverviewManager managerOverview = new URSOverviewManager(ID, manager);
            if(reportsComboBox.Text == "Rapportage Bezettingsgraad")
            {
                report.GenerateOccupancyRate();
                managerOverview.RefreshHourDataGrid();
            }
            else if(reportsComboBox.Text == "Rapportage Maandoverzicht")
            {
                report.GenerateApprovedHours();
                managerOverview.RefreshHourDataGrid();
            }
            else
            {
                MessageBox.Show("De gewenste rapportage is niet gevonden.", "URS~Rapportage genereren", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Method to activate the cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
