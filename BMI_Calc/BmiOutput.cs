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
    public partial class BmiOutput : Form
    {
        private BMI lst;
        private PeopleBmi _peopleList = new PeopleBmi();
        public BmiOutput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BmiOutput_Load(object sender, EventArgs e)
        {
            //calling the list
            this.bMIBindingSource.DataSource = _peopleList.GetBmiList(textBox1.Text);
            //addNewBmi();
        }

        private void addNewBmi()
        {
            int feet = Int32.Parse(BMI_Window.setNewFeet);
            int inches = Int32.Parse(BMI_Window.setNewInches);
            int weight = Int32.Parse(BMI_Window.setNewWeight);
            string name = BMI_Window.setNewName;
            double bmi = BMI_Window.setBmi;

            lst = new BMI(name, feet, inches, weight, bmi);
            this.bMIBindingSource.Add(lst);
                          
             //this.bMIBindingSource.DataSource = _peopleList.AddToBmiList(feet, inches, weight, name, bmi);
        }
        private void bMIBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new BMI_Window();
            myForm.Show();
            //this.bMIBindingSource.DataSource = _peopleList.AddToBmiList()

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
