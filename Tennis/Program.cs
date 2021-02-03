using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();

            List<string> winners = new List<string>() { };

            string winnerOfTheFirstSet = match.Set();

            Console.WriteLine("Winner of the first set is:");
            Console.WriteLine(winnerOfTheFirstSet);

            winners.Add(winnerOfTheFirstSet);

            string winnerOfTheSecondSet = match.Set();

            Console.WriteLine("Winner of the second set is:");
            Console.WriteLine(winnerOfTheSecondSet);

            winners.Add(winnerOfTheSecondSet);

            if (winners[0] == winners[1])
            {
                Console.WriteLine("Winner of the match is:");
                Console.WriteLine(winners[0]);

            }
            else
            {
                string winnerOfTheThirdSet = match.Set();

                Console.WriteLine("Winner of the third set is:");
                Console.WriteLine(winnerOfTheThirdSet);

                winners.Add(winnerOfTheThirdSet);
                if (winners[0] == winners[2])
                {
                    Console.WriteLine("Winner of the match is:");
                    Console.WriteLine(winners[0]);
                }
                else
                {
                    Console.WriteLine("Winner of the match is:");
                    Console.WriteLine(winners[1]);
                }
            }

            Console.ReadKey();
        }
    }
}
