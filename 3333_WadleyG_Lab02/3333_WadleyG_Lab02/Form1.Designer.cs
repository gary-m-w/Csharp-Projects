namespace _3333_WadleyG_Lab02
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
            this.ticketsSoldBox = new System.Windows.Forms.GroupBox();
            this.totalTicketsOutputLabel = new System.Windows.Forms.Label();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.totalTicketsLabel = new System.Windows.Forms.Label();
            this.classCTicketsLabel = new System.Windows.Forms.Label();
            this.classATicketsLabel = new System.Windows.Forms.Label();
            this.classBTicketsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.revenueGeneratedBox = new System.Windows.Forms.GroupBox();
            this.totalRevOutputLabel = new System.Windows.Forms.Label();
            this.classCRevOutputLabel = new System.Windows.Forms.Label();
            this.classBRevOutputLabel = new System.Windows.Forms.Label();
            this.classARevOutputLabel = new System.Windows.Forms.Label();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.classCRevenueLabel = new System.Windows.Forms.Label();
            this.classBRevenueLabel = new System.Windows.Forms.Label();
            this.classARevenueLabel = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.transactionsOutputLabel = new System.Windows.Forms.Label();
            this.sumTicketsOutputLabel = new System.Windows.Forms.Label();
            this.sumRevOutputLabel = new System.Windows.Forms.Label();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.sumTicketsLabel = new System.Windows.Forms.Label();
            this.sumRevLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldBox.SuspendLayout();
            this.revenueGeneratedBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldBox
            // 
            this.ticketsSoldBox.Controls.Add(this.totalTicketsOutputLabel);
            this.ticketsSoldBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldBox.Controls.Add(this.classATextBox);
            this.ticketsSoldBox.Controls.Add(this.totalTicketsLabel);
            this.ticketsSoldBox.Controls.Add(this.classCTicketsLabel);
            this.ticketsSoldBox.Controls.Add(this.classATicketsLabel);
            this.ticketsSoldBox.Controls.Add(this.classBTicketsLabel);
            this.ticketsSoldBox.Controls.Add(this.label1);
            this.ticketsSoldBox.Location = new System.Drawing.Point(12, 23);
            this.ticketsSoldBox.Name = "ticketsSoldBox";
            this.ticketsSoldBox.Size = new System.Drawing.Size(428, 236);
            this.ticketsSoldBox.TabIndex = 0;
            this.ticketsSoldBox.TabStop = false;
            this.ticketsSoldBox.Text = "Tickets Sold";
            // 
            // totalTicketsOutputLabel
            // 
            this.totalTicketsOutputLabel.AutoEllipsis = true;
            this.totalTicketsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalTicketsOutputLabel.Location = new System.Drawing.Point(213, 183);
            this.totalTicketsOutputLabel.Name = "totalTicketsOutputLabel";
            this.totalTicketsOutputLabel.Size = new System.Drawing.Size(148, 23);
            this.totalTicketsOutputLabel.TabIndex = 8;
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(213, 145);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(148, 22);
            this.classCTextBox.TabIndex = 7;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(213, 107);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(148, 22);
            this.classBTextBox.TabIndex = 6;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(213, 69);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(148, 22);
            this.classATextBox.TabIndex = 5;
            // 
            // totalTicketsLabel
            // 
            this.totalTicketsLabel.AutoSize = true;
            this.totalTicketsLabel.Location = new System.Drawing.Point(52, 183);
            this.totalTicketsLabel.Name = "totalTicketsLabel";
            this.totalTicketsLabel.Size = new System.Drawing.Size(93, 17);
            this.totalTicketsLabel.TabIndex = 4;
            this.totalTicketsLabel.Text = "Total Tickets:";
            // 
            // classCTicketsLabel
            // 
            this.classCTicketsLabel.AutoSize = true;
            this.classCTicketsLabel.Location = new System.Drawing.Point(52, 145);
            this.classCTicketsLabel.Name = "classCTicketsLabel";
            this.classCTicketsLabel.Size = new System.Drawing.Size(59, 17);
            this.classCTicketsLabel.TabIndex = 3;
            this.classCTicketsLabel.Text = "Class C:";
            // 
            // classATicketsLabel
            // 
            this.classATicketsLabel.AutoSize = true;
            this.classATicketsLabel.Location = new System.Drawing.Point(52, 75);
            this.classATicketsLabel.Name = "classATicketsLabel";
            this.classATicketsLabel.Size = new System.Drawing.Size(59, 17);
            this.classATicketsLabel.TabIndex = 1;
            this.classATicketsLabel.Text = "Class A:";
            // 
            // classBTicketsLabel
            // 
            this.classBTicketsLabel.AutoSize = true;
            this.classBTicketsLabel.Location = new System.Drawing.Point(52, 107);
            this.classBTicketsLabel.Name = "classBTicketsLabel";
            this.classBTicketsLabel.Size = new System.Drawing.Size(59, 17);
            this.classBTicketsLabel.TabIndex = 2;
            this.classBTicketsLabel.Text = "Class B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // revenueGeneratedBox
            // 
            this.revenueGeneratedBox.Controls.Add(this.totalRevOutputLabel);
            this.revenueGeneratedBox.Controls.Add(this.classCRevOutputLabel);
            this.revenueGeneratedBox.Controls.Add(this.classBRevOutputLabel);
            this.revenueGeneratedBox.Controls.Add(this.classARevOutputLabel);
            this.revenueGeneratedBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGeneratedBox.Controls.Add(this.classCRevenueLabel);
            this.revenueGeneratedBox.Controls.Add(this.classBRevenueLabel);
            this.revenueGeneratedBox.Controls.Add(this.classARevenueLabel);
            this.revenueGeneratedBox.Location = new System.Drawing.Point(446, 23);
            this.revenueGeneratedBox.Name = "revenueGeneratedBox";
            this.revenueGeneratedBox.Size = new System.Drawing.Size(377, 236);
            this.revenueGeneratedBox.TabIndex = 1;
            this.revenueGeneratedBox.TabStop = false;
            this.revenueGeneratedBox.Text = "Revenue Generated";
            // 
            // totalRevOutputLabel
            // 
            this.totalRevOutputLabel.AutoEllipsis = true;
            this.totalRevOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalRevOutputLabel.Location = new System.Drawing.Point(178, 183);
            this.totalRevOutputLabel.Name = "totalRevOutputLabel";
            this.totalRevOutputLabel.Size = new System.Drawing.Size(151, 23);
            this.totalRevOutputLabel.TabIndex = 7;
            // 
            // classCRevOutputLabel
            // 
            this.classCRevOutputLabel.AutoEllipsis = true;
            this.classCRevOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classCRevOutputLabel.Location = new System.Drawing.Point(178, 145);
            this.classCRevOutputLabel.Name = "classCRevOutputLabel";
            this.classCRevOutputLabel.Size = new System.Drawing.Size(151, 23);
            this.classCRevOutputLabel.TabIndex = 6;
            // 
            // classBRevOutputLabel
            // 
            this.classBRevOutputLabel.AutoEllipsis = true;
            this.classBRevOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classBRevOutputLabel.Location = new System.Drawing.Point(178, 107);
            this.classBRevOutputLabel.Name = "classBRevOutputLabel";
            this.classBRevOutputLabel.Size = new System.Drawing.Size(151, 23);
            this.classBRevOutputLabel.TabIndex = 5;
            // 
            // classARevOutputLabel
            // 
            this.classARevOutputLabel.AutoEllipsis = true;
            this.classARevOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classARevOutputLabel.Location = new System.Drawing.Point(178, 69);
            this.classARevOutputLabel.Name = "classARevOutputLabel";
            this.classARevOutputLabel.Size = new System.Drawing.Size(151, 23);
            this.classARevOutputLabel.TabIndex = 4;
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Location = new System.Drawing.Point(38, 189);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(105, 17);
            this.totalRevenueLabel.TabIndex = 3;
            this.totalRevenueLabel.Text = "Total Revenue:";
            // 
            // classCRevenueLabel
            // 
            this.classCRevenueLabel.AutoSize = true;
            this.classCRevenueLabel.Location = new System.Drawing.Point(38, 151);
            this.classCRevenueLabel.Name = "classCRevenueLabel";
            this.classCRevenueLabel.Size = new System.Drawing.Size(59, 17);
            this.classCRevenueLabel.TabIndex = 2;
            this.classCRevenueLabel.Text = "Class C:";
            // 
            // classBRevenueLabel
            // 
            this.classBRevenueLabel.AutoSize = true;
            this.classBRevenueLabel.Location = new System.Drawing.Point(38, 113);
            this.classBRevenueLabel.Name = "classBRevenueLabel";
            this.classBRevenueLabel.Size = new System.Drawing.Size(59, 17);
            this.classBRevenueLabel.TabIndex = 1;
            this.classBRevenueLabel.Text = "Class B:";
            // 
            // classARevenueLabel
            // 
            this.classARevenueLabel.AutoSize = true;
            this.classARevenueLabel.Location = new System.Drawing.Point(38, 69);
            this.classARevenueLabel.Name = "classARevenueLabel";
            this.classARevenueLabel.Size = new System.Drawing.Size(59, 17);
            this.classARevenueLabel.TabIndex = 0;
            this.classARevenueLabel.Text = "Class A:";
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.transactionsOutputLabel);
            this.summaryBox.Controls.Add(this.sumTicketsOutputLabel);
            this.summaryBox.Controls.Add(this.sumRevOutputLabel);
            this.summaryBox.Controls.Add(this.transactionsLabel);
            this.summaryBox.Controls.Add(this.sumTicketsLabel);
            this.summaryBox.Controls.Add(this.sumRevLabel);
            this.summaryBox.Location = new System.Drawing.Point(12, 265);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(387, 145);
            this.summaryBox.TabIndex = 2;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Summary";
            // 
            // transactionsOutputLabel
            // 
            this.transactionsOutputLabel.AutoEllipsis = true;
            this.transactionsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transactionsOutputLabel.Location = new System.Drawing.Point(231, 101);
            this.transactionsOutputLabel.Name = "transactionsOutputLabel";
            this.transactionsOutputLabel.Size = new System.Drawing.Size(130, 23);
            this.transactionsOutputLabel.TabIndex = 5;
            // 
            // sumTicketsOutputLabel
            // 
            this.sumTicketsOutputLabel.AutoEllipsis = true;
            this.sumTicketsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumTicketsOutputLabel.Location = new System.Drawing.Point(231, 68);
            this.sumTicketsOutputLabel.Name = "sumTicketsOutputLabel";
            this.sumTicketsOutputLabel.Size = new System.Drawing.Size(130, 23);
            this.sumTicketsOutputLabel.TabIndex = 4;
            // 
            // sumRevOutputLabel
            // 
            this.sumRevOutputLabel.AutoEllipsis = true;
            this.sumRevOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumRevOutputLabel.Location = new System.Drawing.Point(231, 35);
            this.sumRevOutputLabel.Name = "sumRevOutputLabel";
            this.sumRevOutputLabel.Size = new System.Drawing.Size(130, 23);
            this.sumRevOutputLabel.TabIndex = 3;
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Location = new System.Drawing.Point(52, 107);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(94, 17);
            this.transactionsLabel.TabIndex = 2;
            this.transactionsLabel.Text = "Transactions:";
            // 
            // sumTicketsLabel
            // 
            this.sumTicketsLabel.AutoSize = true;
            this.sumTicketsLabel.Location = new System.Drawing.Point(52, 74);
            this.sumTicketsLabel.Name = "sumTicketsLabel";
            this.sumTicketsLabel.Size = new System.Drawing.Size(105, 17);
            this.sumTicketsLabel.TabIndex = 1;
            this.sumTicketsLabel.Text = "Sum of Tickets:";
            // 
            // sumRevLabel
            // 
            this.sumRevLabel.AutoSize = true;
            this.sumRevLabel.Location = new System.Drawing.Point(52, 41);
            this.sumRevLabel.Name = "sumRevLabel";
            this.sumRevLabel.Size = new System.Drawing.Size(117, 17);
            this.sumRevLabel.TabIndex = 0;
            this.sumRevLabel.Text = "Sum of Revenue:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(446, 339);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(116, 71);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(568, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 71);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(690, 340);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 71);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.revenueGeneratedBox);
            this.Controls.Add(this.ticketsSoldBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating Cost and Revenue";
            this.ticketsSoldBox.ResumeLayout(false);
            this.ticketsSoldBox.PerformLayout();
            this.revenueGeneratedBox.ResumeLayout(false);
            this.revenueGeneratedBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ticketsSoldBox;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label totalTicketsLabel;
        private System.Windows.Forms.Label classCTicketsLabel;
        private System.Windows.Forms.Label classATicketsLabel;
        private System.Windows.Forms.Label classBTicketsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTicketsOutputLabel;
        private System.Windows.Forms.GroupBox revenueGeneratedBox;
        private System.Windows.Forms.Label classBRevOutputLabel;
        private System.Windows.Forms.Label classARevOutputLabel;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label classCRevenueLabel;
        private System.Windows.Forms.Label classBRevenueLabel;
        private System.Windows.Forms.Label classARevenueLabel;
        private System.Windows.Forms.Label totalRevOutputLabel;
        private System.Windows.Forms.Label classCRevOutputLabel;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Label transactionsOutputLabel;
        private System.Windows.Forms.Label sumTicketsOutputLabel;
        private System.Windows.Forms.Label sumRevOutputLabel;
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.Label sumTicketsLabel;
        private System.Windows.Forms.Label sumRevLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

