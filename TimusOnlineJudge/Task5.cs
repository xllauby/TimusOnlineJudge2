using System;
using System.Linq;

class Task5
{
    static void Main()
    {
        var parts = Console.ReadLine()!.Split();
        int n = int.Parse(parts[0]);
        int k = int.Parse(parts[1]);

        var powerCities = Console.ReadLine()!.Split().Select(int.Parse).Select(x => x - 1).ToArray();

        int[,] cost = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            var row = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            for (int j = 0; j < n; j++)
                cost[i, j] = row[j];
        }

        bool[] inMST = new bool[n];
        int[] minEdge = new int[n];

        for (int i = 0; i < n; i++)
            minEdge[i] = int.MaxValue;

        foreach (var city in powerCities)
            inMST[city] = true;

        for (int i = 0; i < n; i++)
        {
            if (!inMST[i])
            {
                int minCost = int.MaxValue;
                foreach (var pc in powerCities)
                {
                    if (cost[i, pc] < minCost)
                        minCost = cost[i, pc];
                }
                minEdge[i] = minCost;
            }
        }

        int result = 0;

        int remain = n - k;

        while (remain > 0)
        {
            int v = -1;
            int minCost = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (!inMST[i] && minEdge[i] < minCost)
                {
                    minCost = minEdge[i];
                    v = i;
                }
            }

            inMST[v] = true;
            result += minCost;
            remain--;

            for (int i = 0; i < n; i++)
            {
                if (!inMST[i] && cost[v, i] < minEdge[i])
                    minEdge[i] = cost[v, i];
            }
        }

        Console.WriteLine(result);
    }
}
