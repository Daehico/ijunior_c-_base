using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {

        static void Main(string[] args)
        {
            bool gameWork = true;
            Random random = new Random();
            Hero[] fighters = { new Warior(400f, 30f, 30f), new Archer(300f,40f, 15f), new Wizzard(250f, 50f, 10f), new Barbarian(350f, 35f, 15f), new Crusader(400f, 25f, 40f)};
            Console.Write("Ввебирите бойца, введите число от 0 до 4: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Hero firstFighter = fighters[id];
            Console.Write("Ввебирите второго бойца, введите число от 0 до 4: ");
            id = Convert.ToInt32(Console.ReadLine());
            Hero secondFighters = fighters[id];

            while(gameWork != false)
            {
                Console.Write("Введите 0 или 1. 0 - обычная атака, 1 - специальная атака: ");
                int command = Convert.ToInt32(Console.ReadLine());
                if(command == 0)
                {
                    firstFighter.Attack(secondFighters);
                }
                else if(command == 1)
                {
                    firstFighter.DoSpecialSkill();
                }
                else
                {
                    Console.WriteLine("Такой комманды нет.");
                }
                command = random.Next(0, 2);
                if (command == 0)
                {
                    secondFighters.Attack( firstFighter);
                }
                else if (command == 1)
                {
                    secondFighters.DoSpecialSkill();
                }
                else
                {
                    Console.WriteLine("Такой комманды нет.");
                }
                firstFighter.ShowHealth(firstFighter, secondFighters);
                gameWork = firstFighter.CheckFightersHealth();
            }
           
        }
      
    }

    abstract class Hero
    {
        protected float Health { get; set; }
        protected float Damage { get; set; }
        protected float Armor { get; set; }

        public Hero(float health, float damage,  float armor)
        {
            Health = health;
            Damage = damage;
            Armor = armor;
        }

        public void Attack(Hero seconFighter)
        {
            seconFighter.Health -= Damage - Armor;
        }

        public bool CheckFightersHealth()
        {
            return Health > 0;
        }

        public void ShowHealth(Hero firstFighter, Hero secondFighter)
        {
            Console.WriteLine($"Здоровье первого бойца - {firstFighter.Health}.");
            Console.WriteLine($"Здоровье второго бойца - {secondFighter.Health}.");
        }

        public abstract void DoSpecialSkill();
    }

    class Warior : Hero
    {
        public Warior(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }
        public override void DoSpecialSkill()
        {
            Armor += 2f;
            Damage -= 2f;
        }
    }

    class Archer : Hero
    {
        public Archer(float health, float damage,  float armor)
            : base(health, damage, armor)
        {
           
        }

        public override void DoSpecialSkill()
        {
            Damage += 10f;
            Armor -= 10f;
        }
    }

    class Wizzard : Hero
    {
        public Wizzard(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }

        public override void DoSpecialSkill()
        {
            Armor /= 2f;
            Damage *= 2f;
        }
    }

    class Barbarian : Hero
    {
        public Barbarian(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }

        public override void DoSpecialSkill()
        {
            Armor /= 2f;
            Health -= 20f;
            Damage -= 30f;
        }
    }

    class Crusader : Hero
    {
        public Crusader(float health, float damage,  float armor)
            : base(health, damage, armor)
        {

        }

        public override void DoSpecialSkill()
        {
            Armor += 20f;
            Damage -= 10f;
        }
    }
}
