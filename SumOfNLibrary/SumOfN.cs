namespace SumOfNLibrary;

public static class SumOfN
{
    /// <summary>
    /// Recursive approach which calculates the sum of first <paramref name="n"/>
    /// natural numbers.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">the number of terms.</param>
    /// <returns>The sum of first <paramref name="n"/> natural numbers.</returns>
    public static int SumRecursive(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        return SumRecursive(n - 1) + n;
    }
}