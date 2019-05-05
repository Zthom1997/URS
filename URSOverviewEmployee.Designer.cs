namespace URS
{
    partial class URSOverviewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URSOverviewEmployee));
            this.hourOverviewDataGrid = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.bookHoursButton = new System.Windows.Forms.Button();
            this.employeeDataButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UpdateHoursButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hourOverviewDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hourOverviewDataGrid
            // 
            this.hourOverviewDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hourOverviewDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hourOverviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hourOverviewDataGrid.Location = new System.Drawing.Point(2, 135);
            this.hourOverviewDataGrid.Name = "hourOverviewDataGrid";
            this.hourOverviewDataGrid.RowTemplate.Height = 24;
            this.hourOverviewDataGrid.Size = new System.Drawing.Size(955, 758);
            this.hourOverviewDataGrid.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(672, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(256, 46);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Welkom Tom";
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(7, 831);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(225, 62);
            this.logOutButton.TabIndex = 36;
            this.logOutButton.Text = "Uitloggen";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // bookHoursButton
            // 
            this.bookHoursButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bookHoursButton.ForeColor = System.Drawing.Color.White;
            this.bookHoursButton.Location = new System.Drawing.Point(3, 165);
            this.bookHoursButton.Name = "bookHoursButton";
            this.bookHoursButton.Size = new System.Drawing.Size(225, 64);
            this.bookHoursButton.TabIndex = 37;
            this.bookHoursButton.Text = "Uren boeken";
            this.bookHoursButton.UseVisualStyleBackColor = false;
            this.bookHoursButton.Click += new System.EventHandler(this.bookHoursButton_Click);
            // 
            // employeeDataButton
            // 
            this.employeeDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.employeeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeDataButton.ForeColor = System.Drawing.Color.White;
            this.employeeDataButton.Location = new System.Drawing.Point(3, 303);
            this.employeeDataButton.Name = "employeeDataButton";
            this.employeeDataButton.Size = new System.Drawing.Size(225, 62);
            this.employeeDataButton.TabIndex = 40;
            this.employeeDataButton.Text = "Medewerker gegevens";
            this.employeeDataButton.UseVisualStyleBackColor = false;
            this.employeeDataButton.Click += new System.EventHandler(this.employeeDataButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UpdateHoursButton);
            this.splitContainer1.Panel1.Controls.Add(this.employeeDataButton);
            this.splitContainer1.Panel1.Controls.Add(this.bookHoursButton);
            this.splitContainer1.Panel1.Controls.Add(this.logOutButton);
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
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 0;
            // 
            // UpdateHoursButton
            // 
            this.UpdateHoursButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateHoursButton.ForeColor = System.Drawing.Color.White;
            this.UpdateHoursButton.Location = new System.Drawing.Point(3, 235);
            this.UpdateHoursButton.Name = "UpdateHoursButton";
            this.UpdateHoursButton.Size = new System.Drawing.Size(226, 62);
            this.UpdateHoursButton.TabIndex = 41;
            this.UpdateHoursButton.Text = "Uren bijwerken";
            this.UpdateHoursButton.UseVisualStyleBackColor = false;
            this.UpdateHoursButton.Click += new System.EventHandler(this.UpdateHoursButton_Click);
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
            this.pictureBox2.Size = new System.Drawing.Size(221, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welkom Tom";
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
            // URSOverviewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 896);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "URSOverviewEmployee";
            this.Text = "URS ~ Overzicht";
            this.Load += new System.EventHandler(this.URSOverviewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourOverviewDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hourOverviewDataGrid;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button bookHoursButton;
        private System.Windows.Forms.Button employeeDataButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.Button UpdateHoursButton;
        private System.Windows.Forms.Label label1;
    }
}