using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task37
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100f, 15f, 15f);
            Archer archer = new Archer(80f, 30f, 10f);
            Wizard wizard = new Wizard(50f, 40f, 5f);

            Barbarian barbarian = new Barbarian(150f, 20f, 5f);
            Crossbowman crossbowman = new Crossbowman(100f, 30f, 15f);
            Necromancer necromancer = new Necromancer(80f, 20f, 10f);

            Platoon platoon1 = new Platoon(1);
            Platoon platoon2 = new Platoon(2);

            platoon1.AddSoldier(knight);
            platoon1.AddSoldier(archer);
            platoon1.AddSoldier(wizard);

            platoon2.AddSoldier(barbarian);
            platoon2.AddSoldier(crossbowman);
            platoon2.AddSoldier(necromancer);

            Soldier soldier1 ;
            Soldier soldier2;
            bool checkSoldiersInPlatoon = true;
            Random rand = new Random();

            while(checkSoldiersInPlatoon != false)
            {
                
                for (int i = 0; i < platoon1.Count; i++)
                {
                    for (int y = 0; y < platoon2.Count; y++)
                    {
                        soldier1 = platoon2.GetSoldier(y);
                        soldier2 = platoon1.GetSoldier(i);
                        int index =  rand.Next(0, 2);
                        if(index == 0)
                        {
                            platoon2.Atack(soldier1, soldier2.Damage);
                        }
                        else
                        {
                            soldier1.DoSpeciallSkill();
                        }
                        Atack(platoon1, platoon2, y, soldier1, soldier2);
                    }
                }

                for (int i = 0; i < platoon2.Count; i++)
                {
                    for (int y = 0; y < platoon1.Count; y++)
                    {
                        soldier1 = platoon1.GetSoldier(y);
                        soldier2 = platoon2.GetSoldier(i);
                        platoon1.Atack(soldier1, soldier2.Damage);
                        int index = rand.Next(0, 2);
                        if (index == 0)
                        {
                            Atack(platoon1, platoon2, y, soldier1, soldier2);
                        }
                        else
                        {
                            soldier1.DoSpeciallSkill();
                        }
                        
                    }
                }
                checkSoldiersInPlatoon = platoon1.CheckSoldiersInPlatoon();
                checkSoldiersInPlatoon = platoon1.CheckSoldiersInPlatoon();
                Console.ReadKey();
            }
            bool checkPlatoon1 = platoon1.CheckSoldiersInPlatoon();
            bool checkPlatoon2 = platoon2.CheckSoldiersInPlatoon();
            if(checkPlatoon1 == false)
            {
                Console.WriteLine("Взвод № 1 уничтожен");
            }
            if (checkPlatoon2 == false)
            {
                Console.WriteLine("Взвод № 2 уничтожен");
            }
            Console.ReadKey();
        }

        static void Atack(Platoon platoon1, Platoon platoon2, int y, Soldier soldier1, Soldier soldier2)
        {
           
            Console.WriteLine($"Результат боя: Солдат под номером - {y} имеет - {soldier1.Health} - здоровья");
            platoon1.CheckSoldierHealth();
            platoon2.CheckSoldierHealth();
        }
    }

    class Platoon
    {
        private List<Soldier> _soldiers = new List<Soldier>();
        
        public int Id { get; private set; }

        public int Count { get => _soldiers.Count; }

        public Platoon(int id)
        {
            Id = id;
        }

        public void AddSoldier(Soldier soldier)
        {
            _soldiers.Add(soldier);
        }

        public void DeleteSoldier(int id)
        {
            _soldiers.RemoveAt(id);
        }

        public void CheckSoldierHealth()
        {
            for (int i = 0; i < _soldiers.Count; i++)
            {
                if(_soldiers[i].Health <= 0)
                {
                    Console.WriteLine($"Солдат взода №{Id} под номером - {i} - умер");
                    DeleteSoldier(i);
                }
            }
        }

        public void Atack(Soldier soldier, float damage)
        {
            soldier.AplyDamage(damage);
        }

        public Soldier GetSoldier(int id)
        {
            return _soldiers[id];
        }

        public bool CheckSoldiersInPlatoon()
        {
            return _soldiers.Count != 0;
        }
    }

    abstract class Soldier
    {
        public float Health { get; private set; }
        public float Damage { get; private set; }
        public float Armor { get; private set; }

        public Soldier(float health, float damage, float armor)
        {
            Health = health;
            Damage = damage;
            Armor = armor;
        }

        public void AplyDamage(float dps)
        {
            Health -= dps - Armor;
        }

        public void AddHealth(float health)
        {
            Health += health;
        }

        public void AddDamage(float damage)
        {
            Damage += damage;
        }

        public void AddArmor(float armor)
        {
            Armor += armor;
        }

        public abstract void DoSpeciallSkill();
    }
    
    class Knight : Soldier
    {
        public Knight(float health, float damage, float armor)
            :base( health, damage, armor)
        {

        }


        public override void DoSpeciallSkill()
        {
            AddHealth(50f);
        }
    }

    class Archer : Soldier
    {
        public Archer(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }

        public override void DoSpeciallSkill()
        {
            AddDamage(20f);
        }
    }

    class Wizard : Soldier
    {
        public Wizard(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }
        public override void DoSpeciallSkill()
        {
            AddArmor(10f);
        }
    }

    class Barbarian : Soldier
    {
        public Barbarian(float health, float damage, float armor)
            : base(health, damage, armor)
        {
           
        }

        public override void DoSpeciallSkill()
        {
            AddDamage(25f);
        }
    }

    class Crossbowman : Soldier
    {
        public Crossbowman(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }

        public override void DoSpeciallSkill()
        {
            AddDamage(30f);
        }
    }

    class Necromancer : Soldier
    {
        public Necromancer(float health, float damage, float armor)
            : base(health, damage, armor)
        {

        }

        public override void DoSpeciallSkill()
        {
           AddArmor(15f);
        }
    }
}
