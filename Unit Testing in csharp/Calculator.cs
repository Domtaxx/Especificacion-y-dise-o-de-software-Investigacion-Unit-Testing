using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_in_csharp
{
    class Calculator
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Sum(List<double> numbers_to_add)
        {
            double result = 0;
            for(int i = 0; i < numbers_to_add.Count; i++)
            {
                result = Sum(result,numbers_to_add[i]);
            }
            return result;
        }
        public double Sum_wrong(List<double> numbers_to_add)
        {
            double result = 0;
            for (int i = 0; i < numbers_to_add.Count; i++)
            {
                result = Sum(result, numbers_to_add[1]);
            }
            return result;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Subtraccion(List<double> numbers_to_add)
        {
            double result = 0;
            for (int i = 0; i < numbers_to_add.Count; i++)
            {
                result = Subtraction(result, numbers_to_add[i]);
            }
            return result;
        }
        public double Subtraccion_wrong(List<double> numbers_to_add)
        {
            double result = 0;
            for (int i = 0; i < numbers_to_add.Count; i++)
            {
                result = Subtraction(numbers_to_add[i], result);
            }
            return result;
        }

        public double division(double num1, double num2)
        {
            return num1 / num2;
        }
        public double multiplicacion(double num1, double num2) { 
            return num1 * num2;
        }
    }
}
