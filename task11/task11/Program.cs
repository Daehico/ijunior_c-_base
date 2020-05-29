using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "123456";
            int count = 3;
            string inputPassword;

            for(int i = 0; i < count; i++)
            {
                Console.Write("Введите пароль: ");
                inputPassword = Console.ReadLine();
                if(inputPassword == password)
                {
                    Console.WriteLine("Cекрет");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно. Попробуйте еще раз");
                }
            }
        }
    }
}
