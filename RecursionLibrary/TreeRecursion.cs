namespace RecursionLibrary;

public static class TreeRecursion
{
    /// <summary>
    /// The <c>Fun</c> method demonstrates the tree recursion.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(2^n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of times.</param>
    public static void Fun(int n)
    {
        if (n <= 0)
        {
            return;
        }

        Console.Write(n + " ");
        Fun(n - 1);
        Fun(n - 1);
    }
}