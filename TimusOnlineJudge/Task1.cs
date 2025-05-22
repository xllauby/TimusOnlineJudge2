using System;

class Task1
{
    static void Main()
    {
        string[] tokens = Console.ReadLine().Split(' ');
        int B = int.Parse(tokens[0]);
        int R = int.Parse(tokens[1]);
        int Y = int.Parse(tokens[2]);

        var colorCount = new System.Collections.Generic.Dictionary<string, int>
        {
            ["Blue"] = B,
            ["Red"] = R,
            ["Yellow"] = Y
        };

        int K = int.Parse(Console.ReadLine());
        long ways = 1;

        for (int i = 0; i < K; i++)
        {
            string color = Console.ReadLine().Trim();
            ways *= colorCount[color];
        }

        Console.WriteLine(ways);
    }
}
