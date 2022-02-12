using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_UpChallenges
{
    public class SalesbyMatch
    {
        /*
    * Complete the 'sockMerchant' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER n
    *  2. INTEGER_ARRAY ar
    */

        public static int sockMerchant(int n, List<int> ar)
        {
            int pairs = 0;
            if (ar.Count == 0) return pairs;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < ar.Count; i++)
            {
                if (!set.Contains(ar[i]))
                {
                    set.Add(ar[i]);
                }
                else
                {
                    pairs++;
                    set.Remove(ar[i]);
                }
            }

            return pairs;
        }
    }
}
