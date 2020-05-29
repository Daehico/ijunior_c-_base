using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы входите в поликлинику и видите очередь из старушек");
            Console.Write("Введите количество старушек в очереди: ");
            uint countOfGrandmothers =Convert.ToUInt32(Console.ReadLine());
            uint timeOfOneGranmothers = 10;
            uint timeInTurn = timeOfOneGranmothers * countOfGrandmothers;
            uint timeInTurnInHour = timeInTurn / 60;
            float timeInTurnInMinutes = timeInTurn % 60; 

            Console.WriteLine("Общее время в очереди - " + timeInTurnInHour + " часов и " + timeInTurnInMinutes + " минут");
            Console.ReadKey();
        }
    }
}
