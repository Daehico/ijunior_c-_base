using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canBuy; 
            Console.Write("Введите количество монет:");
            uint money = Convert.ToUInt32(Console.ReadLine());
            uint crystalcost = 5;
            uint howManyCanBuy = money / crystalcost;
            Console.WriteLine("Вы можете купить " + howManyCanBuy + " кристалов. Сколько кристалов вы хотите купить?");
            uint userCrystalWantToBuy = Convert.ToUInt32(Console.ReadLine());
            canBuy = userCrystalWantToBuy <= howManyCanBuy;
            uint canByToInt = Convert.ToUInt32(canBuy);
            money = money % userCrystalWantToBuy;
            userCrystalWantToBuy *= canByToInt;           
            Console.WriteLine("Вы купили:" + userCrystalWantToBuy + " кристалов. У вас осталось " + money + " золота");
            Console.ReadKey();
        }
    }
}
