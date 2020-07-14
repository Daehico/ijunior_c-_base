using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст который хотите вывести: ");
            string text = Console.ReadLine();
            Console.Write("Введите число. Текст ввыведется заданное количество раз: ");
            int index = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < index; i++)
            {
                Console.WriteLine(text);
            }

            Console.ReadKey();
        }
    }
}
