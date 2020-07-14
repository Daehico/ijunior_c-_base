using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier("Евгений", "Револьвер", "Прапорщик", 20);
            Soldier soldier2 = new Soldier("Михаил", "Ружье", "Сеержант", 15);
            Soldier soldier3 = new Soldier("Павел", "Калашников", "Рядовой", 10);
            Soldier soldier4= new Soldier("Александр", "Гранатомет", "Майор", 50);
            Soldier soldier5 = new Soldier("Дмитрий", "Пулемет", "Полковник", 70);

            List<Soldier> soldiers = new List<Soldier>();
            soldiers.Add(soldier1);
            soldiers.Add(soldier2);
            soldiers.Add(soldier3);
            soldiers.Add(soldier4);
            soldiers.Add(soldier5);

            var _soldiers = from Soldier soldier in soldiers
                            select new
                            {
                                name = soldier.Name,
                                rank = soldier.Rank

                            };
            foreach (var soldier in _soldiers)
            {
                Console.WriteLine($"Имя - {soldier.name}. Звание - {soldier.rank}");
            }

            Console.ReadKey();
        }
    }

    class Soldier
    {
        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int ServiceTime { get; private set; }

        public Soldier(string name, string weapon, string rank, int servicerime)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServiceTime = servicerime;
        }

    }
}
