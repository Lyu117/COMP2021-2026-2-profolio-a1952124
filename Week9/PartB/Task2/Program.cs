
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create the horse graph
        var graph = new Dictionary<string, List<(string Node, int Weight)>>();

        // Add all 23 edges from the assignment
        AddEdge(graph, "Start", "A", 1);
        AddEdge(graph, "Start", "B", 5);
        AddEdge(graph, "Start", "D", 5);

        AddEdge(graph, "A", "C", 1);
        AddEdge(graph, "B", "E", 5);

        AddEdge(graph, "D", "C", 5);
        AddEdge(graph, "D", "E", 5);
        AddEdge(graph, "D", "G", 5);

        AddEdge(graph, "E", "H", 5);
        AddEdge(graph, "C", "F", 1);

        AddEdge(graph, "G", "F", 1);
        AddEdge(graph, "G", "H", 1);
        AddEdge(graph, "G", "J", 1);

        AddEdge(graph, "F", "I", 5);
        AddEdge(graph, "H", "K", 1);

        AddEdge(graph, "J", "I", 5);
        AddEdge(graph, "J", "K", 5);
        AddEdge(graph, "J", "M", 5);

        AddEdge(graph, "I", "L", 5);
        AddEdge(graph, "K", "N", 1);

        AddEdge(graph, "M", "L", 1);
        AddEdge(graph, "M", "N", 1);

        AddEdge(graph, "L", "End", 1);

        Console.WriteLine("=== Horse Graph ===");
        Console.WriteLine("Dijkstra's Shortest Path Algorithm");
        Console.WriteLine();

        Console.WriteLine($"Total Nodes: {graph.Count}");
        Console.WriteLine(
            $"Total Edges: {graph.Values.Sum(x => x.Count) / 2}");
        Console.WriteLine();

        // Run Dijkstra's algorithm
        FindShortestPath(graph, "Start", "End");
    }

    // Add an undirected weighted edge
    static void AddEdge(
        Dictionary<string, List<(string Node, int Weight)>> graph,
        string from,
        string to,
        int weight)
    {
        if (weight < 0)
        {
            throw new ArgumentException(
                "Dijkstra does not support negative weights.");
        }

        if (!graph.ContainsKey(from))
        {
            graph[from] = new();
        }

        if (!graph.ContainsKey(to))
        {
            graph[to] = new();
        }

        // Both directions have the same weight
        graph[from].Add((to, weight));
        graph[to].Add((from, weight));
    }

    // Find the shortest path using Dijkstra
    static void FindShortestPath(
        Dictionary<string, List<(string Node, int Weight)>> graph,
        string start,
        string end)
    {
        if (!graph.ContainsKey(start) ||
            !graph.ContainsKey(end))
        {
            Console.WriteLine("Invalid start or end node.");
            return;
        }

        // Distance from Start to each node
        var distances = new Dictionary<string, long>();

        // Previous node on the shortest path
        var previous = new Dictionary<string, string?>();

        // Priority queue for efficient searching
        var queue = new PriorityQueue<string, long>();

        foreach (string node in graph.Keys)
        {
            distances[node] = long.MaxValue;
            previous[node] = null;
        }

        distances[start] = 0;
        queue.Enqueue(start, 0);

        while (queue.Count > 0)
        {
            queue.TryDequeue(
                out string? current,
                out long currentDistance);

            if (current == null)
                continue;

            // Skip outdated queue entries
            if (currentDistance > distances[current])
                continue;

            // The shortest distance to End is found
            if (current == end)
                break;

            // Check all connected nodes
            foreach (var edge in graph[current])
            {
                string neighbor = edge.Node;
                int weight = edge.Weight;

                long newDistance =
                    currentDistance + weight;

                // Update only if a shorter path is found
                if (newDistance < distances[neighbor])
                {
                    distances[neighbor] = newDistance;
                    previous[neighbor] = current;

                    queue.Enqueue(neighbor, newDistance);
                }
            }
        }

        // Handle an unreachable destination
        if (distances[end] == long.MaxValue)
        {
            Console.WriteLine("No path to End was found.");
            return;
        }

        // Reconstruct the shortest path
        var path = new List<string>();
        string? step = end;

        while (step != null)
        {
            path.Add(step);
            step = previous[step];
        }

        path.Reverse();

        Console.WriteLine("Shortest Path:");
        Console.WriteLine(string.Join(" -> ", path));
        Console.WriteLine();

        Console.WriteLine(
            $"Total Distance: {distances[end]}");

        Console.WriteLine(
            $"Nodes in Path: {path.Count}");

        // Check whether the path contains bee nodes
        var beeNodes = new HashSet<string>
        {
            "B", "D", "E", "I", "J"
        };

        int beesVisited = path.Count(
            node => beeNodes.Contains(node));

        Console.WriteLine(
            $"Bee Nodes Visited: {beesVisited}");

        Console.WriteLine();
        Console.WriteLine("Dijkstra completed successfully.");
    }
}
