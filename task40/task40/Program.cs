using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task40
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Евгений", 20, "Астма");
            Patient patient2 = new Patient("Максим", 30, "Астма");
            Patient patient3 = new Patient("Юрий", 60, "Инфаркт");
            Patient patient4 = new Patient("Юлия", 18, "Диабет");
            Patient patient5 = new Patient("Стражник", 47, "Стрела в колене");
            Patient patient6 = new Patient("Татьяна", 14, "Перелом");
            Patient patient7 = new Patient("Никита", 36, "Диабет");
            Patient patient8 = new Patient("Максим", 29, "Инфаркт");
            Patient patient9 = new Patient("Александр", 88, "Инсульт");
            Patient patient10 = new Patient("Алексей", 66, "Диабет");

            Hospital hospital = new Hospital();
            hospital.AddPatient(patient1);
            hospital.AddPatient(patient2);
            hospital.AddPatient(patient3);
            hospital.AddPatient(patient4);
            hospital.AddPatient(patient5);
            hospital.AddPatient(patient6);
            hospital.AddPatient(patient7);
            hospital.AddPatient(patient8);
            hospital.AddPatient(patient9);
            hospital.AddPatient(patient10);

            Console.WriteLine("Добро пожаловать в госпиталь. Введите 1- отсортировать больных по имени, 2- отсортировать больных по возврасту" +
                "3 - вывести всех больных с данным диагнозом. ");
            while (true)
            {
                Console.Write("Введите комманду: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        hospital.OrderByName();
                        break;
                    case "2":
                        hospital.OrderByAge();
                        break;
                    case "3":
                        Console.Write("Введите название диагноза: ");
                        string name = Console.ReadLine();
                        hospital.OrderByDiagnosis(name);
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }
    }

    class Patient
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Diagnosis { get; private set; }

        public Patient(string name, int age, string diagnosis)
        {
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }
    }

    class Hospital
    {
        private List<Patient> _patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
        }

        public void OrderByName()
        {
            var _result = _patients.OrderBy(i => i.Name).ToList();
            Console.WriteLine("Результат сортировки по имени");
            ShowInfo(_result);
        }

        public void OrderByAge()
        {
            var _result = _patients.OrderBy(i => i.Age).ToList();
            Console.WriteLine("Результат сортировки по возрасту");
            ShowInfo(_result);
        }

        public void OrderByDiagnosis(string diagnosis)
        {
            var _result = _patients.Where(i => i.Diagnosis == diagnosis).ToList();
            Console.WriteLine($"Все пациенты с диагнозом -{diagnosis} ");
            ShowInfo(_result);
        }

        private void ShowInfo(List<Patient> patients) 
        {
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}
