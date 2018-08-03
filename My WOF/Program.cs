using System;
using My_WOF.Factories;

namespace My_WOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wheel o' Fourtune!");
            GameFactory gameFactory = new GameFactory();
            Console.WriteLine("Which game would you like to play? ");
            Console.WriteLine("Wheel of Fortune (1)");
            bool validOption = false;
            int option = -1;
            while (!validOption)
            {
                string optionInput = Console.ReadLine();
                validOption = Int32.TryParse(optionInput, out option) && option > 0 && option < 2;
                if (!validOption)
                {
                    Console.WriteLine("Enter a number ( 1 )");
                }
            }
            Game game = gameFactory.CreateGame(option);
        }
    }
}
