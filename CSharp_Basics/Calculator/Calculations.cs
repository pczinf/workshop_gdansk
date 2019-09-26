using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
        public static double Calculation(MathData mathData)
        {
            switch (mathData.Operation)
            {
                case "+":
                    return Add(mathData.FirstNumber, mathData.SecondNumber);
                case "-":
                    return Subtr(mathData.FirstNumber, mathData.SecondNumber);
                case "*":
                case "x":
                    return Mult(mathData.FirstNumber, mathData.SecondNumber);
                case "/":
                    if (mathData.SecondNumber == 0)
                    {
                        Console.WriteLine("Dzielenie przez zero!");
                        return 0;
                    }
                    return Div(mathData.FirstNumber, mathData.SecondNumber);
                default:
                    Console.WriteLine("Nieznana operacja!");
                    return 0;
            }
        }

        private static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        private static double Subtr(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        private static double Mult(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        private static double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
