using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "здесь", "какие-то", "слова", "О_о" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Shuffle(array);
            Console.WriteLine("Новый массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        static void Shuffle(string[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int randomIndex = random.Next(i + 1);
                var arrayText = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = arrayText;
            }

        }
    }
}