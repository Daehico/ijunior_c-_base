using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            string returnInput;
            returnInput = EnterNumber();
            Console.WriteLine("Число - " + returnInput);
            Console.ReadKey();

        }

        static string EnterNumber()
        {
            string userInput = null;
            bool intIsinput = false;
            while (intIsinput == false)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();

                bool successConvert = Int32.TryParse(userInput, out int result);
                if (successConvert == true)
                {
                    intIsinput = true;
                }
                else
                {
                    Console.WriteLine("Вы ввели ни число. Попробуйте еще раз.");
                }
            }
            return userInput;
        }
    }
}
