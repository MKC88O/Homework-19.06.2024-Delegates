using System.Xml.Serialization;

namespace Homework_19._06._2024_Delegates
{
    class Game
    {
        public static void NewGame()
        {
            Console.WriteLine("New Game Started...");
        }

        public static void LoadGame()
        {
            Console.WriteLine("Game is Loading...");
        }

        public static void Rules()
        {
            Console.WriteLine("1 Rules...");
            Console.WriteLine("2 Rules...");
            Console.WriteLine("3 Rules...");
            Console.WriteLine("4 Rules...");
            Console.WriteLine("5 Rules...");
        }

        public static void AboutTheAuthor()
        {
            Console.WriteLine("Author: ...");
        }

        public static void ExitGame()
        {
            Console.WriteLine("Exit the game...");
        }

        public static void Choice()
        {
            Console.WriteLine("Enter number from 0 to 4 : ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Rules");
            Console.WriteLine("4 - About the author");
            Console.WriteLine("0 - Exit");
        }
    }

    delegate void GameMenu();

    internal class Program
    {
        static void Main(string[] args)
        {
            //Game game = new ();
            GameMenu[] GM =
            {
                Game.ExitGame,
                Game.NewGame,
                Game.LoadGame,
                Game.Rules,
                Game.AboutTheAuthor
            };

            while (true)
            {
                Game.Choice();

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 0 && choice <= 4)
                {
                    GM[choice]();
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR! Invalid choice! Please enter number from 0 to 4: ");
                }
            }
        }
    }
}
