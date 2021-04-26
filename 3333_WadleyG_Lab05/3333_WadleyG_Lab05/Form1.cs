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
 * Due: 11/3
 * Submitted: 11/3
 * Goal:  Create a hospital visit calculator that utilized methods to calculate data (Ch.6 Problem #6)
 */

namespace _3333_WadleyG_Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare local variables
            int daysInHospital;
            decimal chargesForMedication;
            decimal surgicalCharges;
            decimal labFees;
            decimal physicalRehabCharges;
            int stayCharges;
            decimal miscCharges;
            decimal totalCharges;
            string membershipLevel;

            //data conversion and validation statements
            if(int.TryParse(daysInHospitalTextBox.Text, out daysInHospital))
            {
                if(daysInHospital > 0)
                {
                    if(decimal.TryParse(chargesforMedicationTextBox.Text, out chargesForMedication))
                    {
                        if(chargesForMedication >= 0)
                        {
                            if (decimal.TryParse(surgicalChargesTextBox.Text, out surgicalCharges))
                            {
                                if (surgicalCharges >= 0)
                                {
                                    if (decimal.TryParse(labFeesTextBox.Text, out labFees))
                                    {
                                        if (labFees >= 0)
                                        {
                                            if (decimal.TryParse(physicalRehabTextBox.Text, out physicalRehabCharges))
                                            {
                                                if (physicalRehabCharges >= 0)
                                                {
                                                    //call methods
                                                    stayCharges = CalcStayCharges(daysInHospital);
                                                    miscCharges = CalcMiscCharges(chargesForMedication, surgicalCharges, labFees, physicalRehabCharges);
                                                    totalCharges = CalcTotalCharges(stayCharges, miscCharges);
                                                    membershipLevel = DisplayMembershipLevel(totalCharges);

                                                    //display outputs
                                                    stayChargesLabel.Text = stayCharges.ToString("c");
                                                    miscChargesLabel.Text = miscCharges.ToString("c");
                                                    totalCostLabel.Text = totalCharges.ToString("c");
                                                    membershipLabel.Text = membershipLevel;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Rehabilitation fees must be greater or equal to 0.");
                                                    physicalRehabTextBox.Clear();
                                                    physicalRehabTextBox.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid input for rehabilitation fees. It must be numeric.");
                                                physicalRehabTextBox.Clear();
                                                physicalRehabTextBox.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Lab charges must be greater or equal to 0.");
                                            labFeesTextBox.Clear();
                                            labFeesTextBox.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid input for lab fees. It must be numeric.");
                                        labFeesTextBox.Clear();
                                        labFeesTextBox.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Surgical charges must be greater or equal to 0.");
                                    surgicalChargesTextBox.Clear();
                                    surgicalChargesTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid input for surgical charges. It must be numeric.");
                                surgicalChargesTextBox.Clear();
                                surgicalChargesTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Medical charges must be greater or equal to 0.");
                            chargesforMedicationTextBox.Clear();
                            chargesforMedicationTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for medical charges. It must be numeric.");
                        chargesforMedicationTextBox.Clear();
                        chargesforMedicationTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Days in hospital must be greater than 0.");
                    daysInHospitalTextBox.Clear();
                    daysInHospitalTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid input for days in hospital. It must be a whole number.");
                daysInHospitalTextBox.Clear();
                daysInHospitalTextBox.Focus();
            }

        }
        //method definitions
        private int CalcStayCharges(int days)
        {
            return days * 350;
        }
        private decimal CalcMiscCharges(decimal med, decimal surg, decimal lab, decimal rehab)
        {
            return med + surg + lab + rehab;
        }
        private decimal CalcTotalCharges(int stay, decimal misc)
        {
            return stay + misc;
        }
        private string DisplayMembershipLevel(decimal total)
        {
            if(total >= 1 && total < 1000)
            {
                return "Bronze";
            }
            else if (total >= 1000 && total < 1500)
            {
                return "Silver";
            }
            else if (total >= 1500 && total < 2000)
            {
                return "Gold";
            }
            else
            {
                return "Platinum";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daysInHospitalTextBox.Clear();
            chargesforMedicationTextBox.Clear();
            surgicalChargesTextBox.Clear();
            labFeesTextBox.Clear();
            physicalRehabTextBox.Clear();
            stayChargesLabel.Text = "";
            miscChargesLabel.Text = "";
            totalCostLabel.Text = "";
            membershipLabel.Text = "";
            daysInHospitalTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
