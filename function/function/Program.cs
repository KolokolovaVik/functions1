using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isIncluded = true;
            string[] array1 = new string[0];
            int[] array = new int[0];


            while (isIncluded)
            {
                Fio(array1, array);

                static void Fio(string[] fio, int[]array)
                {
                    Console.SetCursorPosition(0, 0);
                    string[] tempArray = new string[array.Length + 1];
                    Console.Write("Введите ФИО:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                        Console.Write(array[i]);
                    }
                    tempArray[tempArray.Length - 1] = Console.ReadLine();
                    array = tempArray;
                }
            }







            //    string[] arrayFio = new string[0];
            //    string[] funstions;
            //    string surname = "";
            //    string name = "";
            //    string middleName = "";

            //    while (true)
            //    {
            //        Dose(arrayFio, ref surname, ref name, ref middleName);
            //        Viviod(surname, name, middleName);

            //    }




            //}
            //static string[] Dose(string[] fio, ref string surname, ref string name, ref string middleName)
            //{
            //    string[] arrayFio = new string[0];


            //    string[] tepmArray = new string[arrayFio.Length + 1];
            //    for (int i = 0; i < fio.Length; i++)
            //    {
            //        tepmArray[i] = fio[i];

            //        Console.WriteLine(fio[i]);
            //    }
            //    //Console.Write("Введите фамилию:");
            //    //surname = Console.ReadLine();
            //    //Console.Write("Введите имя:");
            //    //name = Console.ReadLine();
            //    //Console.Write("Введите отчество");
            //   // middleName = Console.ReadLine();
            //    Console.Write("Введите фамилию:");
            //   surname =  tepmArray[tepmArray.Length - 1] = Console.ReadLine();
            //    Console.Write("Введите имя:");
            //    name =  tepmArray[tepmArray.Length - 1] = Console.ReadLine();
            //    fio = tepmArray;
            //    return fio;            
            //}

            //static void Viviod(string surname, string name, string middleName)
            //{
            //    Console.WriteLine("ФИО: " + surname, name, middleName + " fffff");
            //}










            //Console.SetCursorPosition(0, 5);
            //Console.WriteLine("Выберите команду: \nsum - сумма всех введённых чисел; \nsort - программа отсортирует массив; " +
            //    "\nexit - выход из программы;\nНажмите любую клавишу для пропуска ввода команды.");



            //string userInput = " ";
            //switch (userInput = Console.ReadLine().ToLower())
            //{
            //    case "sum":
            //        ////int sum = 0;
            //        ////for (int i = 0; i < array.Length; i++)
            //        ////{
            //        ////    sum += array[i];
            //        ////}
            //        //Console.Write("Сумма введённых чисел:" + sum);
            //        //sum = 0;
            //        break;
            //    case "sort":
            //        //for (int i = 0; i < array.Length; i++)
            //        //{
            //        //    for (int j = 0; j < array.Length - 1; j++)
            //        //    {
            //        //        if (array[j] > array[j + 1])
            //        //        {
            //        //            int sortArray = array[j];
            //        //            array[j] = array[j + 1];
            //        //            array[j + 1] = sortArray;
            //        //        }

            //        //    }
            //        //}
            //        break;
            //    case "exit":
            //        isIncluded = false;
            //        break;
            //}
            //Console.WriteLine("\nНажмите любую клвишу");
            //Console.ReadKey();
            //Console.Clear();




        }
    }
}

