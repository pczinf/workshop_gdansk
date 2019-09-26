using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UI1
    {
        public static double GetValueFromUser(string message)
        {
            double pnum1;
            while (true)
            {
                Console.Write(message);
                string valueFromUser = Console.ReadLine();
                if (valueFromUser == "q")
                {
                    Console.WriteLine("KONIEC");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (!double.TryParse(valueFromUser, out pnum1))
                { ///Console.WriteLine("Nieliczba! Popraw!");
                    message = "Nieliczba! Popraw! ";
                }
                else return pnum1;
            }
        }

        public static string GetOperationFromUser()
        {
            
            Console.Write("Operation: ");
            string oper = Console.ReadLine();
            if (oper == "q")
            {
                Console.WriteLine("KONIEC");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return oper;
        }
        }
}
