using System;

class Task3
{
    const int MOD = 1_000_000_007;

    static void Main()
    {
        var tokens = Console.ReadLine().Split();
        int n = int.Parse(tokens[0]);
        int a = int.Parse(tokens[1]);
        int b = int.Parse(tokens[2]);


        long[] dp1 = new long[a + 1];
        long[] dp2 = new long[b + 1];

        dp1[1] = 1;
        dp2[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            long[] newDp1 = new long[a + 1];
            long[] newDp2 = new long[b + 1];

            for (int j = 1; j < a; j++)
                newDp1[j + 1] = (newDp1[j + 1] + dp1[j]) % MOD;

            long sum2 = 0;
            for (int j = 1; j <= b; j++)
                sum2 = (sum2 + dp2[j]) % MOD;

            newDp1[1] = (newDp1[1] + sum2) % MOD;
            for (int j = 1; j < b; j++)
                newDp2[j + 1] = (newDp2[j + 1] + dp2[j]) % MOD;

            long sum1 = 0;
            for (int j = 1; j <= a; j++)
                sum1 = (sum1 + dp1[j]) % MOD;

            newDp2[1] = (newDp2[1] + sum1) % MOD;

            dp1 = newDp1;
            dp2 = newDp2;
        }

        long result = 0;
        for (int j = 1; j <= a; j++)
            result = (result + dp1[j]) % MOD;
        for (int j = 1; j <= b; j++)
            result = (result + dp2[j]) % MOD;

        Console.WriteLine(result);
    }
}
