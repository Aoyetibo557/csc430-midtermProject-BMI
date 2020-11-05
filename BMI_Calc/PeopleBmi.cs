using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calc
{
    class PeopleBmi
    {
        private List<BMI> _bmiList;

        public PeopleBmi()
        {
            _bmiList = new List<BMI>();
            _bmiList.Add(new BMI("James", 5, 6, 195, 31.5));
            _bmiList.Add(new BMI("Anu", 10, 5, 205, 9.2));
            _bmiList.Add(new BMI("Gabe", 9, 6, 155, 8.4));
            _bmiList.Add(new BMI("Frank", 8, 10, 200, 12.5));
            _bmiList.Add(new BMI("Alex", 7, 7, 190, 16.1));
            _bmiList.Add(new BMI("Anne", 6, 10, 201, 21));

        }
        public List<BMI> GetBmiList(string _listName)
        {
            return _bmiList;
        }


        public void AddToBmiList(int _feet, int _inc, int _weight, string _name, double _bmi)
        {
           
             _bmiList.Add(new BMI(_name, _feet, _inc, _weight, _bmi));
        }
    }
}
