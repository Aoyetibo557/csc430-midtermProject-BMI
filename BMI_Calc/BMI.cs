using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calc
{
    class BMI
    {
        private int _feet;
        private int _inches;
        private int _weight;
        private string _name;
        private double _bmi;


        public int Feet
        {
            get { return _feet; }
            set { _feet = value; }
        }
        public int Inches
        {
            get { return _inches; }
            set { _inches = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Bmi
        {
            get { return _bmi; }
            set { _bmi = value; }
        }
        public BMI(string name, int feet, int inches, int weight, double bmi)
        {
            _feet = feet;
            _inches = inches;
            _weight = weight;
            _name = name;
            _bmi = bmi;

        }
    }
}
