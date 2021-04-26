namespace _3333_WadleyG_Lab03
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
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDiscountLabel = new System.Windows.Forms.Label();
            this.sumOrdersLabel = new System.Windows.Forms.Label();
            this.sumPackagesPurchasedLabel = new System.Windows.Forms.Label();
            this.sumDiscountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.beforeDiscountLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.afterDiscountLabel = new System.Windows.Forms.Label();
            this.packagesPurchasedTextBox = new System.Windows.Forms.TextBox();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.averageDiscountLabel);
            this.summaryGroupBox.Controls.Add(this.sumOrdersLabel);
            this.summaryGroupBox.Controls.Add(this.sumPackagesPurchasedLabel);
            this.summaryGroupBox.Controls.Add(this.sumDiscountLabel);
            this.summaryGroupBox.Controls.Add(this.label4);
            this.summaryGroupBox.Controls.Add(this.label3);
            this.summaryGroupBox.Controls.Add(this.label2);
            this.summaryGroupBox.Controls.Add(this.label1);
            this.summaryGroupBox.Location = new System.Drawing.Point(12, 276);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(414, 171);
            this.summaryGroupBox.TabIndex = 13;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // averageDiscountLabel
            // 
            this.averageDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageDiscountLabel.Location = new System.Drawing.Point(245, 125);
            this.averageDiscountLabel.Name = "averageDiscountLabel";
            this.averageDiscountLabel.Size = new System.Drawing.Size(163, 23);
            this.averageDiscountLabel.TabIndex = 7;
            // 
            // sumOrdersLabel
            // 
            this.sumOrdersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumOrdersLabel.Location = new System.Drawing.Point(245, 96);
            this.sumOrdersLabel.Name = "sumOrdersLabel";
            this.sumOrdersLabel.Size = new System.Drawing.Size(163, 23);
            this.sumOrdersLabel.TabIndex = 6;
            // 
            // sumPackagesPurchasedLabel
            // 
            this.sumPackagesPurchasedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumPackagesPurchasedLabel.Location = new System.Drawing.Point(244, 65);
            this.sumPackagesPurchasedLabel.Name = "sumPackagesPurchasedLabel";
            this.sumPackagesPurchasedLabel.Size = new System.Drawing.Size(164, 23);
            this.sumPackagesPurchasedLabel.TabIndex = 5;
            // 
            // sumDiscountLabel
            // 
            this.sumDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumDiscountLabel.Location = new System.Drawing.Point(244, 34);
            this.sumDiscountLabel.Name = "sumDiscountLabel";
            this.sumDiscountLabel.Size = new System.Drawing.Size(164, 19);
            this.sumDiscountLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sum of Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sum of Packages Purchased";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sum of Amount Discount";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 473);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 30);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(169, 473);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(329, 473);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of package(s) purchased:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount Percent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount Before Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Amount of Discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Amound After Discount";
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.discountPercentLabel.Location = new System.Drawing.Point(262, 84);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(164, 19);
            this.discountPercentLabel.TabIndex = 9;
            // 
            // beforeDiscountLabel
            // 
            this.beforeDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.beforeDiscountLabel.Location = new System.Drawing.Point(262, 136);
            this.beforeDiscountLabel.Name = "beforeDiscountLabel";
            this.beforeDiscountLabel.Size = new System.Drawing.Size(164, 19);
            this.beforeDiscountLabel.TabIndex = 10;
            // 
            // discountLabel
            // 
            this.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.discountLabel.Location = new System.Drawing.Point(262, 184);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(164, 19);
            this.discountLabel.TabIndex = 11;
            // 
            // afterDiscountLabel
            // 
            this.afterDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.afterDiscountLabel.Location = new System.Drawing.Point(262, 234);
            this.afterDiscountLabel.Name = "afterDiscountLabel";
            this.afterDiscountLabel.Size = new System.Drawing.Size(164, 19);
            this.afterDiscountLabel.TabIndex = 12;
            // 
            // packagesPurchasedTextBox
            // 
            this.packagesPurchasedTextBox.Location = new System.Drawing.Point(262, 36);
            this.packagesPurchasedTextBox.Name = "packagesPurchasedTextBox";
            this.packagesPurchasedTextBox.Size = new System.Drawing.Size(164, 22);
            this.packagesPurchasedTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(438, 515);
            this.Controls.Add(this.packagesPurchasedTextBox);
            this.Controls.Add(this.afterDiscountLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.beforeDiscountLabel);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Name = "Form1";
            this.Text = "Software Calculator";
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label averageDiscountLabel;
        private System.Windows.Forms.Label sumOrdersLabel;
        private System.Windows.Forms.Label sumPackagesPurchasedLabel;
        private System.Windows.Forms.Label sumDiscountLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.Label beforeDiscountLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label afterDiscountLabel;
        private System.Windows.Forms.TextBox packagesPurchasedTextBox;
    }
}

