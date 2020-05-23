using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            OutputInteger(out number);
        }

        static void OutputInteger(out int number)
        {
           number = 0;

            bool isWork = true;
            while (isWork)
            {
                Console.Write("\nВведите число: ");
                string numeral = Console.ReadLine();
                bool result = int.TryParse(numeral, out number);
                if (result)
                {
                    Console.WriteLine("Ура! Вы ввели число: " + number);
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("\nНе число! Попробуйте ещё раз.");
                }
            }
        }
    }
}
