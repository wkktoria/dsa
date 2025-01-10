using FactorialLibrary;
using static FactorialLibrary.Factorial;

namespace nCrLibrary;

public static class Ncr
{
    /// <summary>
    /// Approach using <see cref="Factorial.FactorialRecursive"/> to calculate the number of ways
    /// to choose <paramref name="r"/> elements from a set of <paramref name="n"/> distinct elements,
    /// without the regard to the order in which they are selected.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of elements.</param>
    /// <param name="r">element to choose.</param>
    /// <returns>The number of ways to choose <paramref name="r"/> elements from a set of <paramref name="n"/> elements.</returns>
    public static int NcrFactorial(int n, int r)
    {
        var numerator = FactorialRecursive(n);
        var denominator = FactorialRecursive(r) * FactorialRecursive(n - r);
        return numerator / denominator;
    }

    /// <summary>
    /// The recursive approach to calculate the number of ways to choose <paramref name="r"/> elements
    /// from a set of <paramref name="n"/> distinct elements, without the regard to the order
    /// in which they are selected.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(2^n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of elements.</param>
    /// <param name="r">element to choose.</param>
    /// <returns>The number of ways to choose <paramref name="r"/> elements from a set of <paramref name="n"/> elements.</returns>
    public static int NcrRecursive(int n, int r)
    {
        if (n == r || r == 0)
        {
            return 1;
        }

        return NcrRecursive(n - 1, r - 1) + NcrRecursive(n - 1, r);
    }
}