using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task39
{
    class Program
    {
        static void Main(string[] args)
        {
            Prison prison = new Prison();
            Prisoner prisoner1 = new Prisoner("Евгений", "Антипрививочник");
            Prisoner prisoner2 = new Prisoner("Олег", "Вор");
            Prisoner prisoner3 = new Prisoner("Олег", "Убийца" );
            Prisoner prisoner4 = new Prisoner("Михаил", "Антипрививочник");

            prison.AddPrisoner(prisoner1);
            prison.AddPrisoner(prisoner2);
            prison.AddPrisoner(prisoner3);
            prison.AddPrisoner(prisoner4);

            Console.WriteLine("До амнистии");
            prison.ShowInfo();
            Console.WriteLine("После амнистии");
            prison.Amnesty();       
            Console.ReadKey();
        }
    }

    class Prisoner
    {
        public string Name { get; private set; }
        public string Crime { get; private set; }


        public Prisoner(string name, string crime)
        {
            Name = name;
            Crime = crime;
        }
    }

    class Prison
    {
        private List<Prisoner> _prisoners = new List<Prisoner>();

        public void AddPrisoner(Prisoner prisoner)
        {
            _prisoners.Add(prisoner);
        }

        public void ShowInfo()
        {
            foreach (var prisoner in _prisoners)
            {
                Console.WriteLine($"Имя - {prisoner.Name}, национальность - {prisoner.Crime}");
            }
        }

        public void Amnesty()
        {
            var result = _prisoners.Where(i=> i.Crime != "Антипрививочник");
            foreach (var prisoner in result)
            {
                Console.WriteLine($"Имя - {prisoner.Name}, национальность - {prisoner.Crime}");
            }

        }
    }
}
