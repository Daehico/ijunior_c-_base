using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task33
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0; 
            Queue<int> customers = new Queue<int>();
            customers.Enqueue(50);
            customers.Enqueue(60);
            customers.Enqueue(70);
            customers.Enqueue(90);
            customers.Enqueue(100);
            int index = customers.Count;
            for (int i = 0; i < index; i++)
            {
                money += customers.Dequeue();
                Console.WriteLine($"Вы обслужили клиента теперь у вас на счету: {money} денег");
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
