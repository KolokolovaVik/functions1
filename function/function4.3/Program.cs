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

            Integer(out number);
        }

        static int Integer(out int number)
        {
            number = 0;

            bool isWork = true;
            while (isWork)
            {
                Console.Write("\nВведите число: ");
                string n = Console.ReadLine();
                bool result = int.TryParse(n, out number);
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
            return number;
        }
    }
}
