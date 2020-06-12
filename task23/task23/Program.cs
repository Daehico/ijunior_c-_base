using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(5, 10);
            Renderer renderer = new Renderer();
            renderer.DrawHero(hero.X, hero.Y);
            Console.ReadKey();
        }
    }

    class Hero
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Hero(int x, int y)
        {
            X = x;
            Y = y;
        }

    }

    class Renderer
    {
        public void DrawHero(int x, int y, char symbol = 'Y')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);

        }
    }
}
