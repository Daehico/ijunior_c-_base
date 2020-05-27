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
            uint howManyCanIBuy = money / crystalcost;
            Console.WriteLine("Вы можете купить " + howManyCanIBuy + " кристалов. Сколько кристалов вы хотите купить?");
            uint userCrystalWantToBuy = Convert.ToUInt32(Console.ReadLine());
            canBuy = userCrystalWantToBuy <= howManyCanIBuy;
            uint canByToInt = Convert.ToUInt32(canBuy);
            uint userMoneyBack = money % userCrystalWantToBuy;
            userCrystalWantToBuy *= canByToInt;
            userMoneyBack = money;
            Console.WriteLine("Вы купили:" + userCrystalWantToBuy + " кристалов. У вас осталось " + userMoneyBack + " золота");
            Console.ReadKey();
        }
    }
}
