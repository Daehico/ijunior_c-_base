using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task24
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            string command;
            while (true)
            {
                Console.WriteLine("Для того что бы создать нового игрока нажмите 0. Для того что бы удалить игрока введите - 1. \nДля того что бы забанить игрока введите -2. Для того что бы разбанить игрока нажмите - 3.");
                Console.Write("Введите команду: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "0":
                        Console.Write("Введите ID героя: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите имя героя: ");
                        string heroName = Console.ReadLine();
                        Console.Write("Введите уровень героя: ");
                        int level = Convert.ToInt32(Console.ReadLine());
                        bool banOrNot = false;
                        Hero newHero = new Hero(id,heroName,level,banOrNot);
                        database.AddHero(newHero);
                        break;
                    case "1":
                        Console.Write("Введите Id героя которого хотите удалить: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        database.DeleteHero(id);
                        break;
                    case "2":
                        Console.Write("Введите Id героя которого хотите забанить: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        database.BanHero(id);
                        break;
                    case "3":
                        Console.Write("Введите Id героя которого хотите разбанить: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        database.UnBanHero(id);
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }

        class Hero
        {
            

            public string Name { get;  }
            public int Id { get; }
            public int Level { get; }
            public bool Ban { get; private set; }

            public Hero(int id, string name, int level, bool ban)
            {
                Id = id;
                Name = name;
                Level = level;
                Ban = ban;
            }
           
            public void BanHero()
            {
                Ban = true;
            }

            public void UnBanHero()
            {
                Ban = false;
            }

        }

        class Database
        {
            private List<Hero> _heroesList = new List<Hero>();

            public void AddHero(Hero hero)
            {
                _heroesList.Add(hero);

            }
            public void BanHero(int id)
            {
                _heroesList[id].BanHero();
            }

            public void DeleteHero(int id)
            {
                _heroesList.RemoveAt(id);
            }

            public void UnBanHero(int id)
            { 
               _heroesList[id].UnBanHero();
            }

        }
    }
}