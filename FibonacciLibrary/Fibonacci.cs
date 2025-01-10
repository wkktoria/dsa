namespace FibonacciLibrary;

public static class Fibonacci
{
    private static readonly int[] Arr = Enumerable.Repeat(-1, short.MaxValue).ToArray();

    /// <summary>
    /// Recursive approach to find the <paramref name="n"/>th number of the Fibonacci series.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(2^n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of Fibonacci series.</param>
    /// <returns>The <paramref name="n"/>th number of the Fibonacci series.</returns>
    public static int FibRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return FibRecursive(n - 2) + FibRecursive(n - 1);
    }

    /// <summary>
    /// Approach to find the <paramref name="n"/>th number of the Fibonacci series
    /// using memoization.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of Fibonacci series.</param>
    /// <returns>The <paramref name="n"/>th number of the Fibonacci series.</returns>
    public static int FibMemoization(int n)
    {
        if (n <= 1)
        {
            Arr[n] = n;
            return n;
        }

        if (Arr[n - 2] == -1)
        {
            Arr[n - 2] = FibMemoization(n - 2);
        }

        if (Arr[n - 1] == -1)
        {
            Arr[n - 1] = FibMemoization(n - 1);
        }

        Arr[n] = Arr[n - 2] + Arr[n - 1];

        return Arr[n];
    }

    /// <summary>
    /// Iterative approach to find the <paramref name="n"/>th number of the Fibonacci series.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(1)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of Fibonacci series.</param>
    /// <returns>The <paramref name="n"/>th number of the Fibonacci series.</returns>
    public static int FibIterative(int n)
    {
        var t0 = 0;
        var t1 = 1;
        var sum = 0;

        if (n <= 1)
        {
            return n;
        }

        for (var i = 2; i <= n; i++)
        {
            sum = t0 + t1;
            t0 = t1;
            t1 = sum;
        }

        return sum;
    }
}