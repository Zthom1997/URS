namespace URS
{
    partial class URSOverviewManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URSOverviewManager));
            this.applicationLabel = new System.Windows.Forms.Label();
            this.employeeDataButton = new System.Windows.Forms.Button();
            this.editHoursButton = new System.Windows.Forms.Button();
            this.bookHoursButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.AddActivityButton = new System.Windows.Forms.Button();
            this.approveHoursButton = new System.Windows.Forms.Button();
            this.registerEmployeeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hourOverviewDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourOverviewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationLabel.Location = new System.Drawing.Point(3, 61);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(440, 71);
            this.applicationLabel.TabIndex = 4;
            this.applicationLabel.Text = "Urenoverzicht";
            // 
            // employeeDataButton
            // 
            this.employeeDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.employeeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeDataButton.ForeColor = System.Drawing.Color.White;
            this.employeeDataButton.Location = new System.Drawing.Point(5, 507);
            this.employeeDataButton.Name = "employeeDataButton";
            this.employeeDataButton.Size = new System.Drawing.Size(263, 73);
            this.employeeDataButton.TabIndex = 40;
            this.employeeDataButton.Text = "Medewerker gegevens";
            this.employeeDataButton.UseVisualStyleBackColor = false;
            this.employeeDataButton.Click += new System.EventHandler(this.employeeDataButton_Click);
            // 
            // editHoursButton
            // 
            this.editHoursButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editHoursButton.ForeColor = System.Drawing.Color.White;
            this.editHoursButton.Location = new System.Drawing.Point(7, 220);
            this.editHoursButton.Name = "editHoursButton";
            this.editHoursButton.Size = new System.Drawing.Size(259, 62);
            this.editHoursButton.TabIndex = 38;
            this.editHoursButton.Text = "Uren wijzigen";
            this.editHoursButton.UseVisualStyleBackColor = false;
            this.editHoursButton.Click += new System.EventHandler(this.editHoursButton_Click);
            // 
            // bookHoursButton
            // 
            this.bookHoursButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bookHoursButton.ForeColor = System.Drawing.Color.White;
            this.bookHoursButton.Location = new System.Drawing.Point(9, 152);
            this.bookHoursButton.Name = "bookHoursButton";
            this.bookHoursButton.Size = new System.Drawing.Size(259, 62);
            this.bookHoursButton.TabIndex = 37;
            this.bookHoursButton.Text = "Uren boeken";
            this.bookHoursButton.UseVisualStyleBackColor = false;
            this.bookHoursButton.Click += new System.EventHandler(this.bookHoursButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(0, 831);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(268, 62);
            this.logOutButton.TabIndex = 36;
            this.logOutButton.Text = "Uitloggen";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(633, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(256, 46);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Welkom Tom";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.generateReportButton);
            this.splitContainer1.Panel1.Controls.Add(this.logOutButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddActivityButton);
            this.splitContainer1.Panel1.Controls.Add(this.approveHoursButton);
            this.splitContainer1.Panel1.Controls.Add(this.employeeDataButton);
            this.splitContainer1.Panel1.Controls.Add(this.registerEmployeeButton);
            this.splitContainer1.Panel1.Controls.Add(this.editHoursButton);
            this.splitContainer1.Panel1.Controls.Add(this.bookHoursButton);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.applicationLabel);
            this.splitContainer1.Panel2.Controls.Add(this.hourOverviewDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 896);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 1;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generateReportButton.ForeColor = System.Drawing.Color.White;
            this.generateReportButton.Location = new System.Drawing.Point(5, 586);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(263, 73);
            this.generateReportButton.TabIndex = 44;
            this.generateReportButton.Text = "Rapportage genereren";
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // AddActivityButton
            // 
            this.AddActivityButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddActivityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddActivityButton.ForeColor = System.Drawing.Color.White;
            this.AddActivityButton.Location = new System.Drawing.Point(5, 434);
            this.AddActivityButton.Name = "AddActivityButton";
            this.AddActivityButton.Size = new System.Drawing.Size(263, 67);
            this.AddActivityButton.TabIndex = 43;
            this.AddActivityButton.Text = "Activiteiten toevoegen";
            this.AddActivityButton.UseVisualStyleBackColor = false;
            this.AddActivityButton.Click += new System.EventHandler(this.AddActivityButton_Click);
            // 
            // approveHoursButton
            // 
            this.approveHoursButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approveHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.approveHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.approveHoursButton.ForeColor = System.Drawing.Color.White;
            this.approveHoursButton.Location = new System.Drawing.Point(7, 288);
            this.approveHoursButton.Name = "approveHoursButton";
            this.approveHoursButton.Size = new System.Drawing.Size(259, 67);
            this.approveHoursButton.TabIndex = 42;
            this.approveHoursButton.Text = "Uren goedkeuren";
            this.approveHoursButton.UseVisualStyleBackColor = false;
            this.approveHoursButton.Click += new System.EventHandler(this.approveHoursButton_Click);
            // 
            // registerEmployeeButton
            // 
            this.registerEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registerEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.registerEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerEmployeeButton.Location = new System.Drawing.Point(6, 361);
            this.registerEmployeeButton.Name = "registerEmployeeButton";
            this.registerEmployeeButton.Size = new System.Drawing.Size(260, 67);
            this.registerEmployeeButton.TabIndex = 41;
            this.registerEmployeeButton.Text = "Medewerker registeren";
            this.registerEmployeeButton.UseVisualStyleBackColor = false;
            this.registerEmployeeButton.Click += new System.EventHandler(this.registerEmployeeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::URS.Properties.Resources.calendar;
            this.pictureBox2.Location = new System.Drawing.Point(7, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welkom Tom";
            // 
            // hourOverviewDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.hourOverviewDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hourOverviewDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hourOverviewDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hourOverviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hourOverviewDataGrid.Location = new System.Drawing.Point(3, 138);
            this.hourOverviewDataGrid.Name = "hourOverviewDataGrid";
            this.hourOverviewDataGrid.RowTemplate.Height = 24;
            this.hourOverviewDataGrid.Size = new System.Drawing.Size(908, 809);
            this.hourOverviewDataGrid.TabIndex = 0;
            // 
            // URSOverviewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 896);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "URSOverviewManager";
            this.Text = "URS~Overzicht";
            this.Load += new System.EventHandler(this.URSOverviewManager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourOverviewDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.Button employeeDataButton;
        private System.Windows.Forms.Button editHoursButton;
        private System.Windows.Forms.Button bookHoursButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView hourOverviewDataGrid;
        private System.Windows.Forms.Button AddActivityButton;
        private System.Windows.Forms.Button approveHoursButton;
        private System.Windows.Forms.Button registerEmployeeButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label label1;
    }
}