﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameSuite
{
    class GameBoardFactory
    {
        public GameBoardFactory() { }
        public IBoard CreateGameBoard( string boardOption )
        {
            if( boardOption == "wof" )
            {
                return new WoFBoard();
            }
            return null;
        }
    }
}
