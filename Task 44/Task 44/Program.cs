using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier("Борис");
            Soldier soldier2= new Soldier("Максим");
            Soldier soldier3 = new Soldier("Борис");
            Soldier soldier4 = new Soldier("Богдан");
            Soldier soldier5 = new Soldier("Александр");
            Soldier soldier6 = new Soldier("Дмитрий");

            List<Soldier> soldiers1 = new List<Soldier>();
            List<Soldier> soldiers2 = new List<Soldier>();

            soldiers1.Add(soldier1);
            soldiers1.Add(soldier2);
            soldiers1.Add(soldier3);
            soldiers2.Add(soldier4);
            soldiers2.Add(soldier5);
            soldiers2.Add(soldier6);

            var soldiersStartB = soldiers1.Where(i => i.Name.ToLower().StartsWith("б")).ToList();

            var result = soldiers2.Union(soldiersStartB);

            foreach (var soldier in result)
            {
                Console.WriteLine(soldier.Name);
            }
            Console.ReadKey();
        }
    }

    class Soldier
    {
        public string Name { get; private set; }

        public Soldier(string name)
        {
            Name = name;
        }
    }
}