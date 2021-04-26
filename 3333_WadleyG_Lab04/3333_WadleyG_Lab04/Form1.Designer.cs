namespace _3333_WadleyG_Lab04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleSpeedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTraveledTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTripsLabel = new System.Windows.Forms.Label();
            this.totalHoursTraveledLabel = new System.Windows.Forms.Label();
            this.totalDistanceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgDistanceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.distanceListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicle speed in MPH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hours Traveled:";
            // 
            // vehicleSpeedTextBox
            // 
            this.vehicleSpeedTextBox.Location = new System.Drawing.Point(168, 6);
            this.vehicleSpeedTextBox.Name = "vehicleSpeedTextBox";
            this.vehicleSpeedTextBox.Size = new System.Drawing.Size(100, 22);
            this.vehicleSpeedTextBox.TabIndex = 0;
            // 
            // hoursTraveledTextBox
            // 
            this.hoursTraveledTextBox.Location = new System.Drawing.Point(168, 38);
            this.hoursTraveledTextBox.Name = "hoursTraveledTextBox";
            this.hoursTraveledTextBox.Size = new System.Drawing.Size(100, 22);
            this.hoursTraveledTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTripsLabel);
            this.groupBox1.Controls.Add(this.totalHoursTraveledLabel);
            this.groupBox1.Controls.Add(this.totalDistanceLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary:";
            // 
            // totalTripsLabel
            // 
            this.totalTripsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.totalTripsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalTripsLabel.Location = new System.Drawing.Point(193, 80);
            this.totalTripsLabel.Name = "totalTripsLabel";
            this.totalTripsLabel.Size = new System.Drawing.Size(100, 23);
            this.totalTripsLabel.TabIndex = 5;
            // 
            // totalHoursTraveledLabel
            // 
            this.totalHoursTraveledLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.totalHoursTraveledLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalHoursTraveledLabel.Location = new System.Drawing.Point(193, 55);
            this.totalHoursTraveledLabel.Name = "totalHoursTraveledLabel";
            this.totalHoursTraveledLabel.Size = new System.Drawing.Size(100, 23);
            this.totalHoursTraveledLabel.TabIndex = 4;
            // 
            // totalDistanceLabel
            // 
            this.totalDistanceLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.totalDistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDistanceLabel.Location = new System.Drawing.Point(193, 29);
            this.totalDistanceLabel.Name = "totalDistanceLabel";
            this.totalDistanceLabel.Size = new System.Drawing.Size(100, 23);
            this.totalDistanceLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Trips:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Hours Traveled:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Distance:";
            // 
            // avgDistanceLabel
            // 
            this.avgDistanceLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.avgDistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgDistanceLabel.Location = new System.Drawing.Point(208, 359);
            this.avgDistanceLabel.Name = "avgDistanceLabel";
            this.avgDistanceLabel.Size = new System.Drawing.Size(100, 23);
            this.avgDistanceLabel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Average Distance:";
            // 
            // calculateButton
            // 
            this.calculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculateButton.Location = new System.Drawing.Point(55, 405);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 33);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(180, 405);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 33);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(294, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceListBox
            // 
            this.distanceListBox.FormattingEnabled = true;
            this.distanceListBox.ItemHeight = 16;
            this.distanceListBox.Location = new System.Drawing.Point(15, 67);
            this.distanceListBox.Name = "distanceListBox";
            this.distanceListBox.Size = new System.Drawing.Size(410, 148);
            this.distanceListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.distanceListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.avgDistanceLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hoursTraveledTextBox);
            this.Controls.Add(this.vehicleSpeedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vehicleSpeedTextBox;
        private System.Windows.Forms.TextBox hoursTraveledTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalTripsLabel;
        private System.Windows.Forms.Label totalHoursTraveledLabel;
        private System.Windows.Forms.Label totalDistanceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avgDistanceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox distanceListBox;
    }
}

