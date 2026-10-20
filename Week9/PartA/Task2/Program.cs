
using System;

Graph graph = new Graph();

Node A = new Node("A");
Node B = new Node("B");
Node C = new Node("C");
Node D = new Node("D");
Node E = new Node("E");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I");

graph.AddEdge(A, B);
graph.AddEdge(A, C);
graph.AddEdge(B, D);
graph.AddEdge(B, E);
graph.AddEdge(C, F);
graph.AddEdge(D, G);
graph.AddEdge(E, H);
graph.AddEdge(F, I);

Console.WriteLine(graph.ToString());


Console.WriteLine("----BFS -----");


HashSet<Node> checkedNodes = new HashSet<Node>();
Queue<Node> queue = new Queue<Node>();


Node target = I;
bool found = false;


queue.Enqueue(A);
checkedNodes.Add(A);


while (queue.Count > 0)
{
    Node current = queue.Dequeue();

    Console.WriteLine("Checking: " + current.Data);

    if (current == target)
    {
        found = true;
        break;
    }

    foreach (Node next in current.Edges)
    {
        if (checkedNodes.Contains(next))
        {
            continue;
        }

        checkedNodes.Add(next);
        queue.Enqueue(next);
    }
}


Console.WriteLine("Visited: " +
    string.Join(", ", checkedNodes.Select(n => n.Data)));

Console.WriteLine("Found: " + found);
