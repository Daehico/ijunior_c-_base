using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int userHealth = 200;
            int bossHealth = 200;

            bool RahamonIsTrue = false;
            bool huganzakuraIsTrue = false;

            string command = "".ToLower();

            Console.WriteLine("Добро пожаловать! Вы, теневой маг. Ваша задача убить босса, используя 4 разных заклинания. \r\n" +
                "Для ознакомления со списком заклинаний наберите команду Список команд. Учтите, что за \r\nкаждое использованное заклинание вы будите получать урон. " +
                "Игра закончится, когда кто нибудь умрет.\r\nНадеюсь это будет босс ;) Удачи! ");

            while (userHealth > 0 && bossHealth > 0)
            {
                Console.Write("Введите команду:");
                command = Console.ReadLine();
                if (command == "рашамон")
                {
                    bossHealth -= 10;
                    userHealth -= 15;
                    Console.WriteLine("Вы нанесли 10 урона и получили 15 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    RahamonIsTrue = true;
                }
                else if (command == "хуганзакура")
                {
                    if (RahamonIsTrue == false)
                    {
                        userHealth -= 50;
                        Console.WriteLine("Для начала нужно было призвать теневого духа! (Команда Рашамон). Ваше заклинание не нанесло урона! " +
                            "Вы получили 50 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    }
                    else
                    {
                        bossHealth -= 20;
                        userHealth -= 20;
                        Console.WriteLine(" Ваше заклинание нанесло 20 урона. Вы получили 20 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                        RahamonIsTrue = false;
                        huganzakuraIsTrue = true;
                    }
                }

                else if (command == "межпространственный разлом")
                {
                    userHealth += 5;
                    Console.WriteLine("Вы спрятались в межпростравенном разломе и не получили урона. Также вы восстановили 5 единиц здоровья. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                }
                else if (command == "комбушечка")
                {
                    if (huganzakuraIsTrue == false)
                    {
                        userHealth -= 100;
                        Console.WriteLine("Для начала нужно было использовать хуганзакуру! (Команда Хуганзакура). Ваше заклинание не нанесло урона! " +
                            "Вы получили 100 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    }
                    else
                    {
                        bossHealth -= 40;
                        userHealth -= 15;
                        Console.WriteLine(" Ваше заклинание нанесло 40 урона. Вы получили   15 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                        huganzakuraIsTrue = false;
                    }
                }

                else if (command == "список команд")
                {
                    Console.WriteLine("Заклинание Рашамон. Наносит 10 урона, вы получаете 15 урона. \r\n" +
                        "Заклинание Хуганзакура. Возможно только после использования заклинания Рашамон. Если вы все сделаете правильно, \r\nто босс получит 20 урона, а вы получите 20 урона. \r\n" +
                        "Заклинание Комбушечка (Да, у автора плохо с фантазией) возможно только после применения заклинания Хуганзакура. \r\nЕсли вы выполните условия применения заклинания босс получит 40 урон," +
                        " а вы получите 15 урона. \r\n" +
                        "Заклинание Межпространственный разлом. Данное заклинание не наносит урон, но спасает вас от атак босс \r\n(то есть вы не получите урон). Также данное заклинание восстановит вам 5 единиц здоровья.");
                }

                else
                {
                    Console.WriteLine("Заклинание не опознано. Попробуйте еще раз");
                }

            }

            if (userHealth <= 0)
            {
                Console.WriteLine("Вы погибли!");
            }
            else
            {
                Console.WriteLine("Вы победили! Поздравляю!");
            }
            Console.WriteLine("Спасибо, что поиграли в эту игру! Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
   