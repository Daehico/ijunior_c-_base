using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task28
{
    class Program
    {
        static void Main(string[] args)
        {
            Aquarium aquarium = new Aquarium(100);
            Fish fish1 = new Fish();
            Fish fish2 = new Fish();
            Fish fish3 = new Fish();
            aquarium.AddFish(fish1);
            aquarium.AddFish(fish2);
            aquarium.AddFish(fish3);
          
            while (true)
            {
                Console.Write("Если хотите добавить рыбку нажмите - 0, если хотите достать рыбку нажмите - 1, если не хотите ни чего делать нажмите - 3");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 0:
                        Fish fish = new Fish();
                        aquarium.AddFish(fish);
                        break;
                    case 1:
                        Console.Write("Введите Id рыбки которую хотите вытащить");
                        int id = Convert.ToInt32(Console.ReadLine());
                        aquarium.GetFish(id);
                        break;
                }

                for (int i = 0; i < aquarium.CountOfFishList; i++)
                {
                    aquarium.AddOneYear(i);
                    aquarium.KillFish(i);
                }
                aquarium.ShoWFishes();
            }
        }
    }

    class Aquarium
    {
        private List<Fish> _fishesList = new List<Fish>();
 
        public int MaxCapacity { get; private set; }

        public int CountOfFishList{ get => _fishesList.Count; }
       

        public Aquarium(int capacity)
        {
            MaxCapacity = capacity;
        }

        public void AddFish(Fish fish)
        {
            if(_fishesList.Count > MaxCapacity)
            {
                Console.WriteLine("Аквариум переполнен");
            }
            else
            {
                _fishesList.Add(fish);
            }         
        }

        public void GetFish(int id)
        {
            _fishesList.RemoveAt(id);
        }

        public void ShoWFishes()
        {
            foreach (var fish in _fishesList)
            {
                Console.WriteLine($"Рыбка живет - {fish.CurentLiveTime} год");
            }        
        }

        public void AddOneYear(int id)
        {
            _fishesList[id].AddOneYearOfLife();
        }

        public void KillFish(int id)
        {
            if(_fishesList[id].CurentLiveTime == _fishesList[id].MaxLiveTime)
            {
                GetFish(id);
                Console.WriteLine($"Рыбка под номер {id} умерла");
            }
        }
      
    }

    class Fish
    {
        public int CurentLiveTime { get ; private set ; }
        public int MaxLiveTime { get; private set ; }

        public Fish()
        {
            Random random = new Random();
            MaxLiveTime = random.Next(3, 6);
            CurentLiveTime = 0;
        }

        public void AddOneYearOfLife()
        {
            CurentLiveTime += 1;
        }

    }
}
