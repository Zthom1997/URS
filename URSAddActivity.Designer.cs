namespace URS
{
    partial class URSAddActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URSAddActivity));
            this.nameLabel_1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.nameActivityTextBox = new System.Windows.Forms.TextBox();
            this.activityCodeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.nameLabel_1.Size = new System.Drawing.Size(441, 50);
            this.nameLabel_1.TabIndex = 10;
            this.nameLabel_1.Text = "Activiteit toevoegen";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.addActivityButton);
            this.panel2.Controls.Add(this.nameActivityTextBox);
            this.panel2.Controls.Add(this.activityCodeTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(117, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 377);
            this.panel2.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.descriptionTextBox.Location = new System.Drawing.Point(196, 155);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(291, 28);
            this.descriptionTextBox.TabIndex = 13;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(169, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(220, 35);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addActivityButton
            // 
            this.addActivityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addActivityButton.ForeColor = System.Drawing.Color.White;
            this.addActivityButton.Location = new System.Drawing.Point(169, 263);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(220, 35);
            this.addActivityButton.TabIndex = 11;
            this.addActivityButton.Text = "Activiteit toevoegen";
            this.addActivityButton.UseVisualStyleBackColor = false;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // nameActivityTextBox
            // 
            this.nameActivityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameActivityTextBox.Location = new System.Drawing.Point(196, 107);
            this.nameActivityTextBox.Name = "nameActivityTextBox";
            this.nameActivityTextBox.Size = new System.Drawing.Size(291, 28);
            this.nameActivityTextBox.TabIndex = 9;
            this.nameActivityTextBox.TextChanged += new System.EventHandler(this.nameActivityTextBox_TextChanged);
            // 
            // activityCodeTextBox
            // 
            this.activityCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.activityCodeTextBox.Location = new System.Drawing.Point(196, 65);
            this.activityCodeTextBox.Name = "activityCodeTextBox";
            this.activityCodeTextBox.Size = new System.Drawing.Size(291, 28);
            this.activityCodeTextBox.TabIndex = 7;
            this.activityCodeTextBox.TextChanged += new System.EventHandler(this.activityCodeTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F);
            this.label6.Location = new System.Drawing.Point(97, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F);
            this.label5.Location = new System.Drawing.Point(23, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Naam activiteit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F);
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Omschrijving:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 348);
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
            // URSAddActivity
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
            this.Name = "URSAddActivity";
            this.Text = "URSAddActivity";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.TextBox nameActivityTextBox;
        private System.Windows.Forms.TextBox activityCodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}