using System;
using System.Collections.Generic;
using System.Text;

namespace GameSuite
{
    interface IBoard
    {
        void acceptMove(Move move);
        bool isSolved();
    }
}
