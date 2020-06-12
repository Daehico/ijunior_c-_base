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
            int returnInput;
            returnInput = Reading();
            Console.WriteLine("Число - " + returnInput);
            Console.ReadKey();

        }

        static int Reading()
        {
            string userInput = null;
            int number = 0;
            bool intIsinput = false;
            while (intIsinput == false)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();

                bool successConvert = Int32.TryParse(userInput, out int result);
                if (successConvert == true)
                {
                    intIsinput = true;
                    number = result;
                }
                else
                {
                    Console.WriteLine("Вы ввели ни число. Попробуйте еще раз.");
                }
            }
            return number;
        }
    }
}
