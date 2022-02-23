using System;
using System.Collections.Generic;
namespace Arry_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr=new List<int>() {1,4,3,2};
            List<int> reversedArr=Result.reverseArray(arr);

            foreach( var data in reversedArr)
            {
                Console.Write($" {data} ");
            }
        }
    }

    class Result {
        public static List<int> reverseArray (List<int> arr)
        {
            for( int i=0; i<arr.Count; i++)
            {
                if (i>=arr.Count/2)
                    break;
                int temp=arr[i];
                arr[i]=arr[arr.Count-1-i];
                arr[arr.Count-1-i]=temp;
            }
            return arr;
        }
    }
}
