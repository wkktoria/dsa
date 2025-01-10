namespace RecursionLibrary;

public static class TailRecursion
{
    /// <summary>
    /// The <c>Fun</c> method demonstrates the tail recursion.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(n)</description>
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
    }
}