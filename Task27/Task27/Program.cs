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
            Random rand = new Random();
            Console.WriteLine("Добро пожаловать на гладиаторские бои");
            Console.WriteLine("Для выбора доступно 5 классов. 1 - воин, 2 - лучник, 3 - маг, 4 - рыцарь, 5 - варвор");
            Console.Write("Выберите вашего бойца(введите цифру): ");
            string command = Console.ReadLine();
            Class _class = null;
            _class = ChooseHro(command, _class);
            Class _2class = null;
            Console.Write("Выберите вашего противника(введите цифру): ");
            command = Console.ReadLine();
            _2class = ChooseHro(command, _2class);
            int intcommand;
            int random;
            while (_class.Health > 0 && _2class.Health > 0)
            {
                Console.WriteLine("Выберите нанести обычный удар (1) или спец удар (2).");
                Console.Write("Введите число: ");
                intcommand = Convert.ToInt32(Console.ReadLine());
                Atack(intcommand,_2class);
                random = rand.Next(1, 3);
                Atack(random, _class);
                Console.WriteLine($"Здоровье  вашего героя - {_class.Health}. Здоровье врага - {_2class.Health}");
            }

            if(_class.Health <= 0)
            {
                Console.WriteLine("Вы проиграли");
            }
            else
            {
                Console.WriteLine("Вы победили");
            }
            Console.ReadKey();
        }
        static Class ChooseHro(string command,Class _class)
        {
            switch (command)
            {
                case "1":
                    _class = new Warior(500f, 20f, 10f);
                    break;
                case "2":
                    _class = new Archer(400f,40f,15f);
                    break;
                case "3":
                    _class = new Wizard(350f, 50f,20f);
                    break;
                case "4":
                    _class = new Crusader(500f,15f,5f);
                    break;
                case "5":
                    _class = new Barbarian(450f,35f, 10f);
                    break;
                default:
                    Console.WriteLine("Такого класса нет");
                    break;
            }
            return _class;
        }
        static void Atack(int command, Class _class )
        {
            switch (command)
            {
                case 1:
                    _class.ApplyDamage(_class.Damage);
                    break;
                case 2:
                    _class.SpeciallSkiil(_class.SpecialSkillDamage);
                    break;
                default:
                    Console.WriteLine("Такой способности нет.");
                    break;
            }
        }
      
    }

    abstract class Class
    {
        public float Health { get; private set; }
        public float Damage { get; private set; }
        public float SpecialSkillDamage { get; private set; }

        public Class(float health, float damage, float skill)
        {
            Health = health;
            Damage = damage;
            SpecialSkillDamage = skill;
        }

        public void  ApplyDamage(float damage)
        {
            Health -= ProcessDamage(damage);
        }
        public void SpeciallSkiil(float damage)
        {
            Health -= ProcessDamage(damage);
        }

        protected abstract float ProcessDamage(float damage);
        protected abstract float PricessSkillDamage(float damage);
    }

    class Warior : Class
    {
        public Warior(float health, float damage, float skill): base(health, damage, skill)
        {

        }

        protected override float PricessSkillDamage(float damage)
        {
           return damage * 1.5f;
        }

        protected override float ProcessDamage(float damage)
        {
            return damage;
        }
    }

    class Archer : Class
    {
        public Archer(float health, float damage, float skill) : base(health, damage, skill)
        {

        }

        protected override float PricessSkillDamage(float damage)
        {
            return damage * 2f;
        }

        protected override float ProcessDamage(float damage)
        {
            return damage * 1.5f;
        }
    }

    class Wizard : Class
    {
        public Wizard(float health, float damage, float skill) : base(health, damage, skill)
        {

        }

        protected override float PricessSkillDamage(float damage)
        {
            return damage * 4f;
        }

        protected override float ProcessDamage(float damage)
        {
            return damage * 2f;
        }
    }

    class Crusader : Class
    {
        public Crusader(float health, float damage, float skill) : base(health, damage, skill)
        {

        }

        protected override float PricessSkillDamage(float damage)
        {
            return damage * 2f;
        }

        protected override float ProcessDamage(float damage)
        {
            return damage / 2f;
        }
    }

    class Barbarian : Class
    {

        public Barbarian(float health, float damage, float skill) : base(health, damage, skill)
        {

        }
        public void DoSpecialSkill(Class _class)
        {
            throw new NotImplementedException();
        }

        protected override float PricessSkillDamage(float damage)
        {
            return damage * 3f;
        }

        protected override float ProcessDamage(float damage)
        {
            return damage / 1.5f;
        }
    }
}
