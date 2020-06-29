using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("Добро пожаловать в конфигуратор пасажирских поездов.");
                Console.Write("Введите начальную точку маршрута: ");
                string firstDirection = Console.ReadLine();
                Console.Write("Введите конечную точку маршрута: ");
                string secondDirection = Console.ReadLine();
                DirectionOfTrain directionOfTrain = new DirectionOfTrain(firstDirection, secondDirection);
                Console.WriteLine("Сейчас продаются билеты на сформированное направление.");
                int tickets = rand.Next(50, 201);
                Console.WriteLine($"Было продано - { tickets} билетов.");
                Console.WriteLine("Формируется поезд.");
                Train train = new Train();
                int counts = 0;
                int carriege;
                while(tickets > counts)
                {
                    carriege = rand.Next(25, 51);
                    train.AddCarriageToTrain(carriege);
                    counts += carriege;
                }
                Console.WriteLine("Поезд сформирован из следующих вагонов: ");
                foreach (var item in train.RailwayСarriages)
                {
                    Console.WriteLine($"Вагон с количество пасажиров - {item.CountOfPassengersOfRailwayСarriage} - зарезервирован.");
                }
                Console.WriteLine("Поезд отправлен");
            }
        }
    }

    class DirectionOfTrain
    {
        private string firstPoint;
        private string secondPoint;

        public DirectionOfTrain(string first,string second)
        {
            firstPoint = first;
            secondPoint = second;
        }
    }

    class Train
    {
        private List<RailwayСarriage> railwayСarriages = new List<RailwayСarriage>();

        public List<RailwayСarriage> RailwayСarriages { get => railwayСarriages; private set => railwayСarriages = value; }
        private RailwayСarriage railwayСarriage;

        public void AddCarriageToTrain(int count)
        {
            railwayСarriage = new RailwayСarriage(count);
            RailwayСarriages.Add(railwayСarriage);
        }
    }

    class RailwayСarriage
    {
        private int countOfPassengersOfRailwayСarriage;

        public int CountOfPassengersOfRailwayСarriage { get => countOfPassengersOfRailwayСarriage;private set => countOfPassengersOfRailwayСarriage = value; }

        public RailwayСarriage(int countOfPassengers)
        {
            CountOfPassengersOfRailwayСarriage = countOfPassengers;
        }
    }
}
