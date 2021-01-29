using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    abstract class Player
    {
        public abstract int WonServes(int value);

        public abstract int WonSets(int value);

        public abstract int WonGames(int value);
    }
}
