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
                /*MathData mathData = new MathData();
                mathData.FirstNumber = UI1.GetValueFromUser("First number=");
                mathData.SecondNumber = UI1.GetValueFromUser("Second number=");
                mathData.Operation = UI1.GetOperationFromUser();*/
                MathData mathData = UI1.GetAllValuesFromUser();
                result = Calculations.Calculation(mathData);
                Console.WriteLine($"Wynik={result}");
                Console.ReadKey();
                }
        }

        
    }
}
