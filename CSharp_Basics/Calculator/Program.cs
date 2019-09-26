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
                    double pnum1 = UI1.GetValueFromUser("First number=");
                    double pnum2 = UI1.GetValueFromUser("Second number=");
                    string operation = UI1.GetOperationFromUser();
                    result = Calculations.Calculation(operation, pnum1, pnum2);
                    Console.WriteLine($"Wynik={result}");
                    Console.ReadKey();
                }
        }

        
    }
}
