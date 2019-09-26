using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Program
    {
        static bool quit = false;
        public static void Main(string[] args)
        {
            /* double x = 14;
             double y = 230;
             double z = 30;
             double result = x * y;
             */
            double result;
            int i = 0;
            /*while (i<10)
            {
                i++;
            }*/
            /*do { i++;
            
            } while (i<10);*/
            /*for (int j=0;j<10;j++)
            { }*/
            while (!quit)
                {
                    double pnum1 = GetValueFromUser("First number=");
                if (quit)
                {
                    Console.WriteLine("KONIEC");
                    Console.ReadKey();
                    return;
                }
                    double pnum2 = GetValueFromUser("Second number=");
                if (quit)
                {
                    Console.WriteLine("KONIEC");
                    Console.ReadKey();
                    return;
                }
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
                    if (operation == "q")
                    {
                        Console.WriteLine("KONIEC");
                        Console.ReadKey();
                        return;
                    }
                    result = Calculation(operation, pnum1, pnum2);
                    Console.WriteLine($"Wynik={result}");
                    Console.ReadKey();
                }
        }

        public static double GetValueFromUser(string message)
        {
            double pnum1;
            while (true)
            {
                Console.Write(message);
                string valueFromUser = Console.ReadLine();
                if (valueFromUser=="q")
                { quit = true;
                    return 0;
                }
                if (!double.TryParse(valueFromUser, out pnum1))
                { ///Console.WriteLine("Nieliczba! Popraw!");
                    message = "Nieliczba! Popraw! ";
                }
                else return pnum1;
            }
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
