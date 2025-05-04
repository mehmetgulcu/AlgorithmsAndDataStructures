class Graph
{
    Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public void AddEdge(int u, int v)
    {
        if (!adjList.ContainsKey(u)) adjList[u] = new List<int>();
        if (!adjList.ContainsKey(v)) adjList[v] = new List<int>();

        adjList[u].Add(v);
        adjList[v].Add(u); // yönsüz grafik için
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjList)
        {
            Console.Write($"{vertex.Key}: ");
            foreach (var neighbor in vertex.Value)
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        var graph = new Graph();
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);

        Console.WriteLine("Graph:");
        graph.PrintGraph();
    }
}