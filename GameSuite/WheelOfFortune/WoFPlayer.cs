using System;
using System.Collections.Generic;
using System.Text;

namespace GameSuite
{
    class WoFPlayer : User
    {
        public WoFPlayer( string name ) : base( name )
        {
            playStrategy = new GuessText();
        }
    }
}
