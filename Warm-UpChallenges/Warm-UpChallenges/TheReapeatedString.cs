using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_UpChallenges
{
    public class TheReapeatedString
    {
        public static long repeatedString(string s, long n)
        {
            long numbersOfA = s.Split('a').Length - 1;
            long times = (n - (n % s.Length)) / s.Length;
            
            long remainder = n % s.Length;
             numbersOfA = numbersOfA * times;
            for (int i = 0; i < remainder;i++ )
            {
                if (s[i] == 'a') numbersOfA++;
            }
                         
            return numbersOfA;
        }

    }
}
