using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calc
{
    public partial class BMI_Window : Form
    {

        public static string setNewName = "";
        public static string setNewFeet = "";
        public static string setNewInches = "";
        public static string setNewWeight = "";
        public static double setBmi;

        private PeopleBmi _plpList = new PeopleBmi();
        public BMI_Window()
        {
            InitializeComponent();
        }

        private void BMI_Window_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string inputName;
            inputName = nameTxtBox.Text; //Input Name

            string heightFt;
            heightFt = feetTxtBox.Text; //Height in Feet

            string heightIn;
            heightIn = inchesTxtBox.Text; //Height in Inches

            string weight;
            weight = weightTxtBox.Text; // input Weight

            calculateBMI(heightFt, heightIn, weight);
            MessageBox.Show("Results" + Environment.NewLine + "Your Current BMI is: " + calculateBMI(heightFt, heightIn, weight) + Environment.NewLine + "Height: " + heightFt + "'" + heightIn + Environment.NewLine + " Weight: " + weight);

        
        }

        public double calculateBMI(string ft, string inch, string w)
        {
            double res;
            int feet = Int32.Parse(ft);
            int inches = Int32.Parse(inch);
            int W = Int32.Parse(w);

            double totalHeight = convetFeetToInches(feet, inches);

            res = 703 * (W / (totalHeight * totalHeight));
            setBmi = Math.Round(res, 2);

            //Clear fields after calling calculate button
            //clearFields();

            return Math.Round(res, 2);
        }

        /**
         * Converts heights to inches
         */
        private double convetFeetToInches(int ft, int inch)
        {
            int res;
            res = (ft * 12) + inch;
            return res;
        }

        private void viewList_Click(object sender, EventArgs e)
        {
            try
            {
                
                var myForm = new BmiOutput();
                myForm.Show();
                
            }
            catch(Exception)
            {
                MessageBox.Show("Error Occured Retrieveing Data.");
            }
            
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
           
            try{
                if (!isEmpty())
                {
                    setNewName = nameTxtBox.Text;
                    setNewFeet = feetTxtBox.Text;
                    setNewInches = inchesTxtBox.Text;
                    setNewWeight = weightTxtBox.Text;

                    BmiOutput frm2 = new BmiOutput();
                    frm2.Show();
                }

                else
                {
                    MessageBox.Show("Input Fields Are Empty");
                }
               
                   
            }
            catch (Exception )
            {
                MessageBox.Show("Input Fields Are Empty");
            }
           
        }

        private void clearFields()
        {
            nameTxtBox.Text = "";
            feetTxtBox.Text = "";
            inchesTxtBox.Text = "";
            weightTxtBox.Text = "";
        }

        private bool isEmpty()
        {
            string n = nameTxtBox.Text;
            string f = feetTxtBox.Text;
            string i = inchesTxtBox.Text;
            string w = weightTxtBox.Text;

            if (n != "" && f != "" && i!=""&& w !="")
            {
                return false;
            }
            return true;
        }
    }
}
