namespace _3333_WadleyG_Lab06
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalDonutsLabel = new System.Windows.Forms.Label();
            this.avgDonutsLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.donutsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayListButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.donutComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonutTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDonutTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDonutTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Donuts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Type of Donut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total of Donut Sales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average Donuts Sold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total of Donuts Sold";
            // 
            // totalDonutsLabel
            // 
            this.totalDonutsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDonutsLabel.Location = new System.Drawing.Point(234, 280);
            this.totalDonutsLabel.Name = "totalDonutsLabel";
            this.totalDonutsLabel.Size = new System.Drawing.Size(100, 23);
            this.totalDonutsLabel.TabIndex = 9;
            // 
            // avgDonutsLabel
            // 
            this.avgDonutsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgDonutsLabel.Location = new System.Drawing.Point(234, 332);
            this.avgDonutsLabel.Name = "avgDonutsLabel";
            this.avgDonutsLabel.Size = new System.Drawing.Size(100, 23);
            this.avgDonutsLabel.TabIndex = 11;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalesLabel.Location = new System.Drawing.Point(234, 383);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSalesLabel.TabIndex = 13;
            // 
            // donutsTextBox
            // 
            this.donutsTextBox.Location = new System.Drawing.Point(169, 54);
            this.donutsTextBox.Name = "donutsTextBox";
            this.donutsTextBox.Size = new System.Drawing.Size(68, 22);
            this.donutsTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(268, 49);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 32);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Click to calculate sales of the entered donuts.");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayListButton
            // 
            this.displayListButton.Location = new System.Drawing.Point(12, 428);
            this.displayListButton.Name = "displayListButton";
            this.displayListButton.Size = new System.Drawing.Size(155, 32);
            this.displayListButton.TabIndex = 3;
            this.displayListButton.Text = "&Display Donut List";
            this.toolTip1.SetToolTip(this.displayListButton, "Click to display every sale of donuts currently stored.");
            this.displayListButton.UseVisualStyleBackColor = true;
            this.displayListButton.Click += new System.EventHandler(this.displayListButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearListButton.Location = new System.Drawing.Point(188, 428);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(155, 32);
            this.clearListButton.TabIndex = 4;
            this.clearListButton.Text = "C&lear Donut List";
            this.toolTip1.SetToolTip(this.clearListButton, "Click to clear currently stored sales data.");
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // donutComboBox
            // 
            this.donutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.donutComboBox.FormattingEnabled = true;
            this.donutComboBox.Items.AddRange(new object[] {
            "Chocolate",
            "Glazed"});
            this.donutComboBox.Location = new System.Drawing.Point(43, 145);
            this.donutComboBox.Name = "donutComboBox";
            this.donutComboBox.Size = new System.Drawing.Size(215, 121);
            this.donutComboBox.Sorted = true;
            this.donutComboBox.TabIndex = 1;
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(44, 24);
            this.fileToolStrip.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStrip
            // 
            this.toolsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonutTypeToolStripMenuItem,
            this.removeDonutTypeToolStripMenuItem,
            this.clearDonutTypeToolStripMenuItem,
            this.displayDoToolStripMenuItem});
            this.toolsToolStrip.Name = "toolsToolStrip";
            this.toolsToolStrip.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStrip.Text = "&Tools";
            // 
            // addDonutTypeToolStripMenuItem
            // 
            this.addDonutTypeToolStripMenuItem.Name = "addDonutTypeToolStripMenuItem";
            this.addDonutTypeToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addDonutTypeToolStripMenuItem.Text = "Add Donut Type";
            this.addDonutTypeToolStripMenuItem.Click += new System.EventHandler(this.addDonutTypeToolStripMenuItem_Click);
            // 
            // removeDonutTypeToolStripMenuItem
            // 
            this.removeDonutTypeToolStripMenuItem.Name = "removeDonutTypeToolStripMenuItem";
            this.removeDonutTypeToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.removeDonutTypeToolStripMenuItem.Text = "Remove Donut Type";
            this.removeDonutTypeToolStripMenuItem.Click += new System.EventHandler(this.removeDonutTypeToolStripMenuItem_Click);
            // 
            // clearDonutTypeToolStripMenuItem
            // 
            this.clearDonutTypeToolStripMenuItem.Name = "clearDonutTypeToolStripMenuItem";
            this.clearDonutTypeToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.clearDonutTypeToolStripMenuItem.Text = "Clear Donut Types";
            this.clearDonutTypeToolStripMenuItem.Click += new System.EventHandler(this.clearDonutTypeToolStripMenuItem_Click);
            // 
            // displayDoToolStripMenuItem
            // 
            this.displayDoToolStripMenuItem.Name = "displayDoToolStripMenuItem";
            this.displayDoToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.displayDoToolStripMenuItem.Text = "Display Donut Type Count";
            this.displayDoToolStripMenuItem.Click += new System.EventHandler(this.displayDoToolStripMenuItem_Click);
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(53, 24);
            this.helpToolStrip.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.toolsToolStrip,
            this.helpToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearListButton;
            this.ClientSize = new System.Drawing.Size(365, 472);
            this.Controls.Add(this.donutComboBox);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.displayListButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.donutsTextBox);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.avgDonutsLabel);
            this.Controls.Add(this.totalDonutsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Donut Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalDonutsLabel;
        private System.Windows.Forms.Label avgDonutsLabel;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.TextBox donutsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button displayListButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.ComboBox donutComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addDonutTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDonutTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDonutTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

