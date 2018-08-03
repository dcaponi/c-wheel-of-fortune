using System;
using System.Collections.Generic;
using System.Text;

namespace My_WOF
{
    interface IBoard
    {
        void acceptMove(Move move);
        bool isSolved();
    }
}
