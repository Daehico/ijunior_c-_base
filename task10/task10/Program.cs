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

          for(int i = 0; i < lengthName+2; i++)
            {
                Console.SetCursorPosition(0 + i, 3);
                Console.Write(_char);
               
                if(i == 0)
                {
                    Console.SetCursorPosition(0, 4);
                    Console.Write(_char);
                    Console.Write(name);
                    Console.Write(_char);
                }

                Console.SetCursorPosition(0 + i, 5);
                Console.Write(_char);
            }

            Console.ReadKey();
        }
    }
}
