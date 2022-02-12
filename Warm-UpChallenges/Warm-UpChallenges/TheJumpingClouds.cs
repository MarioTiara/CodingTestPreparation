using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_UpChallenges
{
    public class TheJumpingClouds
    {
        /*
   * Complete the 'jumpingOnClouds' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts INTEGER_ARRAY c as parameter.
   */

        public static int jumpingOnClouds(List<int> c)
        {
            List<int> path = new List<int>();
           
            int n = 0;
            if (c.Count <= 2 && c[n + 1] == 0) return 1;
          
            while(n<c.Count-2)
            {
                if (c[n + 2] == 0)
                {
                   // Console.WriteLine(c[n + 2]);
                    path.Add(c[n + 2]);
                    n += 2;
                }
                else if (c[n + 2] == 1)
                {
                   // Console.WriteLine(c[n + 1]);
                    path.Add(c[n + 1]);
                    n += 1;
                }

                if (n == 0 && c[n + 1] == 1) path.Add(c[n + 2]);
                if (n == c.Count - 2) path.Add(c[n + 1]);

               // Console.WriteLine(n);
            }









            return path.Count;
        }

    }
}
