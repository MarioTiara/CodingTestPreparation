using System;
using System.Collections.Generic;
namespace SH 
{
    public class breadFirst
    {
       public static void breadthFirstPrint( Dictionary<string,List<string>> graph, string source)
       {
           Queue <string> queue= new Queue<string>();
           queue.Enqueue(source);
           while(queue.Count>0){
               string current =queue.Dequeue();
               Console.WriteLine(current);
               foreach(var neighbour in graph[current]){
                   queue.Enqueue(neighbour);
               }
           }
           
       }
    }
}