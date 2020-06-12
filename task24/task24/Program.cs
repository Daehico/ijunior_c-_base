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
            Hero hero = new Hero();

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
                        hero.AddHero(id, heroName, level, banOrNot);

                        break;
                    case "1":
                        Console.Write("Введите Id героя которого хотите удалить: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        hero.DeleteHero(id);
                        break;
                    case "2":
                        Console.Write("Введите Id героя которого хотите забанить: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        hero.BanHero(id);
                        break;
                    case "3":
                        Console.Write("Введите Id героя которого хотите разбанить: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        hero.UnBanHero(id);
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }

            }
        }

        class Hero
        {
            private int _id;
            private string _name;
            private int _level;
            private bool _banOrNot;

            public List<Hero> heroes = new List<Hero>();

            public string Name { get => _name; private set => _name = value; }
            public int Id { get => _id; private set => _id = value; }
            public int Level { get => _level; private set => _level = value; }
            public bool BanOrNot { get => _banOrNot; private set => _banOrNot = value; }

            public Hero(int id, string name, int level, bool ban)
            {
                _id = id;
                _name = name;
                _level = level;
                _banOrNot = ban;
            }
            public Hero()
            {

            }

            public void AddHero(int id, string name, int level, bool ban)
            {
                heroes.Add(new Hero() { Id = id, Name = name, Level = level, BanOrNot = ban });

            }
            public void BanHero(int id)
            {
                heroes[id]._banOrNot = true;
            }

            public void DeleteHero(int id)
            {
                heroes.RemoveAt(id);
            }

            public void UnBanHero(int id)
            {
                heroes[id]._banOrNot = false;
            }
        }
    }
}