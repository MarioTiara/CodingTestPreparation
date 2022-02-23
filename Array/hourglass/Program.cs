using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;  
using System.Linq;  
namespace hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr= new List<List<int>>();
            arr.Add(new List<int>(){1,1, 1, 0,0, 0});
            arr.Add(new List<int>(){0, 1, 0, 0, 0, 0});
            arr.Add(new List<int>(){1, 1, 1, 0, 0, 0});
            arr.Add(new List<int>(){0, 0, 2, 4, 4, 0});
            arr.Add(new List<int>(){0, 0, 0, 2, 0, 0});
            arr.Add(new List<int>(){0, 0, 1, 2, 4, 0});          
            Console.Write(Result.hourglassSum(arr));
        }
    }

    class Result
    {
        public static int hourglassSum (List<List<int>> arr)
        {
            List<int> hourglasess= new List<int>();
            for (int i=0; i<arr.Count-2; i++)
            {
               for (int j=0; j<arr[i].Count-2;j++)
               {
                   int hourglass=arr[i][j]+arr[i][j+1]+arr[i][j+2]+
                                        arr[i+1][j+1]+
                                    arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                    hourglasess.Add(hourglass);     
               }
               //Console.WriteLine();
            }

            return hourglasess.Max();
        }
    }
}
