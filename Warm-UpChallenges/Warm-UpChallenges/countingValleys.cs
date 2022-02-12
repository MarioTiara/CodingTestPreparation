using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warm_UpChallenges
{
    public class ThecountingValleys
    {
        /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

        public static int countingValleys(int steps, string path)
        {
            List<int> stepsFoot = new List<int>();
            foreach (char c in path.ToCharArray())
            {
                if (c.Equals('U')) stepsFoot.Add(1);
                else stepsFoot.Add(-1);
            }

            int valey = 0;
            int Path = 0;
            bool isInValey = false;
            foreach (int step in stepsFoot)
            {

                Path += step;
                if (Path < 0 && !isInValey)
                    isInValey = true;
                else if (Path == 0 && isInValey)
                {
                    valey++;
                    isInValey = false;
                }

            }
            return valey;
        }

    }
}
