using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Program
    {
        public static void Main(string[] args)
        {
            /* double x = 14;
             double y = 230;
             double z = 30;
             double result = x * y;
             */
            double result;
          /*  Console.Write("First number=");
            string num1 = Console.ReadLine();
            ////int pnum1 = int.Parse(num1);
            ////double pnum1 = double.Parse(num1);
            double pnum1;
            if (!double.TryParse(num1, out pnum1))
            { Console.WriteLine($"Nieliczba! Używamy wartości domyślnej: {pnum1}"); }*/
            double pnum1 = GetValueFromUser("First number=");
          /*  Console.Write("Second number=");
            string num2 = Console.ReadLine();
            ////int pnum2 = int.Parse(num2);
            ////double pnum2 = double.Parse(num2);
            double pnum2;
            if (!double.TryParse(num2, out pnum2))
            { Console.WriteLine($"Nieliczba! Używamy wartości domyślnej: {pnum2}"); }*/
            double pnum2 = GetValueFromUser("Second number=");
            ////result = pnum1 * pnum2;
            ////Console.WriteLine("x*y="+result);
            ////Console.WriteLine($"x*y={result}");
            /*
            result = Add(pnum1, pnum2);
            Console.WriteLine($"x+y={result}");
            result = Subtr(pnum1, pnum2);
            Console.WriteLine($"x-y={result}");
            result = Mult(pnum1, pnum2);
            Console.WriteLine($"x*y={result}");
            result = Div(pnum1, pnum2);
            Console.WriteLine($"x/y={result}");
            */
            Console.Write("Operation: ");
            string operation = Console.ReadLine();
            /*
            if (operation == "+")
            {
                result = Add(pnum1, pnum2);
                Console.WriteLine($"x+y={result}");
            }
            else if (operation == "-")
            {
                result = Subtr(pnum1, pnum2);
                Console.WriteLine($"x-y={result}");
            }
            else if (operation == "*")
            {
                result = Mult(pnum1, pnum2);
                Console.WriteLine($"x*y={result}");
            }
            else if (operation == "/")
            {
                result = Div(pnum1, pnum2);
                Console.WriteLine($"x/y={result}");
            }
            else Console.WriteLine("Nieznana operacja!");
            */
            /*
            switch (operation)
            {
                case "+":
                result = Add(pnum1, pnum2);
                Console.WriteLine($"x+y={result}");
                    break;
                case "-":
                result = Subtr(pnum1, pnum2);
                Console.WriteLine($"x-y={result}");
                    break;
                case "*":
                case "x":
                result = Mult(pnum1, pnum2);
                Console.WriteLine($"x*y={result}");
                    break;
                case "/":
                    if (pnum2==0)
                    { Console.WriteLine("Dzielenie przez zero!");
                        break;
                    }
                result = Div(pnum1, pnum2);
                Console.WriteLine($"x/y={result}");
                    break;

                default: Console.WriteLine("Nieznana operacja!");
                    break;
        }*/
            result = Calculation(operation, pnum1, pnum2);
            Console.WriteLine($"Wynik={result}");
            Console.ReadKey();
        }

        public static double GetValueFromUser(string message)
        {
            Console.Write(message);
            string valueFromUser = Console.ReadLine();
            double pnum1;
            if (!double.TryParse(valueFromUser, out pnum1))
            { Console.WriteLine($"Nieliczba! Używamy wartości domyślnej: {pnum1}"); }
            return pnum1;
        }

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

        public static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public static double Subtr(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        public static double Mult(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public static double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
