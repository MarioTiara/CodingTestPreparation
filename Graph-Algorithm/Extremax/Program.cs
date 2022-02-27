using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Extremax
{
    class Program{
        static void Main (string [] args){
              List<List<string>> edges= new List<List<string>>();
                edges.Add(new List<string>(){"A","B"});
                edges.Add(new List<string>(){"A","E"});
                edges.Add(new List<string>(){"A","H"});
                edges.Add(new List<string>(){"B","C"});
                edges.Add(new List<string>(){"B","F"});
                edges.Add(new List<string>(){"C","D"});
                edges.Add(new List<string>(){"D","G"});
                edges.Add(new List<string>(){"G","F"});
                edges.Add(new List<string>(){"G","J"});
                edges.Add(new List<string>(){"F","I"});
                edges.Add(new List<string>(){"J","K"});
                edges.Add(new List<string>(){"K","H"});

             Console.WriteLine(undirected_path.undirectedPath(edges,"A","E"));
            
        }
    }
}

