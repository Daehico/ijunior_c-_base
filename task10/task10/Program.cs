using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char _char;
            int lengthName;

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ которым вы хотите обвести ваше имя");
            _char = Console.ReadKey().KeyChar;
            lengthName = name.Length;

            for (int i = 0; i < lengthName + 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(_char);
                }
                else
                {
                    Console.Write(_char);
                }
            }

            Console.WriteLine(_char);

            for (int i = 0; i < lengthName + 1; i++)
            {
                if (i == 1)
                {
                    Console.Write(name);
                }
                else
                {
                    Console.Write(_char);
                }
            }


            for (int i = 0; i < lengthName + 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(_char);
                }

                else
                {
                    Console.Write(_char);
                }

            }
            Console.ReadKey();
        }
    }
}
