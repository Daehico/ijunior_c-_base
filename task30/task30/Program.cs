using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Details[] details = { new Details(0, "колесо", 100f), new Details(1, "руль", 150f), new Details(2, "Двигатель", 500f) };
            Warehouse warehouse = new Warehouse();
            warehouse.AddDetail(details[0]);
            warehouse.AddDetail(details[1]);
            warehouse.AddDetail(details[2]);
            AutoRepairShop autoRepairShop = new AutoRepairShop(1000f, 100f,200f);           
            bool notBankrot = true;
            bool haveDetail;
            while (notBankrot != false)
            {
                int index = random.Next(0, details.Length);
                Car car = new Car(details[index]);
                car.ShowInfo();
                haveDetail = warehouse.CheckDetail(index);
                if(haveDetail == true)
                {
                    autoRepairShop.Repair(details[index]);
                    warehouse.RemoveDetail(index);
                }
                else
                {
                    autoRepairShop.PayForfeit();
                }
                Console.WriteLine($"Ваш баланс: {autoRepairShop.Balance}");
                notBankrot = autoRepairShop.CheckBalance();
                int indexOfNewDetail = random.Next(0, details.Length);
                warehouse.AddDetail(details[indexOfNewDetail]);
                Console.ReadKey();
            }
            Console.WriteLine("Вы банкрот! Вы проиграли");
        }
    }

    class Details
    {
        public int Id { get; private set; }
        public float Cost { get; private set; }
        public string Name { get; private set; }

        public Details(int id,string name, float cost)
        {
            Id = id;
            Cost = cost;
            Name = name;
        }
    }

    class Warehouse
    {
        private List<Details> _details = new List<Details>();
        private AutoRepairShop repairShop = new AutoRepairShop();


        public void AddDetail(Details detail)
        {
            _details.Add(detail);
        }

        public bool CheckDetail(int id)
        {
            foreach (var detail in _details)
            {
                if(detail == _details[id])
                {
                    Console.WriteLine($"Деталь найдена. Стоимость детали - {detail.Cost}");

                    return true;
                }
                else
                {
                    Console.WriteLine("Детали нет. Клиент недоволен!");
                    return false;
                }
            }
            return false;
        }

        public void RemoveDetail(int id)
        {
            _details.RemoveAt(id);
        }
    }

    class AutoRepairShop
    {
        public float Balance { get; private set; }
        public float RepairCost { get; private set; }
        public float Forfeit { get; private set; }

        public AutoRepairShop(float money, float cost, float forfeit)
        {
            Balance = money;
            RepairCost = cost;
            Forfeit = forfeit;
        }

        public AutoRepairShop()
        {

        }

        public void Repair(Details detail)
        {
            Balance += (detail.Cost + RepairCost);
            Console.WriteLine("Машина отремонтирована");
        }

        public void PayForfeit()
        {
            Console.WriteLine($"Вы платите штраф в размере - {Forfeit}");
            Balance -= Forfeit;
        }

        public bool CheckBalance()
        {
            return Balance > 0;
        }
    }

    class Car
    {
        public Details BrokenDetail { get; private set; }

        public Car(Details detail)
        {
            BrokenDetail = detail;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"К вам приехала машина со следующей поломкой - {BrokenDetail.Name}");
        }
    }
}
