namespace TowerOfHanoiLibrary;

public static class TowerOfHanoi
{
    /// <summary>
    /// Recursive approach to solve the Tower of Hanoi problem.
    /// <list type="bullet">
    /// <item>
    /// <description>Time Complexity: O(2^n)</description>
    /// </item>
    /// <item>
    /// <description>Space Complexity: O(n)</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="n">number of disks.</param>
    /// <param name="a">first tower number.</param>
    /// <param name="b">second tower number.</param>
    /// <param name="c">third tower number.</param>
    public static void Toh(int n, int a, int b, int c)
    {
        if (n <= 0)
        {
            return;
        }

        Toh(n - 1, a, c, b);
        Console.WriteLine($"Move from {a} to {c}");
        Toh(n - 1, b, a, c);
    }
}