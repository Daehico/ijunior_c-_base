using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            float dollars;
            float rubles;
            float euro;

            float rubToUsd = 73f;
            float usdToRub = 0.7f;
            float euroToRub = 85f;
            float usdToEuro = 25f;

            float moneyToConvert;

            bool programWorkOrNot = true;

            Console.WriteLine("Добро пожаловать в конвертер валют. Нажмите 1, что бы сконвертировать рубли в доллары. Нажмите 2, что бы сконвертировать доллары в рубли." +
                " Нажмите 3, что бы сконвертировать евро в рубли. Нажмите 4, что бы сконвертировать доллары в евро. Нажмите выйти, что бы выйти из программы. ");
            Console.Write("Введите количество долларов на счете: ");
            dollars = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество рублей на счете: ");
            rubles = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество евро на счете: ");
            euro = Convert.ToSingle(Console.ReadLine());

            while (programWorkOrNot == true)
            {
                Console.Write("Введите команду:");
                command = Console.ReadLine();               

                switch (command)
                {
                    case "1":
                        Console.WriteLine("Вы хотите сконвертировать рубли в доллары.");
                        Console.Write("Введите количество рублей для конвертации. Доступно " + rubles);
                        moneyToConvert = Convert.ToSingle(Console.ReadLine());
                        if (moneyToConvert > rubles)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            dollars = moneyToConvert * rubToUsd;
                            Console.WriteLine("Теперь у вас: " + dollars + " долларов");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Вы хотите сконвертировать доллары в рубли.");
                        Console.Write("Введите количество долларов для конвертации. Доступно " + dollars);
                        moneyToConvert = Convert.ToSingle(Console.ReadLine());
                        if (moneyToConvert > dollars)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            rubles = moneyToConvert * usdToRub;
                            Console.WriteLine("Теперь у вас: " + rubles + " рублей");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Вы хотите сконвертировать евро в рубли.");
                        Console.Write("Введите количество евро для конвертации. Доступно " + euro);
                        moneyToConvert = Convert.ToSingle(Console.ReadLine());
                        if (moneyToConvert > euro)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            rubles = moneyToConvert * euroToRub;
                            Console.WriteLine("Теперь у вас: " + rubles + " рублей");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Вы хотите сконвертировать доллары в евро.");
                        Console.Write("Введите количество доллары для конвертации. Доступно " + dollars);
                        moneyToConvert = Convert.ToSingle(Console.ReadLine());
                        if (moneyToConvert > dollars)
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        else
                        {
                            euro = moneyToConvert * usdToEuro ;
                            Console.WriteLine("Теперь у вас: " + euro + " евро");
                        }
                        break;

                    case "выйти":
                        programWorkOrNot = false;
                        break;
                }
            }
        }
    }
}
