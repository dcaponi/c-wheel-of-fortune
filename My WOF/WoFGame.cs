using System;
using System.Collections.Generic;
using System.Text;

namespace My_WOF
{
    class WoFGame
    {
        private WoFBoard board;
        private Queue<User> userList = new Queue<User>();
        private GameBoardFactory gameBoardFactory;
        private bool gameOver = false;

        public WoFGame()
        {
            createUsers();
            gameBoardFactory = new GameBoardFactory();
            //Todo more options for games here...
            startGame();
        }

        private void startGame()
        {
            board = (WoFBoard) gameBoardFactory.createGameBoard("wof");
            while ( !gameOver )
            {
                User currentUser = userList.Dequeue();
                facilitatePlayerGuessOnBoard( currentUser );
                userList.Enqueue(currentUser);
                if( gameOver )
                {
                    Console.WriteLine("Congratulations " + currentUser.name + " You Win!!!!");
                    Console.WriteLine("Play again? y/n");
                    string restart = Console.ReadLine().ToLower();
                    if( restart[0] == 'y' )
                    {
                        board = gameBoardFactory.createGameBoard("wof") as WoFBoard;
                        gameOver = false;
                    }
                }
            }
            
        }

        private void facilitatePlayerGuessOnBoard( User currentUser )
        {
            
            do
            {
                Move currentPlay = currentUser.Play();
                board.acceptMove(currentPlay);
            } while (board.goAgain());

            gameOver = board.isSolved();
        }

        private void createUsers()
        {
            Console.WriteLine("How Many Users ( Enter 1, 2, or 3 ): ");
            int users = 0;
            bool userCountValid = false;
            while (!userCountValid)
            {
                string usersInput = Console.ReadLine();
                userCountValid = Int32.TryParse(usersInput, out users) && users > 0 && users < 4;
                if (!userCountValid)
                {
                    Console.WriteLine("Enter a number ( 1, 2, or 3 )");
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < users; i++)
            {
                Console.WriteLine("Enter name for player " + (i + 1));
                string name = Console.ReadLine();
                User user = new WoFPlayer(name);
                userList.Enqueue(user);
            }
        }
    }
}
