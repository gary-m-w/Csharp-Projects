/*
 * Create a GUI that displays a few of my favorite things.
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_WadleyG_Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void favoriteMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Good, the Bad and the Ugly");
            favoriteMovieLabel.Text = "The Good, the Bad and the Ugly";
        }

        private void favoriteShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rome");
            favoriteShowLabel.Text = "Rome";
        }

        private void favoriteBookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dune");
            favoriteBookLabel.Text = "Dune";
        }

        private void sandyPictureBox_Click(object sender, EventArgs e)
        {
            sandyPictureBox.Visible = false;
            emmittPictureBox.Visible = true;
            pictureDescriptionLabel.Text = "Emmitt";
        }

        private void emmittPictureBox_Click(object sender, EventArgs e)
        {
            emmittPictureBox.Visible = false;
            sandyPictureBox.Visible = true;
            pictureDescriptionLabel.Text = "Sandy";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            favoriteMovieLabel.Text = "";
            favoriteShowLabel.Text = "";
            favoriteBookLabel.Text = "";
            emmittPictureBox.Visible = false;
            sandyPictureBox.Visible = true;
            pictureDescriptionLabel.Text = "Sandy";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
