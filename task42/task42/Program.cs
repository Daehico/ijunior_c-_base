using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task42
{
    class Program
    {
        static void Main(string[] args)
        {
            Stew stew1 = new Stew("Говяжья", 2015, 2020);
            Stew stew2 = new Stew("Свинная", 2019, 2021);
            Stew stew3 = new Stew("Индейка", 2017, 2019);

            List<Stew> stews = new List<Stew>();
            stews.Add(stew1);
            stews.Add(stew2);
            stews.Add(stew3);

            stew1.SearchOverdueStew(stews, 2020);
            Console.ReadKey();
        }
    }

    class Stew
    {
        public string Name { get; private set; }
        public int ProductionYear { get; private set; }
        public int ExpirationDate { get; private set; }

        public Stew(string name, int productionYear, int expirationdate)
        {
            Name = name;
            ProductionYear = productionYear;
            ExpirationDate = expirationdate;
        }

        public void SearchOverdueStew(List<Stew> stews, int curentYear)
        {
            var overdueStew = stews.Where(i => i.ExpirationDate <= curentYear);
            foreach (var stew in overdueStew)
            {
                Console.WriteLine(stew.Name);
            }
        }
      
    }
}
