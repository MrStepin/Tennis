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

            Console.WriteLine("Winner of the first set is:");
            Console.WriteLine(match.Set());
            Console.WriteLine("Winner of the second set is:");
            Console.WriteLine(match.Set());
            Console.ReadKey();
        }
    }
}
