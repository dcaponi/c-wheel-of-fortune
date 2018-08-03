using System;
using System.Collections.Generic;
using System.Text;
using My_WOF.PlayStrategies;

namespace My_WOF
{
    class WoFPlayer : User
    {
        public WoFPlayer( string name ) : base( name )
        {
            playStrategy = new GuessText();
        }
    }
}
