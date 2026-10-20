
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

graph.AddEdge(D, E);
graph.AddEdge(E, F);
graph.AddEdge(G, H);
graph.AddEdge(H, I);
graph.AddEdge(F, H);

Console.WriteLine(graph.ToString());




Console.WriteLine("==-= DFS ===");


HashSet<Node> dfsChecked = new HashSet<Node>();
HashSet<Node> dfsDiscovered = new HashSet<Node>();
Stack<Node> stack = new Stack<Node>();


Node dfsTarget = I;
bool dfsFound = false;


stack.Push(A);
dfsDiscovered.Add(A);


while (stack.Count > 0)
{
    Node current = stack.Pop();

    dfsChecked.Add(current);

    Console.WriteLine("Checking: " + current.Data);

    if (current == dfsTarget)
    {
        dfsFound = true;
        break;
    }

    foreach (Node next in current.Edges)
    {
        if (dfsDiscovered.Contains(next))
        {
            continue;
        }

        dfsDiscovered.Add(next);
        stack.Push(next);
    }
}


Console.WriteLine("Visited: " +
    string.Join(", ", dfsChecked.Select(n => n.Data)));

Console.WriteLine("Found: " + dfsFound);
