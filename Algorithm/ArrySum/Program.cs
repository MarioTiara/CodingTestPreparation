using System;
using System.Collections.Generic;
namespace ArrySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> arr = new List<int>() { 1, 2, 3 };

            simpleArraySum(arr);
            
        }

        static int simpleArraySum(List<int> arr)
        {
            int sum = 0;
            for(int i=0; i < arr.Count-2; i++)
            {

                Console.WriteLine(i);
                //Console.WriteLine(sum += (arr[i] + arr[i + 2]));
            }
            return -1;
        }
    }
}
