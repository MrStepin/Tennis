using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Player

    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        int value { get; set; }

        public int WonServe(int value)
        {
            return value += value;
            
        }

        public int WonSets(int value)
        {
            return value += 1;
        }

        public int WonGames(int value)
        {
            return value += 1;
        }
    }
}
