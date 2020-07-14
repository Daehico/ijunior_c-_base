using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task35
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dossier = new Dictionary<string, string>();
            Console.Write("Введите команду: ");
            string comand = Console.ReadLine().ToLower();

            while (comand != "выход")
            {
                if (comand == "добавить досье")
                {
                    Console.Write("Введите ФИО: ");
                    string name = Console.ReadLine();
                   
                    Console.Write("Введите должность: ");
                    string position = Console.ReadLine();

                  AddDossier(name,position, dossier);
                }
                else if (comand == "вывести все досье")
                {
                    ShowAllDossier(dossier);
                }
                else if (comand == "удалить досье")
                {
                    Console.Write("Введите имя сотрудника досье которого вы хотите удалить:");
                    string name = Console.ReadLine();
                    DeleteDossier(dossier, name);
                }
               
                else
                {
                    Console.WriteLine("Данной команы не существует");
                }
                Console.Write("Введите команду: ");
                comand = Console.ReadLine();
            }
        }

        static void AddDossier(string name, string position, Dictionary<string,string> dossier)
        {
            dossier.Add(name, position);
           
        }

        static void ShowAllDossier(Dictionary<string, string> dossiers)
        {

            foreach (var dosier in dossiers)
            {
                Console.WriteLine($"Имя - {dosier.Key}. Должность - {dosier.Value}");
            }
        }

        static void DeleteDossier(Dictionary <string, string> dosiers, string name)
        {
            dosiers.Remove(name);
        }
      
    }
}
