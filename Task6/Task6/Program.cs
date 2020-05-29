using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут?");
            string name = Console.ReadLine();
            Console.Write("Сколько вам лет?");
            string age = Console.ReadLine();
            Console.Write("Где вы работаете?");
            string workplace = Console.ReadLine();

            Console.WriteLine("Вас зовут - " + name + " .Вам - " + age + " лет." + " Вы работаете - " + workplace);
            Console.ReadKey();
        }
    }
}
