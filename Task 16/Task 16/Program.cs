using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool work = true;
            string command;
            int userInt;
            int[] array = new int[1];           

            while (work)
            {
                Console.WriteLine("Программа выводить сумму введем пользователем чисел. Для того что бы вывести сумму введите команду - sum. Для того что бы выйти нажмите команду - exit.");
                Console.Write("Введите число:");
                command = Console.ReadLine();
                bool succesParseOrNor =  Int32.TryParse(command, out userInt);                         
                if (succesParseOrNor == true)
                {
                    int[] arrayCopy;
                    array[array.Length-1] = userInt;
                    arrayCopy = new int[array.Length + 1];
                   for (int i = 0; i < array.Length; i++)
                    {
                        arrayCopy[i] = array[i];
                    }
                    array = new int[arrayCopy.Length];
                    array = arrayCopy;
                }
                else
                {                  
                    if (command == "sum")
                    {
                        int sum = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        }
                        Console.WriteLine("Сумма: " + sum);
                    }
                    else if(command == "exit")
                    {
                        break;
                    }
                }
            }
        }
    }
}
