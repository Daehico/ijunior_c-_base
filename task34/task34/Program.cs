using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string command = " ";
            int sum = 0;
            bool sucsessParse;

            while (command != "выйти")
            {
                Console.WriteLine("Программа собирает числа. После ввода команды sum программа посчитает сумму чисел. Для того что бы выйти введите выйти");
                Console.Write("Введите комманду или число: ");
                command = Console.ReadLine();

                if(command == "sum")
                {
                    foreach(var number in numbers)
                    {
                        sum += number;
                    }
                    Console.WriteLine($"Сумма {sum}");
                    sum = 0;
                }
                else
                {
                  sucsessParse =  int.TryParse(command, out int result);
                    if (sucsessParse)
                    {
                        numbers.Add(result);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число");
                    }

                }
            }
           
        }
    }
}
