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
            Hero hero = new Hero(100f);
            Traider traider = new Traider();
            traider.CreateTraiderItems();

            while (true)
            {
                Console.WriteLine("Добро пожаловать в магазин!");
                Console.WriteLine("Для покупки доступно:");
                traider.ShowItemsInShop();            
                Console.Write("Введите ID предмета которого хотите купить: ");
                int id = Convert.ToInt32(Console.ReadLine());
                traider.Traid(id, hero);            
                Console.WriteLine("В вашем ивентаре:  ");
                hero.ShowItemsinHero();
            }
        }
    }
}
class Hero
{
    private List<Item> _itemsInHero = new List<Item>();

    public float Gold { get; private set; }

    public Hero(float gold)
    {
        Gold = gold;
    }

    public void ShowItemsinHero()
    {
        int id = 0;
        foreach (var item in _itemsInHero)
        {
            Console.WriteLine($"Название предмета - {item.ItemName}");
            id++;
        }
    }

    public void BuyItem(Item item)
    {
        _itemsInHero.Add(item);
        Gold -= item.ItemCost;
    }
}
class Traider
{
    private List<Item> _itemsInShop = new List<Item>();
    private Item[] _items = { new Item("Sword", 20f), new Item("Axe", 30f), new Item("Shield", 40f) };
    
    
    public void CreateTraiderItems()
    {
        _itemsInShop.Add(_items[0]);
        _itemsInShop.Add(_items[1]);
        _itemsInShop.Add(_items[2]);
    }

    public void Traid(int id, Hero hero)
    {
        if (_items[id].ItemCost <= hero.Gold)
        {          
            _itemsInShop.RemoveAt(id);
            hero.BuyItem(_items[id]);           
        }
        else
        {
            Console.WriteLine("Нужно больше золота!");
        }
    }

    public void ShowItemsInShop()
    {
        int id = 0;
        foreach (var item in _itemsInShop)
        {
            Console.WriteLine($"id предмета - {id}. Название предмета - {item.ItemName}");
            id++;
        }
    }
}
class Item
{
    public string ItemName { get; private set; }
    public float ItemCost { get; private set; }

    public Item(string name, float gold)
    {
        ItemName = name;
        ItemCost = gold;
    }
}
