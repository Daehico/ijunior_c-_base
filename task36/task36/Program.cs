using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task36
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(100f);
            Client client2 = new Client(200f);
            Client client3 = new Client(500f);

            Product product1 = new Product(50f);
            Product product2 = new Product(100f);
            Product product3 = new Product(10f);
            Product product4 = new Product(25f);
            Product product5 = new Product(30f);

            client1.AddItemToProductList(product1);
            client1.AddItemToProductList(product2);
            client2.AddItemToProductList(product3);
            client2.AddItemToProductList(product4);
            client3.AddItemToProductList(product5);
            client3.AddItemToProductList(product1);

            Shop shop = new Shop();
            shop.AddClient(client1);
            shop.AddClient(client2);
            shop.AddClient(client3);
            while (shop.QueueCount != 0)
            {
                shop.Buy();
                Console.WriteLine($"Денег в магазине - {shop.Money}");

            }
            Console.ReadKey();
        }
    }

    class Client
    {
        public float Money { get; private set; }

        private List<Product> _products = new List<Product>();

        public float Sum { get; private set; }

        public Client(float money)
        {
            Money = money;
        }

        public void AddItemToProductList(Product product)
        {
            _products.Add(product);
        }

        public void GetSum()
        {
            foreach (var _product in _products)
            {
                Sum += _product.Cost;
            }
        }

        public void DeleteProduct(int id)
        {
            _products.RemoveAt(id);
            Sum = 0;
        }

        public void CheckClientMoney()
        {
            Random rand = new Random();
            GetSum();
            while (Sum > Money)
            {
                Console.WriteLine("У вас недостаточно денег. Мы удалим какой-нибудь товар из корзины");
                DeleteProduct(rand.Next(0, _products.Count));
                GetSum();
            }

        }
    }

    class Product
    {
        public float Cost { get; private set; }

        public Product(float cost)
        {
            Cost = cost;
        }
    }

    class Shop
    {
        private Queue<Client> _clients = new Queue<Client>();

        public float Money { get; private set; }
        public int QueueCount { get { return _clients.Count; }private set => value = _clients.Count; }

        public void AddClient(Client client)
        {
            _clients.Enqueue(client);
        }

        public void Buy()
        {
            _clients.Peek().CheckClientMoney();
            Console.WriteLine($"Денег к оплате {_clients.Peek().Sum}");
            ChangeMoney(_clients.Peek().Sum);
            _clients.Dequeue();
        }

        private void ChangeMoney(float money)
        {
            Money += money;
        }

    }
}
