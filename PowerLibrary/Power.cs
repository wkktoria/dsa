namespace PowerLibrary;

public static class Power
{
    /// <summary>
    /// Recursive approach to calculate the power of <paramref name="m"/> to <paramref name="n"/>.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="m">the base.</param>
    /// <param name="n">the exponent.</param>
    /// <returns>The power of <paramref name="m"/> to <paramref name="n"/>.</returns>
    public static int PowRecursive(int m, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return PowRecursive(m, n - 1) * m;
    }

    /// <summary>
    /// Recursive approach to calculate the power of <paramref name="m"/> to <paramref name="n"/>,
    /// but optimized.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(log n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(log n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="m">the base.</param>
    /// <param name="n">the exponent.</param>
    /// <returns>The power of <paramref name="m"/> to <paramref name="n"/>.</returns>
    public static int PowRecursiveOptimized(int m, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n % 2 == 0)
        {
            return PowRecursiveOptimized(m * m, n / 2);
        }

        return m * PowRecursiveOptimized(m * m, (n - 1) / 2);
    }
}