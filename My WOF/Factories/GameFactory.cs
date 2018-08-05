﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameSuite
{
    class GameFactory
    {
        public GameFactory() { }
        public Game CreateGame( int option )
        {
            if( option == 1)
            {
                return new WoFGame();
            }
            return null;
        }
    }
}
