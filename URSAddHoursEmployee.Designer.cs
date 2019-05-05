﻿namespace URS
{
    partial class URSAddHoursEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URSAddHoursEmployee));
            this.nameLabel_1 = new System.Windows.Forms.Label();
            this.numberOfHoursTextBox = new System.Windows.Forms.TextBox();
            this.addHoursButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.IDOfActivityTextBox = new System.Windows.Forms.TextBox();
            this.nameOfActivityComboBox = new System.Windows.Forms.ComboBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRS_DatabaseDataSet = new URS.URS_DatabaseDataSet();
            this.cancelButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.activityTableAdapter = new URS.URS_DatabaseDataSetTableAdapters.ActivityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRS_DatabaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel_1
            // 
            this.nameLabel_1.AutoSize = true;
            this.nameLabel_1.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel_1.Location = new System.Drawing.Point(155, 70);
            this.nameLabel_1.Name = "nameLabel_1";
            this.nameLabel_1.Size = new System.Drawing.Size(288, 50);
            this.nameLabel_1.TabIndex = 10;
            this.nameLabel_1.Text = "Uren boeken";
            // 
            // numberOfHoursTextBox
            // 
            this.numberOfHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfHoursTextBox.Location = new System.Drawing.Point(196, 196);
            this.numberOfHoursTextBox.Name = "numberOfHoursTextBox";
            this.numberOfHoursTextBox.Size = new System.Drawing.Size(291, 28);
            this.numberOfHoursTextBox.TabIndex = 18;
            this.numberOfHoursTextBox.TextChanged += new System.EventHandler(this.numberOfHoursTextBox_TextChanged);
            // 
            // addHoursButton
            // 
            this.addHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addHoursButton.ForeColor = System.Drawing.Color.White;
            this.addHoursButton.Location = new System.Drawing.Point(196, 345);
            this.addHoursButton.Name = "addHoursButton";
            this.addHoursButton.Size = new System.Drawing.Size(178, 35);
            this.addHoursButton.TabIndex = 17;
            this.addHoursButton.Text = "Uren boeken";
            this.addHoursButton.UseVisualStyleBackColor = false;
            this.addHoursButton.Click += new System.EventHandler(this.addHoursButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(49, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Omschrijving:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.descriptionTextBox.Location = new System.Drawing.Point(196, 296);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(291, 28);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // IDOfActivityTextBox
            // 
            this.IDOfActivityTextBox.Enabled = false;
            this.IDOfActivityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.IDOfActivityTextBox.Location = new System.Drawing.Point(429, 96);
            this.IDOfActivityTextBox.Name = "IDOfActivityTextBox";
            this.IDOfActivityTextBox.Size = new System.Drawing.Size(58, 28);
            this.IDOfActivityTextBox.TabIndex = 14;
            // 
            // nameOfActivityComboBox
            // 
            this.nameOfActivityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activityBindingSource, "ActivityID", true));
            this.nameOfActivityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameOfActivityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameOfActivityComboBox.FormattingEnabled = true;
            this.nameOfActivityComboBox.Location = new System.Drawing.Point(196, 96);
            this.nameOfActivityComboBox.Name = "nameOfActivityComboBox";
            this.nameOfActivityComboBox.Size = new System.Drawing.Size(201, 30);
            this.nameOfActivityComboBox.TabIndex = 13;
            this.nameOfActivityComboBox.SelectedIndexChanged += new System.EventHandler(this.activityIDComboBox_SelectedIndexChanged);
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.uRS_DatabaseDataSet;
            // 
            // uRS_DatabaseDataSet
            // 
            this.uRS_DatabaseDataSet.DataSetName = "URS_DatabaseDataSet";
            this.uRS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(196, 386);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(178, 35);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(196, 245);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(291, 30);
            this.locationComboBox.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(196, 149);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(291, 28);
            this.dateTimePicker.TabIndex = 8;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Enabled = false;
            this.employeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.employeeIDTextBox.Location = new System.Drawing.Point(196, 46);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(291, 28);
            this.employeeIDTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F);
            this.label6.Location = new System.Drawing.Point(48, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Activiteit ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F);
            this.label5.Location = new System.Drawing.Point(88, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F);
            this.label4.Location = new System.Drawing.Point(49, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aantal uren:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(81, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locatie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medewerker ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.numberOfHoursTextBox);
            this.panel2.Controls.Add(this.addHoursButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.IDOfActivityTextBox);
            this.panel2.Controls.Add(this.nameOfActivityComboBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.locationComboBox);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.employeeIDTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 424);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 342);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::URS.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // URSAddHoursEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.nameLabel_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "URSAddHoursEmployee";
            this.Text = "URSAddHoursEmployee";
            this.Load += new System.EventHandler(this.URSAddHoursEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRS_DatabaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox numberOfHoursTextBox;
        private System.Windows.Forms.Button addHoursButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox IDOfActivityTextBox;
        private System.Windows.Forms.ComboBox nameOfActivityComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private URS_DatabaseDataSet uRS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private URS_DatabaseDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
    }
}