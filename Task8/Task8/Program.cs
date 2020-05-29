using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programWorkOrNor = true;

            string command;

            string username = null;
            string password = null;
            string userInputPassword;
            int counts = 5;
            string color;

            Console.WriteLine("Добро пожаловать в программу! Доступный следующие комманды: Ввести имя пользователя.Задать пароль. Ввести пароль." +
                "  Ввывести имя. Изменить пароль. Изменить имя. Очистить консоль. Поменять цвет консоли. Выйти");

            while (programWorkOrNor == true)
            {
                Console.Write("Введите команду: ");
                command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "ввести имя пользователя":
                        Console.Write("Введите ваше имя: ");
                        username = Console.ReadLine();
                        Console.WriteLine("Имя задано!");
                        break;

                    case "задать пароль":
                        Console.Write("Введите ваш пароль: ");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль задан!");
                        break;

                    case "ввести пароль":
                        Console.Write("Введите ваш пароль. У вас пять попыток: ");

                        for (int i = 0; i < counts; i++)
                        {
                            userInputPassword = Console.ReadLine();
                            if (userInputPassword == password)
                            {
                                Console.WriteLine("Пароль верен!");
                                break;
                            }
                            else if (password == null)
                            {
                                Console.WriteLine("Пароль не задан");
                            }
                            else
                            {
                                Console.WriteLine("Пароль не верен. У вас осталось " + counts + " попыток");
                            }
                        }
                        break;

                    case "вывести имя":
                        if (username != null)
                        {
                            Console.WriteLine("Ваше имя - " + username);
                        }
                        else
                        {
                            Console.WriteLine("Имя не задано");
                            
                        }
                        break;

                    case "изменить пароль":
                        if (password != null)
                        {
                            Console.WriteLine("Для начала введите свой старый пароль, что бы мы могли убедится, что это вы: ");

                            for (int i = 0; i < counts; i++)
                            {
                                userInputPassword = Console.ReadLine();
                                if (userInputPassword == password)
                                {
                                    Console.WriteLine("Пароль верен!");
                                    Console.Write("Введите новый пароль:");
                                    password = Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Пароль не верен. У вас осталось " + counts + " попыток");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Пароль не задан. Воспользуйтесь командой задать пароль");
                        }
                                                  
                        break;

                    case "изменить имя":
                        if (password != null)
                        {
                            Console.WriteLine("Для начала введите свой пароль, что бы мы могли убедится, что это вы: ");

                            for (int i = 0; i < counts; i++)
                            {
                                userInputPassword = Console.ReadLine();
                                if (userInputPassword == password)
                                {
                                    Console.WriteLine("Пароль верен!");
                                    Console.Write("Введите новое имя:");
                                    username= Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Пароль не верен. У вас осталось " + counts + " попыток");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Имя не задано. Воспользуйте командой ввести имя пользователя");
                        }

                        break;

                    case "очистить консоль":
                        Console.Clear();
                        break;

                    case "поменять цвет консоли":
                        Console.WriteLine("Доступный следующие цвета: черный, синий, зеленный");
                        Console.Write("Введите название цвета");
                        color = Console.ReadLine();
                        if(color.ToLower() == "черный")
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("Цвет консоли теперь черный!");
                        }
                        else if(color.ToLower()  == "синий")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Цвет консоли теперь синий!");
                        }
                        else if (color.ToLower() == "зеленый")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Цвет консоли теперь зеленный!");
                        }
                        else
                        {
                            Console.WriteLine("Я не знаю такого цвета");
                        }
                        break;

                    case "выйити":
                        programWorkOrNor = false;
                        break;
                }
            }
        }
    }
}