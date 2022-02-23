using System;
using System.Collections.Generic;
using System.Linq;

namespace dynamic_array
{
    public class Result
    {
          public static List<int> dynamicArray(int n, List<List<int>> queries)
            {
               
                List<int> LastAnswers= new List<int>();
                int lasAnswer =0;
                List<List<int>> seq = new List<List<int>>();
                for(int i=0; i<n; i++)
                {
                    seq.Add( new List<int>());
                }
                foreach ( var query in queries)
                {
                    int index=(query[1]^lasAnswer) %n;
                    if(query.First()==1)
                        seq[index].Add(query.Last());
                    else{
                        int y = query.Last();
                        int size = seq[index].Count();
                        lasAnswer=seq[index][y%size];
                        LastAnswers.Add(lasAnswer);
                    }
                }

                return LastAnswers;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> queries= new List<List<int>>();
            queries.Add(new List<int>(){2,5});
            List<int> result=Result.dynamicArray(2, queries);
            Console.WriteLine("Hello World!");
        }
    }
}
