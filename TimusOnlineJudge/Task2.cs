using System;
using System.Collections.Generic;

class Task2
{
    static void Main()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0)
                break;

            int[] a = new int[n + 1];
            a[0] = 0;
            if (n >= 1)
                a[1] = 1;

            int maxVal = Math.Max(a[0], n >= 1 ? a[1] : 0);

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                    a[i] = a[i / 2];
                else
                    a[i] = a[i / 2] + a[i / 2 + 1];

                if (a[i] > maxVal)
                    maxVal = a[i];
            }

            Console.WriteLine(maxVal);
        }
    }
}
