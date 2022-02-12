using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_UpChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            long n = 10;
            long reapedA = TheReapeatedString.repeatedString(s, n);
            Console.WriteLine(reapedA);
            //Console.WriteLine(String.Concat(Enumerable.Repeat("text", 2)));
            Console.ReadKey();
        }
    }
}
