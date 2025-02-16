using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator2
{
    public class BMI
    {
        private string gender;
        private double height;
        private double weight;
        private int age;

        public BMI(string gender, double height, double weight, int age)
        {
            this.Gender = gender;
            this.Height = height;
            this.Weight = weight;
            this.Age = age;


        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Calculate()
        {
            return Weight / (Math.Pow((Height / 100),2.0));
        }

    }


}
