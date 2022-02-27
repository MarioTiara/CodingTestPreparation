using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SH
{
    
    public class Program
    {
        static void Main(string [] args)
        {
         

            List<List<string>> edges= new List<List<string>>();
            edges.Add(new List<string>(){"i","j"});
            edges.Add(new List<string>(){"k","i"});
            edges.Add(new List<string>(){"m","k"});
            edges.Add(new List<string>(){"k","l"});
            edges.Add(new List<string>(){"o","n"});

        //    Dictionary<string, List<string>> graph= undirected_path.buildGraph(edges);
        //    string json=JsonConvert.SerializeObject(graph);
        //    Console.WriteLine(json);

        Console.WriteLine(undirected_path.undirectedPath(edges,"j","m"));
                
        }

       
    }
}

