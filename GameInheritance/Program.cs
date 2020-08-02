using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritance
{
    class Game
    {
        int noOfPlayers;
        string country;

        public  int NoOfPlayers { get; set; }
        public  string Country { get; set; }

        public Game()
        {

        }
        public Game(int _noOfPlayers,string _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
        }
        public void WorldCup()
        {
            Console.WriteLine("World Cup"+DateTime.Now);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(11,"India");
            game.WorldCup();
        }
    }
}
