using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task32
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command !="выйти")
            {
                Console.WriteLine("Введите комманду что-то, что бы сделать что-то. Для того что бы выйти введите комманду выйти");
                Console.Write("Введите комманду: ");
                command = Console.ReadLine().ToLower();
                if(command == "что-то")
                {
                    Console.WriteLine("Программа сделала что-то");
                }
                else
                {
                    Console.WriteLine("Такой команды нет");
                }
            }

        }
    }
}
