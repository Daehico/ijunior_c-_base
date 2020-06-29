using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            while (true)
            {
                Console.WriteLine("Добро пожаловать в зоопарк");
                Console.Write("Введите номер варьера который вы хотите посетить: ");
                int id = Convert.ToInt32(Console.ReadLine());
                zoo.ShowInfo(id);
            }
        }
    }
}

abstract class Animal
{
    public int Id { get; }
    public string Name { get; }
    public string Sound { get; }
    public string Sex { get; }

    public Animal(int id, string name, string sound, string sex)
    {
        Id = id;
        Name = name;
        Sound = sound;
        Sex = sex;
    }
}

class Dog : Animal
{
    public Dog(int id, string name, string sound, string sex)
        : base(id, name, sound, sex)
    {

    }
}

class Cat : Animal
{
    public Cat(int id, string name, string sound, string sex)
       : base(id, name, sound, sex)
    {

    }
}

class Elephant : Animal
{
    public Elephant(int id, string name, string sound, string sex)
       : base(id, name, sound, sex)
    {

    }
}

class Giraffe : Animal
{
    public Giraffe(int id, string name, string sound, string sex)
      : base(id, name, sound, sex)
    {

    }
}

class Aviary
{
    public int Id { get; }
    public int CountOfAnimal { get; }
    private List<Animal> _animals;

    public Aviary(int id, int count, List<Animal> animals)
    {
        Id = id;
        CountOfAnimal = count;
        this._animals = animals;
        this._animals = animals;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Вы подошли к варьеру номер - {Id}");
        foreach (var animal in _animals)
        {
            Console.WriteLine($"В варьере живут {animal.Name}. {animal.Sex} пола и издает следующий звук {animal.Sound}");
        }
    }
}

class Zoo
{
     private Aviary[] _aviarys = {new Aviary(0, 2, new List<Animal>
            {
              new Dog(0,"Волк", "Вой","женский"),
              new Elephant(0, "Слон","Трубит" ,"Мужской")
            }),
           new Aviary(1, 3, new List<Animal>

            {
                new Cat(3, "Лев", "рычит", "Мужской"),
                new Cat(4, "Рысь","Вау вау", "Женский"),
                new Cat(5,"Тигр", "рычит", "Мужской")
            }),
             new Aviary(2, 1, new List<Animal>
            {
                new Dog(6, "Собака", "Гавканье", "женский"),

            }),
            new Aviary(3, 2, new List<Animal>
            {
                 new Giraffe(7, "Жираф", "Какие то звуки", "Мужсой"),
                 new Cat(8, "Кошка", "Мяу", "женский")
            }
            )};

    public void ShowInfo(int id)
    {
        _aviarys[id].ShowInfo();
    }
}
