
using System;
using System.Collections.Generic;
using System.Linq;


Graph graph = new Graph();


Node Start = new Node("Start");
Node A = new Node("A");
Node B = new Node("B (BEES)");
Node C = new Node("C");
Node D = new Node("D (BEES)");
Node E = new Node("E (BEES)");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I (BEES)");
Node J = new Node("J (BEES)");
Node K = new Node("K");
Node L = new Node("L");
Node M = new Node("M");
Node N = new Node("N");
Node End = new Node("End");



graph.AddEdge(Start, A, 1);
graph.AddEdge(Start, B, 5);
graph.AddEdge(Start, D, 5);

graph.AddEdge(A, C, 1);
graph.AddEdge(B, E, 5);

graph.AddEdge(D, C, 5);
graph.AddEdge(D, E, 5);
graph.AddEdge(D, G, 5);

graph.AddEdge(E, H, 5);
graph.AddEdge(C, F, 1);

graph.AddEdge(G, F, 1);
graph.AddEdge(G, H, 1);
graph.AddEdge(G, J, 1);

graph.AddEdge(F, I, 5);
graph.AddEdge(H, K, 1);

graph.AddEdge(J, I, 5);
graph.AddEdge(J, K, 5);
graph.AddEdge(J, M, 5);

graph.AddEdge(I, L, 5);
graph.AddEdge(K, N, 1);

graph.AddEdge(M, L, 1);
graph.AddEdge(M, N, 1);

graph.AddEdge(L, End, 1);

Console.WriteLine("=== Horse Graph ===");
Console.WriteLine(graph.ToString());


Console.WriteLine("Nodes: " + graph.Nodes.Count);


Console.WriteLine("Edges: " +
    graph.Nodes.Sum(n => n.Edges.Count) / 2);




Node target = End;


Dictionary<Node, int> DistanceList =
    new Dictionary<Node, int>();

// 距离越小，优先级越高
PriorityQueue<Node, int> priorityQueue =
    new PriorityQueue<Node, int>();


Dictionary<Node, Node?> parents =
    new Dictionary<Node, Node?>();


foreach (Node node in graph.Nodes)
{
    
    DistanceList[node] = int.MaxValue;
}

DistanceList[Start] = 0;


parents[Start] = null;


priorityQueue.Enqueue(Start, 0);


while (priorityQueue.Count > 0)
{
    
    priorityQueue.TryDequeue(
        out Node current,
        out int currentDistance
    );

    if (currentDistance > DistanceList[current])
    {
        continue;
    }

    if (current == target)
    {
        break;
    }

    foreach (var neighbor in current.Edges)
    {
        Node nextNode = neighbor.Key;

        int weight = neighbor.Value;

        int newDistance = DistanceList[current] + weight;

        
        if (newDistance < DistanceList[nextNode])
        {
            
            DistanceList[nextNode] = newDistance;

            


            parents[nextNode] = current;

            priorityQueue.Enqueue(nextNode, newDistance);
        }
    }
}

 
Console.WriteLine();
Console.WriteLine("=== Dijkstra Shortest Path ===");


if (DistanceList[target] == int.MaxValue)
{
    Console.WriteLine("No path found.");
}
else
{
   
    List<string> path = new List<string>();


    Node? node = target;

  
    while (node != null)
    {
      
        path.Add(node.Data);

       
        node = parents[node];
    }


    path.Reverse();

    Console.WriteLine(string.Join(" -> ", path));

 
    Console.WriteLine("The Total Distance is : " + DistanceList[target]);
}
