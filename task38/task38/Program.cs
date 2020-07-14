using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task38
{
    class Program
    {
        static void Main(string[] args)
        {
            Prison prison = new Prison();
            Prisoner prisoner1 = new Prisoner("Евгений", "Японец", false, 170, 60);
            Prisoner prisoner2 = new Prisoner("Олег", "Вьетнамец", false, 170, 60);
            Prisoner prisoner3 = new Prisoner("Олег", "Вьетнамец", true, 170, 60);

            prison.AddPrisoner(prisoner1);
            prison.AddPrisoner(prisoner2);
            prison.AddPrisoner(prisoner3);

            Console.Write("Введите рост: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите национальность: ");
            string nationality = Console.ReadLine();
            prison.Search(height, weight, nationality);
            Console.ReadKey();
        }
    }

    class Prisoner
    {
        public string Name { get; private set; }
        public string Nationality { get; private set; }
        public bool IsUnderArest { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }

        public Prisoner(string name, string nationality, bool isunderarest, int height, int weight)
        {
            Name = name;
            Nationality = nationality;
            IsUnderArest = isunderarest;
            Height = height;
            Weight = weight;
        }
    }

    class Prison
    {
        private List<Prisoner> _prisoners = new List<Prisoner>();

        public void AddPrisoner(Prisoner prisoner)
        {
            _prisoners.Add(prisoner);
        }

        public void Search(int height, int weight, string nationality)
        {
            var result = _prisoners.Where(i => i.Height == height).Where(y => y.Weight == weight).Where(a => a.Nationality == nationality).Where(b => b.IsUnderArest == false).ToList();
            foreach (var prisoner in result)
            {
                Console.WriteLine($"Имя - {prisoner.Name}, национальность - {prisoner.Nationality}, рост - {prisoner.Height}, вес - {prisoner.Weight}");
            }
          
        }
    }
}
