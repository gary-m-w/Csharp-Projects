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
 * Goal: Create a simple distance calculator that displays travel increments through a loop and ListBox control (Ch.5 Problem #1)
 */


namespace _3333_WadleyG_Lab04
{
    public partial class Form1 : Form
    {
        //declare and initialize summary field outputs
        private double totalDistance;
        private int totalHours;
        private int totalTrips;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare local variables
            double vehicleSpeed;
            int hoursTraveled;
            double distanceTraveled = 0;
            double averageDistanceTraveled;


            if(double.TryParse(vehicleSpeedTextBox.Text, out vehicleSpeed)) //speed is a number
            {
                if(vehicleSpeed > 0 && vehicleSpeed <= 180) //speed greater than zero and does not exceed 180
                {
                    if(int.TryParse(hoursTraveledTextBox.Text, out hoursTraveled)) //hours is a whole integer
                    {
                        if(hoursTraveled > 0 && hoursTraveled <= 50) //hours traveled greater than zero and does not exceed 50
                        {
                            distanceListBox.Items.Clear();

                            for (int count = 1; count <= hoursTraveled; count++) //declare count and calculate distance loop
                            {
                                distanceTraveled = vehicleSpeed * count;
                                //output results into ListBox
                                distanceListBox.Items.Add("After hour " + count + " the distance is " + distanceTraveled.ToString("n2") + " miles."); 
                            }

                            //calculate output total values
                            totalDistance = totalDistance + distanceTraveled;
                            totalHours = totalHours + hoursTraveled;
                            totalTrips = totalTrips + 1;
                            averageDistanceTraveled = totalDistance / totalTrips;

                            //display output total values
                            totalDistanceLabel.Text = totalDistance.ToString("n2");
                            totalHoursTraveledLabel.Text = totalHours.ToString("n0");
                            totalTripsLabel.Text = totalTrips.ToString("n0");
                            avgDistanceLabel.Text = averageDistanceTraveled.ToString("n2");
                        }
                        else
                        {
                            MessageBox.Show("Hours traveled must be a positive integer that does not exceed 50.");
                            hoursTraveledTextBox.Clear();
                            hoursTraveledTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hours traveled must be a whole number.");
                        hoursTraveledTextBox.Clear();
                        hoursTraveledTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Speed must be a positive number that does not exceed 180.");
                    vehicleSpeedTextBox.Clear();
                    vehicleSpeedTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vehicle Speed must be a number.");
                vehicleSpeedTextBox.Clear();
                vehicleSpeedTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            vehicleSpeedTextBox.Clear();
            hoursTraveledTextBox.Clear();
            distanceListBox.Items.Clear();
            avgDistanceLabel.Text = "";
            vehicleSpeedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
