using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30] { 10, 20, 50, 44, 33, 11, 0, 20, 116, 9, 4, 5, 6, 7, 8, 9, 10, 20, 55, 80, 33, 26, 55, 22, 10, 8, 4, 3, 4, 2 };
            int localMaximum;

            Console.WriteLine("Программа выводит локальные максимумы");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        localMaximum = array[i];
                        Console.WriteLine(localMaximum);
                    }

                }
                else if (i == array.Length - 1)
                {
                    if (array[i] > array[i - 1])
                    {
                        localMaximum = array[i];
                        Console.WriteLine(localMaximum);
                    }
                }
                else
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        localMaximum = array[i];
                        Console.WriteLine(localMaximum);
                    }
                }            
            }

            Console.ReadKey();
        }
    }
}