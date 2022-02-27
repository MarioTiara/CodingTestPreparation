using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace SH 
{
    public class undirected_path{

        public static bool undirectedPath(List<List<string>> edges, string nodeA, string NodeB){
            Dictionary<string, List<string>> graph=buildGraph(edges);
            return hasPath(graph,nodeA, NodeB, new List<string>());
        }
        private static bool hasPath(Dictionary<string, List<string>> graph, string source, string dst, List<string> visited){
            if(source==dst) return true;
            if(visited.Contains(source)) return false;
            visited.Add(source);
            foreach (var neighbour in graph[source]){
                if ((hasPath(graph,neighbour,dst,visited))==true)
                    return true;
            }
            return false;
        }

        public static Dictionary<string, List<string>> buildGraph(List<List<string>> edges)
        {
            Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
            for(int i=0; i<edges.Count; i++)
            {
               List<string> edge= edges[i];
               if (!(graph.ContainsKey(edge[0]))) graph.Add(edge[0],new List<string>());
               if (!(graph.ContainsKey(edge[1]))) graph.Add(edge[1],new List<string>());
               graph[edge[0]].Add(edge[1]);
               graph[edge[1]].Add(edge[0]);              
            }
            return graph;
        }
    }
}