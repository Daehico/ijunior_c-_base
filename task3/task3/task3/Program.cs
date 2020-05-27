using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countsOfPhotos = 52;
            int countsOfPhotosInRow = 3;

            int countsOfFullRow = countsOfPhotos / countsOfPhotosInRow;
            float remainder = Convert.ToSingle(countsOfPhotos) % countsOfPhotosInRow;

            Console.WriteLine("Количество заполненных рядов - " + countsOfFullRow);
            Console.WriteLine("Картинок сверх меры - " + remainder);

            Console.ReadKey();

        }
    }
}
