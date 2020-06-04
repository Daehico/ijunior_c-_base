using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { {1,2,3,4 }, {9,10,11,20 }, {36,24,33,10 } };
            int sum = 0;
            int product = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " | ");                      
                }
                Console.WriteLine();
                product *= array[i, 0];
            }
           
            for(int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[1, i];
            }
            Console.WriteLine("Сумма - " + sum);
            Console.WriteLine("Произведение - " + product);
            Console.ReadKey();
        }
    }
}
