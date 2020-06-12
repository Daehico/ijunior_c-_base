using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = { new Item("Sword"), new Item("Axe"), new Item("Shield") };
            Hero hero = new Hero();
            Traider traider = new Traider();
            traider.itemsInShop.Add(items[0]);
            traider.itemsInShop.Add(items[1]);
            traider.itemsInShop.Add(items[2]);
            while (true)
            {
                Console.WriteLine("Добро пожаловать в магазин!");
                Console.WriteLine("Для покупки доступно:");
                int id = 0;
                foreach (var item in traider.itemsInShop)
                {
                    Console.WriteLine($"id предмета - {id}. Название предмета - {item.ItemName}");
                    id++;
                }
                Console.Write("Введите ID предмета которого хотите купить: ");
                id = Convert.ToInt32(Console.ReadLine());
                traider.Traid(hero.itemsInHero, id, items);
                Console.WriteLine("В вашем ивентаре:  ");
                foreach (var item in hero.itemsInHero)
                {
                    Console.WriteLine($"Название предмета - {item.ItemName}");
                    id++;
                }
                Console.ReadKey();
                
            }
        }
    }
}
class Hero
{
    public List<Item> itemsInHero = new List<Item>();
}
class Traider
{
    public List<Item> itemsInShop = new List<Item>();
    public void Traid(List<Item> hero, int id, Item[] items)
    {
        hero.Add(items[id]);
        itemsInShop.RemoveAt(id);
    }
}
class Item
{
    private string _itemName;

    public string ItemName { get => _itemName; private set => _itemName = value; }

    public Item(string name)
    {
        ItemName = name;
    }
}
