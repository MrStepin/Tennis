using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Player2 : Player
    {
        Random randomNumber = new Random();

        int value { get; set; }

        public override int WonServes(int value)
        {
            return value += 1;
        }

        public override int WonSets(int value)
        {
            return value += 1;
        }

        public override int WonGames(int value)
        {
            return value += 1;
        }

        public int Serve()
        {
            int serve = randomNumber.Next(0, 6);
            return serve;
        }
    }
}
