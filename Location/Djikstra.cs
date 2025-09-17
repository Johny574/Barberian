
public static class Djikstra
{
    public static int[] GetShortestPath(float[,] graph, int src, int destination, int numberOfNodes)
    {
        float[] distances = new float[numberOfNodes];
        int[] predecessors = new int[numberOfNodes];

        for (int n = 0; n < numberOfNodes; n++)
        {
            distances[n] = 10;
            predecessors[n] = -1;
        }

        distances[src] = 0;

        var priorityQueue = new SortedSet<(float distance, int node)>
        {
            (0, src)
        };

        while (priorityQueue.Count > 0)
        {
            var (currentDistance, currentNode) = priorityQueue.Min;
            priorityQueue.Remove(priorityQueue.Min);

            for (int n = 0; n < numberOfNodes; n++)
            {
                if (graph[currentNode, n] > 0)
                {
                    float newDistance = currentDistance + graph[currentNode, n];
                    if (newDistance < distances[n])
                    {
                        distances[n] = newDistance;
                        predecessors[n] = currentNode;
                        priorityQueue.Add((newDistance, n));
                    }
                }
            }
        }
        var path = new List<int>();
        int current = destination;
        while (current != -1)
        {
            path.Add(current);
            current = predecessors[current];
        }
        path.Reverse();
        return path.ToArray();
    }

    public static float[,] CreateGraph(Dictionary<string, Location> nodes)
    {
        float[,] graph = new float[nodes.Count, nodes.Count];

        int i = 0;
        foreach (var key in nodes.Keys)
        {
            graph[i, i] = 0;
            int j = 0;
            foreach (var node in nodes[key].ConnectedLocations)
            {
                // todo : remove this list cast
                graph[i, j] = node.Value;
                j++;
            }
            i++;   
        }
        return graph;
    }
}