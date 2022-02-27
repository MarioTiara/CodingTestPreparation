const shortestPath=(edges, nodeA, nodeB) =>
{
    const graph=buildGraph(edges);
    const visited=new Set([nodeA]);
    console.log(graph);
    const queue=[[nodeA, 0]];
    while(queue.length>0){
       const [node, distance] = queue.shift();
       if(node==nodeB) return distance;
       for(let neighbour of graph[node]){
          if(!visited.has(neighbour)){
            queue.push([neighbour, distance+1]);
          }
          
       }
    }

    return -1;
}

const buildGraph = (edges)=>
{
    const graph={};
    for (let edge of edges){
        const [a,b] = edge;
        if(!(a in graph)) graph[a]= [];
        if(!(b in graph)) graph[b] =[];
        graph[a].push(b);
        graph[b].push(a);
    }

    return graph;
}



const edges=[
    ['w','x'],
    ['x','y'],
    ['z','y'],
    ['z','v'],
    ['w','v']
];


const Path= shortestPath(edges,'x','v')

console.log(Path);

