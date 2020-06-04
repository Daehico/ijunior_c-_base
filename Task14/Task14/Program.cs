using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10] {
                {10, 20,30,45,50,70,90,20,30,1},
                {2,5,6,9,2,77,22,11,0,-1 },
                {6,5,28,34,66,77,22,10,0, 99},
                {0,1,4,77,88,23,24,25,26,77 },
                {33,2227,2500,6700,2223,88899,6000, 3300,6600, 5690 },
                {7,89,33,22,45,66,78,98,45,1},
                {666,89,35,33,44,20,1,10,22,33 },
                {888,787,99999,45,66,78,34,20,50, 60 },
                {30,45,22,22,55,660,22,33,20,10 },
                {69099,55,20,30,1,8,4,0,10,22 }
            };
            int max = int.MinValue;
            int maxPositionX = 0;
            int maxPositionY = 0;

            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " | ");
                    if(array[i,j] > max)
                    {
                        max = array[i, j];
                        maxPositionX = i;
                        maxPositionY = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальное число - " + max);
            array[maxPositionX, maxPositionY] = 0;
            Console.WriteLine("Новая матрица");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " | ");
                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
