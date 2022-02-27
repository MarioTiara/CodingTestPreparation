using System;
using System.Collections.Generic;
namespace SH 
{
    public class depthFirst
    {
        public  static void depthFirstPrint(Dictionary<string,List<string>> graph,string source)
        {
            Console.WriteLine(source);
            foreach(var neighbour in graph[source]){
                depthFirstPrint(graph,neighbour);
            };
        }
    }
}