namespace FactorialLibrary;

public static class Factorial
{
    /// <summary>
    /// Recursive approach for computing the factorial.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">the number to find factorial of.</param>
    /// <returns>The factorial of <paramref name="n"/>.</returns>
    public static int FactorialRecursive(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return FactorialRecursive(n - 1) * n;
    }
}