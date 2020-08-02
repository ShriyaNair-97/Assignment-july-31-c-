using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritance1
{
    class Game
    {
        public int noOfPalyers;
        public string country;
        int year;
        public Game()
        {

        }
        public Game(int _noOfPlayers, string _country)
        {
            noOfPalyers = _noOfPlayers;
            country = _country;
        }
        public int NoOfPlayers { get; set; }
        public string Country { get; set; }

        public void WorldCup(string country, string game)
        {
            Console.WriteLine("{0} have won the {1} WorldCup : {2}", country,game, year);
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    } 

    class Cricket : Game
    {
        public string coachName;

        public Cricket()
        {

        }
        public Cricket(int _noOfPlayers,string _country,string _coachName):base(_noOfPlayers
            ,_country)
        {
            coachName = _coachName;
        }
    }
    class Football : Game
    {
        public string leagueName;

        public Football()
        {

        }
        public Football(int _noOfPlayers, string _country, string _leagueName) : base(_noOfPlayers
            , _country)
        {
            leagueName = _leagueName;
        }
    }
    class ShowGameDetails
    {
        public void ShowCricketDetails(string country ,int noOfPlayers,string coachName)
        {
            Console.WriteLine("Country: {0} No of Players :{1} Coach :{2} ", country, noOfPlayers, coachName);
        }
        public void ShowFootballDetails(string country ,int noOfPlayers,string leagueName)
        {
            Console.WriteLine("Country: {0} No of Players :{1} leagueName :{2} ", country, noOfPlayers, leagueName);
        }
    }
    class Program
    {
        Cricket India = new Cricket();
        Cricket Australia = new Cricket();
        Football Spain = new Football();
        Football England = new Football();
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Year = 2011;
            game.WorldCup("India","Cricket");
            game.WorldCup("Spain","Football");


            ShowGameDetails d = new ShowGameDetails();
            Console.WriteLine("-----------------Cricket Information----------------------");
            d.ShowCricketDetails("India", 11, "Ravi Shastri");
            d.ShowCricketDetails("Australia", 11, "Micle Clark");

            Console.WriteLine("-----------------FootBall Information----------------------");
            d.ShowFootballDetails("England", 14, "English League");
            d.ShowFootballDetails("Spain", 13, "Spainish League");
            Console.WriteLine();


        }

    }
}
