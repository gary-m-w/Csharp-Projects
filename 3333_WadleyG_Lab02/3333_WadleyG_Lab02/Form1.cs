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
 * Garrett Wadley
 * 001039065
 * Due: 09/15
 * Submitted: 09/12
 * Goal: Create a calculator for stadium seating revenues (Ch.3 Problem #14)
 */


namespace _3333_WadleyG_Lab02
{
    public partial class Form1 : Form
    {
        //fields
        private int revenueSum = 0;
        private int ticketsSum = 0;
        private int totalTransactions = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear inputs but NOT summary fields, reset focus
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";
            totalTicketsOutputLabel.Text = "";
            classARevOutputLabel.Text = "";
            classBRevOutputLabel.Text = "";
            classCRevOutputLabel.Text = "";
            totalRevOutputLabel.Text = "";
            classATextBox.Focus();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //constants
                const int classAPrice = 15;
                const int classBPrice = 12;
                const int classCPrice = 9;

                //variables
                int classATickets, classBTickets, classCTickets, totalTickets;
                int classARevenue, classBRevenue, classCRevenue, totalRevenue;

                classATickets = int.Parse(classATextBox.Text);
                classBTickets = int.Parse(classBTextBox.Text);
                classCTickets = int.Parse(classCTextBox.Text);

                //calculations

                totalTickets = classATickets + classBTickets + classCTickets;

                classARevenue = classAPrice * classATickets;
                classBRevenue = classBPrice * classBTickets;
                classCRevenue = classCPrice * classCTickets;
                totalRevenue = classARevenue + classBRevenue + classCRevenue;

                //Summary
                revenueSum = revenueSum + totalRevenue;
                ticketsSum = ticketsSum + totalTickets;
                totalTransactions = totalTransactions + 1;

                //outputs

                totalTicketsOutputLabel.Text = totalTickets.ToString("n0");
                classARevOutputLabel.Text = classARevenue.ToString("c");
                classBRevOutputLabel.Text = classBRevenue.ToString("c");
                classCRevOutputLabel.Text = classCRevenue.ToString("c");
                totalRevOutputLabel.Text = totalRevenue.ToString("c");
                sumRevOutputLabel.Text = revenueSum.ToString("c");
                sumTicketsOutputLabel.Text = ticketsSum.ToString("n0");
                transactionsOutputLabel.Text = totalTransactions.ToString("n0");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
