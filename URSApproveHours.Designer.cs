namespace URS
{
    partial class URSApproveHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URSApproveHours));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel_1 = new System.Windows.Forms.Label();
            this.approveHoursButton = new System.Windows.Forms.Button();
            this.dataGridHours = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.ActivityIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.hoursApprovedTextBox = new System.Windows.Forms.TextBox();
            this.approvedHoursT = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHours)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::URS.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel_1
            // 
            this.nameLabel_1.AutoSize = true;
            this.nameLabel_1.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel_1.Location = new System.Drawing.Point(146, 9);
            this.nameLabel_1.Name = "nameLabel_1";
            this.nameLabel_1.Size = new System.Drawing.Size(267, 50);
            this.nameLabel_1.TabIndex = 25;
            this.nameLabel_1.Text = "Urenreview";
            // 
            // approveHoursButton
            // 
            this.approveHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.approveHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.approveHoursButton.ForeColor = System.Drawing.Color.White;
            this.approveHoursButton.Location = new System.Drawing.Point(713, 756);
            this.approveHoursButton.Name = "approveHoursButton";
            this.approveHoursButton.Size = new System.Drawing.Size(178, 35);
            this.approveHoursButton.TabIndex = 37;
            this.approveHoursButton.Text = "Goedkeuren";
            this.approveHoursButton.UseVisualStyleBackColor = false;
            this.approveHoursButton.Click += new System.EventHandler(this.approveHoursButton_Click);
            // 
            // dataGridHours
            // 
            this.dataGridHours.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHours.Location = new System.Drawing.Point(24, 216);
            this.dataGridHours.Name = "dataGridHours";
            this.dataGridHours.RowTemplate.Height = 24;
            this.dataGridHours.Size = new System.Drawing.Size(906, 240);
            this.dataGridHours.TabIndex = 39;
            this.dataGridHours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHours_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(51, 756);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(178, 35);
            this.closeButton.TabIndex = 40;
            this.closeButton.Text = "Venster sluiten";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(147, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Urenoverzicht medewerker";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Enabled = false;
            this.employeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.employeeIDTextBox.Location = new System.Drawing.Point(392, 471);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(499, 28);
            this.employeeIDTextBox.TabIndex = 44;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.descriptionTextBox.Location = new System.Drawing.Point(392, 644);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(499, 28);
            this.descriptionTextBox.TabIndex = 45;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Enabled = false;
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.locationTextBox.Location = new System.Drawing.Point(392, 607);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(499, 28);
            this.locationTextBox.TabIndex = 46;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Enabled = false;
            this.durationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.durationTextBox.Location = new System.Drawing.Point(392, 573);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(499, 28);
            this.durationTextBox.TabIndex = 47;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTextBox.Location = new System.Drawing.Point(392, 539);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(499, 28);
            this.dateTextBox.TabIndex = 48;
            // 
            // ActivityIDTextBox
            // 
            this.ActivityIDTextBox.Enabled = false;
            this.ActivityIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ActivityIDTextBox.Location = new System.Drawing.Point(392, 505);
            this.ActivityIDTextBox.Name = "ActivityIDTextBox";
            this.ActivityIDTextBox.Size = new System.Drawing.Size(499, 28);
            this.ActivityIDTextBox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(89, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Medewerker-ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(124, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Activiteit-ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(160, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(104, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Duur activiteit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(24, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Locatie (Thuis/Kantoor):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(104, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 57;
            this.label8.Text = "Omschrijving:";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(707, 155);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(223, 30);
            this.employeeComboBox.TabIndex = 58;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            // 
            // hoursApprovedTextBox
            // 
            this.hoursApprovedTextBox.Enabled = false;
            this.hoursApprovedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.hoursApprovedTextBox.Location = new System.Drawing.Point(392, 686);
            this.hoursApprovedTextBox.Name = "hoursApprovedTextBox";
            this.hoursApprovedTextBox.Size = new System.Drawing.Size(499, 28);
            this.hoursApprovedTextBox.TabIndex = 59;
            // 
            // approvedHoursT
            // 
            this.approvedHoursT.AutoSize = true;
            this.approvedHoursT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.approvedHoursT.Location = new System.Drawing.Point(54, 689);
            this.approvedHoursT.Name = "approvedHoursT";
            this.approvedHoursT.Size = new System.Drawing.Size(175, 24);
            this.approvedHoursT.TabIndex = 60;
            this.approvedHoursT.Text = "Uren goedgekeurd:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.IDTextBox.Location = new System.Drawing.Point(392, 722);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(499, 28);
            this.IDTextBox.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(85, 725);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "ID:";
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Enabled = false;
            this.employeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.employeeTextBox.Location = new System.Drawing.Point(24, 157);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(294, 28);
            this.employeeTextBox.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(24, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 64;
            this.label9.Text = "Medewerker:";
            // 
            // URSApproveHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(942, 803);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.employeeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.approvedHoursT);
            this.Controls.Add(this.hoursApprovedTextBox);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActivityIDTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridHours);
            this.Controls.Add(this.approveHoursButton);
            this.Controls.Add(this.nameLabel_1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "URSApproveHours";
            this.Text = "URSApproveHours";
            this.Load += new System.EventHandler(this.URSApproveHours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel_1;
        private System.Windows.Forms.Button approveHoursButton;
        private System.Windows.Forms.DataGridView dataGridHours;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox ActivityIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.TextBox hoursApprovedTextBox;
        private System.Windows.Forms.Label approvedHoursT;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.Label label9;
    }
}