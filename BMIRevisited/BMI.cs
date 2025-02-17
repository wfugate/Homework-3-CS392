using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIRevisited
{
    public class BMI
    {
        
        private string gender;
        private int age;
        private double weight;
        private double height;
        private bool metric;

        public BMI(string Gender, int Age, double Height, double Weight, bool Metric)
        {
            gender = Gender;
            age = Age;
            weight = Weight;
            height = Height;
            metric = Metric;
        }

        private void ChangeAge(int new_age)
        {//to change age
            age = new_age;
        }

        private void ChangeGender(string new_gender)
        {// to change gender
            gender = new_gender;
        }

        private void ChangeWeight(int new_weight)
        {// to change weight
            weight = new_weight;
        }

        private void ChangeHeight(int new_height)
        {// to change height
            height = new_height;
        }

        //Create calculate BMI method
        // make it public

        public string CalculateBMI()
        {
            float output = 0;

            output = (float)weight / (float)height / (float)height;//raw BMI calc
            if (!metric)
            {
                output *= 703;// changing for imperial
            }

            string category;// getting weight category in order
            if (output < 18.5)
            {
                category = "Underweight";
            }
            else if (output < 25.0)
            {
                category = "Healthy weight";
            }
            else if (output < 30.0)
            {
                category = "Overweight";
            }
            else
            {
                category = "Obesity";
            }
            // string is return object
            return $"Your BMI is {Math.Round(output, 3)}, and your classification is {category}";
        }


        


    }
}
