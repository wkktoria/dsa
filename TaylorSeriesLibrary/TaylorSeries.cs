namespace TaylorSeriesLibrary;

public static class TaylorSeries
{
    private static double _power = 1;
    private static double _factorial = 1;
    private static double _sum;

    /// <summary>
    /// Recursive approach to calculate e^<paramref name="x"/> using Taylor series.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="x">the exponent.</param>
    /// <param name="n">the terms.</param>
    /// <returns>e^<paramref name="x"/>.</returns>
    public static double TaylorSeriesRecursive(int x, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        var result = TaylorSeriesRecursive(x, n - 1);
        _power *= x;
        _factorial *= n;

        return result + _power / _factorial;
    }

    /// <summary>
    /// Approach to calculate e^<paramref name="x"/> using Taylor series with the help or Horner's rule.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="x">the exponent.</param>
    /// <param name="n">the terms.</param>
    /// <returns>e^<paramref name="x"/>.</returns>
    public static double TaylorSeriesHornersRule(int x, int n)
    {
        if (n == 0)
        {
            return _sum;
        }

        _sum = 1 + x * _sum / n;
        return TaylorSeriesHornersRule(x, n - 1);
    }

    /// <summary>
    /// Iterative approach to calculate e^<paramref name="x"/> using Taylor series.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(1)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="x">the exponent.</param>
    /// <param name="n">the terms.</param>
    /// <returns>e^<paramref name="x"/>.</returns>
    public static double TaylorSeriesIterative(int x, int n)
    {
        double sum = 0;
        double numerator = 1;
        double denominator = 1;

        for (var i = 1; i <= n; i++)
        {
            numerator *= x;
            denominator *= i;
            sum += numerator / denominator;
        }

        return sum;
    }
}