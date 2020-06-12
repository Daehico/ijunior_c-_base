using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] fioArray = new string[0];
            string[] positionArray = new string[0];
            Console.Write("Введите команду: ");
            string comand = Console.ReadLine().ToLower();

            while (comand != "выход")
            {
                if (comand == "добавить досье")
                {
                    Console.Write("Введите ФИО: ");
                    string name = Console.ReadLine();
                    fioArray = AddDossier(fioArray, name);

                    Console.Write("Введите должность: ");
                    string position = Console.ReadLine();

                    positionArray = AddDossier(positionArray, position);
                }
                else if (comand == "вывести все досье")
                {
                    ShowAllDossier(fioArray, positionArray);
                }
                else if (comand == "удалить досье")
                {
                    fioArray = DeleteDossier(fioArray);
                    positionArray = DeleteDossier(fioArray);
                }
                else if (comand == "поиск")
                {
                    Search(fioArray, positionArray);
                }
                else
                {
                    Console.WriteLine("Данной команы не существует");
                }
                Console.Write("Введите команду: ");
                comand = Console.ReadLine();
            }
        }

        static string[] AddDossier(string[] addArray, string name)
        {

            if (addArray == null)
            {
                addArray = new string[1];
            }
            string[] fioArrayCopy;

            Array.Copy(addArray, fioArrayCopy = new string[addArray.Length], addArray.Length);

            Array.Resize(ref addArray, addArray.Length + 1);

            for (int i = 0; i < fioArrayCopy.Length; i++)
            {
                addArray[i] = fioArrayCopy[i];

            }
            addArray[addArray.Length - 1] = name;

            return addArray;
        }

        static void ShowAllDossier(string[] fioArray, string[] positionArray)
        {

            for (int i = 0; i < fioArray.Length; i++)
            {
                if (fioArray[i] == null || positionArray[i] == null)
                    continue;
                else
                    Console.WriteLine("{0}) ФИО - {1}; Должность - {2} ", i, fioArray[i], positionArray[i]);
            }
        }

        static string[] DeleteDossier(string[] fioArray)
        {
            Console.Write("Введите ID сотрудника досье которого вы хотите удалить. Для того что бы узнать ID сотруддника ввыведите список сотрудников через команду вывести все досье: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id < fioArray.Length)
            {
                Array.Clear(fioArray, id, fioArray.Length);
                return fioArray;
            }
            else
            {
                Console.WriteLine("Такого ID - нет. Попробуйте еще раз");

            }

            return fioArray;
        }
        static void Search(string[] array, string[] position)
        {

            Console.Write("Введите ФИО сотрудника:");
            string text = Console.ReadLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == text)
                {
                    Console.WriteLine("{0} - ID сотрудника которого вы искали; {1} - должность сотрудника которого вы искали", i, position[i]);
                }
                else
                {
                    Console.WriteLine("Такого досье нет");
                }
            }
        }
    }
}
