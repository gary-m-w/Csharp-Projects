namespace _3333_WadleyG_Lab01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.favoriteBookLabel = new System.Windows.Forms.Label();
            this.favoriteMovieLabel = new System.Windows.Forms.Label();
            this.favoriteShowLabel = new System.Windows.Forms.Label();
            this.favoriteMovieButton = new System.Windows.Forms.Button();
            this.favoriteShowButton = new System.Windows.Forms.Button();
            this.favoriteBookButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pictureDescriptionLabel = new System.Windows.Forms.Label();
            this.sandyPictureBox = new System.Windows.Forms.PictureBox();
            this.emmittPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sandyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmittPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Favorite Things";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(152, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click on Image to Change It!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteBookLabel
            // 
            this.favoriteBookLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteBookLabel.Location = new System.Drawing.Point(296, 270);
            this.favoriteBookLabel.Name = "favoriteBookLabel";
            this.favoriteBookLabel.Size = new System.Drawing.Size(215, 27);
            this.favoriteBookLabel.TabIndex = 2;
            this.favoriteBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteMovieLabel
            // 
            this.favoriteMovieLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteMovieLabel.Location = new System.Drawing.Point(296, 136);
            this.favoriteMovieLabel.Name = "favoriteMovieLabel";
            this.favoriteMovieLabel.Size = new System.Drawing.Size(215, 27);
            this.favoriteMovieLabel.TabIndex = 3;
            this.favoriteMovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteShowLabel
            // 
            this.favoriteShowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favoriteShowLabel.Location = new System.Drawing.Point(296, 201);
            this.favoriteShowLabel.Name = "favoriteShowLabel";
            this.favoriteShowLabel.Size = new System.Drawing.Size(215, 27);
            this.favoriteShowLabel.TabIndex = 4;
            this.favoriteShowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favoriteMovieButton
            // 
            this.favoriteMovieButton.Location = new System.Drawing.Point(64, 136);
            this.favoriteMovieButton.Name = "favoriteMovieButton";
            this.favoriteMovieButton.Size = new System.Drawing.Size(215, 27);
            this.favoriteMovieButton.TabIndex = 5;
            this.favoriteMovieButton.Text = "Display my favorite movie";
            this.favoriteMovieButton.UseVisualStyleBackColor = true;
            this.favoriteMovieButton.Click += new System.EventHandler(this.favoriteMovieButton_Click);
            // 
            // favoriteShowButton
            // 
            this.favoriteShowButton.Location = new System.Drawing.Point(64, 201);
            this.favoriteShowButton.Name = "favoriteShowButton";
            this.favoriteShowButton.Size = new System.Drawing.Size(215, 27);
            this.favoriteShowButton.TabIndex = 6;
            this.favoriteShowButton.Text = "Display my favorite TV show";
            this.favoriteShowButton.UseVisualStyleBackColor = true;
            this.favoriteShowButton.Click += new System.EventHandler(this.favoriteShowButton_Click);
            // 
            // favoriteBookButton
            // 
            this.favoriteBookButton.Location = new System.Drawing.Point(64, 269);
            this.favoriteBookButton.Name = "favoriteBookButton";
            this.favoriteBookButton.Size = new System.Drawing.Size(215, 27);
            this.favoriteBookButton.TabIndex = 7;
            this.favoriteBookButton.Text = "Display my favorite book";
            this.favoriteBookButton.UseVisualStyleBackColor = true;
            this.favoriteBookButton.Click += new System.EventHandler(this.favoriteBookButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(436, 651);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 27);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(64, 651);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 27);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pictureDescriptionLabel
            // 
            this.pictureDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureDescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureDescriptionLabel.Location = new System.Drawing.Point(218, 599);
            this.pictureDescriptionLabel.Name = "pictureDescriptionLabel";
            this.pictureDescriptionLabel.Size = new System.Drawing.Size(150, 29);
            this.pictureDescriptionLabel.TabIndex = 10;
            this.pictureDescriptionLabel.Text = "Sandy";
            this.pictureDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sandyPictureBox
            // 
            this.sandyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sandyPictureBox.Image")));
            this.sandyPictureBox.Location = new System.Drawing.Point(139, 359);
            this.sandyPictureBox.Name = "sandyPictureBox";
            this.sandyPictureBox.Size = new System.Drawing.Size(304, 205);
            this.sandyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sandyPictureBox.TabIndex = 11;
            this.sandyPictureBox.TabStop = false;
            this.sandyPictureBox.Click += new System.EventHandler(this.sandyPictureBox_Click);
            // 
            // emmittPictureBox
            // 
            this.emmittPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emmittPictureBox.Image")));
            this.emmittPictureBox.Location = new System.Drawing.Point(139, 359);
            this.emmittPictureBox.Name = "emmittPictureBox";
            this.emmittPictureBox.Size = new System.Drawing.Size(304, 205);
            this.emmittPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emmittPictureBox.TabIndex = 12;
            this.emmittPictureBox.TabStop = false;
            this.emmittPictureBox.Click += new System.EventHandler(this.emmittPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 729);
            this.Controls.Add(this.sandyPictureBox);
            this.Controls.Add(this.pictureDescriptionLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.favoriteBookButton);
            this.Controls.Add(this.favoriteShowButton);
            this.Controls.Add(this.favoriteMovieButton);
            this.Controls.Add(this.favoriteShowLabel);
            this.Controls.Add(this.favoriteMovieLabel);
            this.Controls.Add(this.favoriteBookLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emmittPictureBox);
            this.Name = "Form1";
            this.Text = "My Favorite Things";
            ((System.ComponentModel.ISupportInitialize)(this.sandyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emmittPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label favoriteBookLabel;
        private System.Windows.Forms.Label favoriteMovieLabel;
        private System.Windows.Forms.Label favoriteShowLabel;
        private System.Windows.Forms.Button favoriteMovieButton;
        private System.Windows.Forms.Button favoriteShowButton;
        private System.Windows.Forms.Button favoriteBookButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label pictureDescriptionLabel;
        private System.Windows.Forms.PictureBox sandyPictureBox;
        private System.Windows.Forms.PictureBox emmittPictureBox;
    }
}

