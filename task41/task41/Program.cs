using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task41
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Sinab", 10, 50);
            Player player2 = new Player("Daehico", 50, 500);
            Player player3 = new Player("Admin", 60, 600);
            Player player4 = new Player("DarkProDemon_99RUS", 100, 1000);
            Player player5 = new Player("Dagaric", 70, 700);
            Player player6 = new Player("Player_1", 1, 10);
            Player player7 = new Player("Player_2", 15, 150);
            Player player8 = new Player("Player_3", 50, 500);
            Player player9 = new Player("Player_4", 70, 750);
            Player player10 = new Player("Player_5", 100, 100500);

            Server server = new Server();

            server.AddPlayer(player1);
            server.AddPlayer(player2);
            server.AddPlayer(player3);
            server.AddPlayer(player4);
            server.AddPlayer(player5);
            server.AddPlayer(player6);
            server.AddPlayer(player7);
            server.AddPlayer(player8);
            server.AddPlayer(player9);
            server.AddPlayer(player10);

            server.ShowTopByLevel();
            server.ShowTopByPower();
            Console.ReadKey();
        }
    }

    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }
    }

    class Server
    {
        private List<Player> _players = new List<Player>();

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void ShowTopByLevel()
        {
            var _result = _players.OrderByDescending(i => i.Level).Take(3);
            Console.WriteLine("Топ 3 игроков по уровню");
            ShowInfo(_result);
        }

        public void ShowTopByPower()
        {
            var _result = _players.OrderByDescending(i => i.Power).Take(3);
            Console.WriteLine("Топ 3 игроков по силе");
            ShowInfo(_result);
        }

        private void ShowInfo(IEnumerable<Player> _result)
        {
            foreach (var player in _result)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
