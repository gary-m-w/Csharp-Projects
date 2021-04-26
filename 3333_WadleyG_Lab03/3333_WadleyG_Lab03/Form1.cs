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
 * Due: 10/06
 * Submitted: 10/05
 * Goal: Create a software package calculator that accounts for varying discounts (Ch.4 Problem #7)
 */

namespace _3333_WadleyG_Lab03
{
    public partial class Form1 : Form
    {
        //Forms
        private decimal sumDiscount;
        private int sumPackages;
        private int sumOrders;
        private decimal averageDiscount;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare constants
            const decimal PACKAGE_PRICE = 99;
            //declare variables
            int packagesPurchased;
            decimal discountPercent = 0.0m;
            decimal beforeDiscount;
            decimal discount;
            decimal afterDiscount;

            //handle exceptions from invalid packagePurhcased inputs
            if (int.TryParse(packagesPurchasedTextBox.Text, out packagesPurchased))
            {
                //validate the packagePuchased input is a positive integer
                if (packagesPurchased > 0)
                {

                    //convert input to int
                    packagesPurchased = int.Parse(packagesPurchasedTextBox.Text);

                    //determine discount percent
                    if (packagesPurchased >= 100)
                        discountPercent = 0.5m;
                    else if (packagesPurchased >= 50 && packagesPurchased < 100)
                        discountPercent = 0.4m;
                    else if (packagesPurchased >= 20 && packagesPurchased < 50)
                        discountPercent = 0.3m;
                    else if (packagesPurchased >= 10 && packagesPurchased < 20)
                        discountPercent = 0.2m;
                    else if (packagesPurchased >= 0 && packagesPurchased < 10)
                        discountPercent = 0.0m;

                    discountPercentLabel.Text = discountPercent.ToString("p1");

                    //calculations
                    beforeDiscount = packagesPurchased * PACKAGE_PRICE;
                    beforeDiscountLabel.Text = beforeDiscount.ToString("C");
                    discount = discountPercent * beforeDiscount;
                    discountLabel.Text = discount.ToString("C");
                    afterDiscount = beforeDiscount - discount;
                    afterDiscountLabel.Text = afterDiscount.ToString("C");

                    //summary outputs
                    sumDiscount += discount;
                    sumPackages += packagesPurchased;
                    sumOrders += 1;
                    averageDiscount = sumDiscount / sumOrders;
                    sumDiscountLabel.Text = sumDiscount.ToString("C");
                    sumPackagesPurchasedLabel.Text = sumPackages.ToString("N0");
                    sumOrdersLabel.Text = sumOrders.ToString("N0");
                    averageDiscountLabel.Text = averageDiscount.ToString("C");
                }
                else
                {
                    //display error for negative or zero input for packagePurchasedTextBox
                    MessageBox.Show("Number of package(s) must be greater than zero.");
                    packagesPurchasedTextBox.Clear();
                    packagesPurchasedTextBox.Focus();
                }
            }
            else
            {
                //display error for packagesPurchasedTextBox
                MessageBox.Show("Invalid input for number of package(s) purchased.");
                packagesPurchasedTextBox.Clear();
                packagesPurchasedTextBox.Focus();
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            packagesPurchasedTextBox.Text = "";
            discountPercentLabel.Text = "";
            beforeDiscountLabel.Text = "";
            discountLabel.Text = "";
            afterDiscountLabel.Text = "";
            packagesPurchasedTextBox.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
