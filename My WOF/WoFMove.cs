using System;
using System.Collections.Generic;
using System.Text;

namespace My_WOF
{
    class WoFMove : Move
    {
        public string guess { get; }
        public WoFMove( string guess )
        {
            this.guess = guess;
        }
    }
}
