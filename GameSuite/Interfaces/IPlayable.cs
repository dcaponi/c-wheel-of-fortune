using System;
using System.Collections.Generic;
using System.Text;

namespace GameSuite
{
    interface IPlayable
    {
        Move Play(User user);
    }
}
