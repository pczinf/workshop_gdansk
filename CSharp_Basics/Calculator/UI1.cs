using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UI1
    {
        public static MathData GetAllValuesFromUser()
        {
            double first = GetValueFromUser("First number=");
            double second = GetValueFromUser("Second number=");
            string operation = GetOperationFromUser();

            return new MathData(first, second, operation);
        }
            public static double GetValueFromUser(string message)
        {
            double pnum1;
            while (true)
            {
                Console.Write(message);
                string valueFromUser = Console.ReadLine();
                if (IsQuit(valueFromUser))
                {
                    Quit();
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
            if (IsQuit(oper))
            {
                Quit();
            }
            return oper;
        }
        private static void Quit()
        {
                    Console.WriteLine("KONIEC");
                    Console.ReadKey();
                    Environment.Exit(0);
         }
        private static bool IsQuit(string entry)
        {
            if (entry == "q") { return true; }
            else return false;
        }
    }
}
