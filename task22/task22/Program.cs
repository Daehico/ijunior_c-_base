using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Sin", 100,150,200,30);
            player1.ShowStats();
            Console.ReadKey();
        }
    }

    class Player
    {
        private string _heroName;
        private int _heroHP;
        private int _heroMana;
        private int _heroStamina;
        private int _heroDamage;
        
        public Player(string name, int hp, int mana, int stamina, int damage)
        {
            _heroName = name;
            _heroHP = hp;
            _heroMana = mana;
            _heroStamina = stamina;
            _heroDamage = damage;
        }

        public void ShowStats()
        {
            Console.WriteLine(@"Имя героя - " + _heroName + "\nЗдоровье героя - " + _heroHP + ". \nМана героя - " + _heroMana + "\nВыносливость героя - " + _heroStamina + ". \nУрон героя - " + _heroDamage + ".");
        }
    }
}
