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
            traider.TheFormationOfFirstTraidList();

            while (true)
            {
                Console.WriteLine("Добро пожаловать в магазин!");
                Console.WriteLine("Для покупки доступно:");
                int id = 0;
                foreach (var item in traider.ItemsInShop)
                {
                    Console.WriteLine($"id предмета - {id}. Название предмета - {item.ItemName}");
                    id++;
                }
                Console.Write("Введите ID предмета которого хотите купить: ");
                id = Convert.ToInt32(Console.ReadLine());
                traider.Traid(hero.ItemsInHero, id, hero);
                Console.WriteLine("В вашем ивентаре:  ");
                foreach (var item in hero.ItemsInHero)
                {
                    Console.WriteLine($"Название предмета - {item.ItemName}");
                    id++;
                }                
            }
        }
    }
}
class Hero
{
    private List<Item> _itemsInHero = new List<Item>();
    private float _heroGold;
    public Hero(float gold)
    {
        HeroGold = gold;
    }
    public List<Item> ItemsInHero { get => _itemsInHero; private set => _itemsInHero = value; }

    public float HeroGold{ get => _heroGold; private set => _heroGold = value; }

    public void ChangeGold(float gold)
    {
        _heroGold -= gold;
    }
}
class Traider
{
    private List<Item> _itemsInShop = new List<Item>();
    private Item[] _items = { new Item("Sword", 20f), new Item("Axe", 30f), new Item("Shield", 40f) };
    public List<Item> ItemsInShop { get => _itemsInShop; private set => _itemsInShop = value; }
    public void TheFormationOfFirstTraidList()
    {
        ItemsInShop.Add(_items[0]);
        ItemsInShop.Add(_items[1]);
        ItemsInShop.Add(_items[2]);
    }

    public void Traid(List<Item> heroItem, int id, Hero hero)
    {
        if (_items[id].ItemCost <= hero.HeroGold)
        {
            heroItem.Add(_items[id]);
            _itemsInShop.RemoveAt(id);
            hero.ChangeGold(_items[id].ItemCost);
        }
        else
        {
            Console.WriteLine("Нужно больше золота!");
        }
    }
}
class Item
{
    private string _itemName;
    private float _itemCost;

    public string ItemName { get => _itemName; private set => _itemName = value; }
    public float ItemCost { get => _itemCost; private set => _itemCost = value; }

    public Item(string name, float gold)
    {
        ItemName = name;
        ItemCost = gold;
    }
}
