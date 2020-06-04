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
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            array = Shuffle(array);
            Console.WriteLine("Новый массив");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }

        static string[] Shuffle(string[] array)
        {
            Random rand = new Random();
            string[] copy = new string[array.Length];
            Array.Copy(array, copy,array.Length );
            for(int i = 0; i < copy.Length; i++)
            {
                array[rand.Next(0, copy.Length)] = copy[i];
            }
            return array;
        }

    }
}
