using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
        public static double Calculation(string oper, double pnum1, double pnum2)
        {
            switch (oper)
            {
                case "+":
                    return Add(pnum1, pnum2);
                case "-":
                    return Subtr(pnum1, pnum2);
                case "*":
                case "x":
                    return Mult(pnum1, pnum2);
                case "/":
                    if (pnum2 == 0)
                    {
                        Console.WriteLine("Dzielenie przez zero!");
                        return 0;
                    }
                    return Div(pnum1, pnum2);
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
