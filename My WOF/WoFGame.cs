using System;
using System.Collections.Generic;
using System.Text;

namespace My_WOF
{
    class WoFGame : Game
    {
        private readonly string gameName = "wof";
        private readonly int maxPlayers = 3;
        private WoFBoard board;

        public WoFGame()
        {
            createUsers(maxPlayers);
            startGame();
        }

        protected override void startGame()
        {
            board = (WoFBoard) gameBoardFactory.CreateGameBoard(gameName);
            while ( !gameOver )
            {
                User currentUser = userList.Dequeue();
                facilitatePlayerGuessOnBoard( currentUser );
                userList.Enqueue( currentUser );
                if( gameOver )
                {
                    Console.WriteLine("Congratulations " + currentUser.name + " You Win!!!!");
                    Console.WriteLine("Play again? y/n");
                    string restart = Console.ReadLine().ToLower();
                    if( restart[0] == 'y' )
                    {
                        board = (WoFBoard) gameBoardFactory.CreateGameBoard(gameName);
                        gameOver = false;
                    }
                }
            }
            
        }

        private void facilitatePlayerGuessOnBoard( User currentUser )
        {
            do {
                Move currentPlay = currentUser.Play();
                board.acceptMove(currentPlay);
            } while (board.goAgain());

            gameOver = board.isSolved();
        }
    }
}
