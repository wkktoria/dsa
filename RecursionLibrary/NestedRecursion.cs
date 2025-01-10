namespace RecursionLibrary;

public static class NestedRecursion
{
    /// <summary>
    /// The <c>Fun</c> method demonstrates the nested recursion.
    /// </summary>
    /// <param name="n">number of times.</param>
    /// <returns></returns>
    public static int Fun(int n)
    {
        if (n > 100)
        {
            return n - 10;
        }

        return Fun(Fun(n + 11));
    }
}