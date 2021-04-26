using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  
 * Goal:  Create a donut calculator that demonstrates List functions utilizing a ComboBox.
 */

namespace _3333_WadleyG_Lab06
{
    public partial class Form1 : Form
    {
        //lists
        private List<string> donutList = new List<string>() { "Chocolate", "Glazed" };
        private List<int> countList = new List<int>();

        //fields
        private decimal totalSales = 0.0m;
        private int totalDonuts;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables
            int donutsSold;
            int donutsAverage;
            int count = 0;


            //validations
            if (int.TryParse(donutsTextBox.Text, out donutsSold))
            {
                if(donutsSold > 0)
                {
                    if (donutComboBox.SelectedIndex != -1)
                    {
                        countList.Add(donutsSold);  //list addition
                        totalDonuts += donutsSold;  //accumulation
                        count = countList.Count;  //number of items through Count

                        //calculations
                        donutsAverage = totalDonuts / count;
                        totalSales = totalDonuts * 0.60m;

                        //outputs
                        totalDonutsLabel.Text = totalDonuts.ToString();
                        avgDonutsLabel.Text = donutsAverage.ToString();
                        totalSalesLabel.Text = totalSales.ToString("c");

                        donutsTextBox.Focus();
                        donutsTextBox.SelectAll();
                        

                        //deselect combo box
                        donutComboBox.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("Please select a donut type.");
                    }
                }
                else
                {
                    MessageBox.Show("Number of donuts must be greater than zero.");
                    donutsTextBox.Clear();
                    donutsTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid entry for number of donuts.");
                donutsTextBox.Clear();
                donutsTextBox.Focus();
            }
        }

        private void displayListButton_Click(object sender, EventArgs e)
        {
            string donutsString = "";

            countList.Sort();

            foreach (decimal donuts in countList)
            {
                donutsString += "Donuts: " + donuts + "\n";
            }
            MessageBox.Show(donutsString, "Number of Donuts");
            donutsTextBox.Clear();
            donutsTextBox.Focus();
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            countList.Clear();
            donutsTextBox.Clear();
            totalSalesLabel.Text = "";
            avgDonutsLabel.Text = "";
            totalDonutsLabel.Text = "";

            donutsTextBox.Focus();

            totalSales = 0;
            totalDonuts = 0;

            //deselect combo box
            donutComboBox.SelectedIndex = -1;
        }

        private void addDonutTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string donut;
            if(donutComboBox.Text != "")
            {
                donut = donutComboBox.Text;
                donutList.Add(donut);
                donutComboBox.Items.Add(donut);
                donutComboBox.Text = "";
                donutComboBox.Focus();
            }
            else
            {
                MessageBox.Show("Enter a donut type.");
                donutComboBox.Focus();
            }
            
        }

        private void removeDonutTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (donutComboBox.SelectedIndex != -1)
            {
                donutList.RemoveAt(donutComboBox.SelectedIndex);
                donutComboBox.Items.Remove(donutComboBox.SelectedItem);
                donutComboBox.Focus();
            }
            else
            {
                MessageBox.Show("Select a donut to remove.");
                donutComboBox.Focus();
            }
        }

        private void clearDonutTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donutList.Clear();
            donutComboBox.Items.Clear();
            donutComboBox.Focus();
        }

        private void displayDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + donutList.Count + " types of donuts.");
            donutComboBox.Focus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Garrett Wadley");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
