namespace RecursionLibrary;

/// <summary>
/// The methods <see cref="FunA"/> and <see cref="FunB"/> demonstrate the indirect recursion.
/// </summary>
public static class IndirectRecursion
{
    public static void FunA(int n)
    {
        if (n <= 0)
        {
            return;
        }

        Console.Write(n + " ");
        FunB(n - 1);
    }

    public static void FunB(int n)
    {
        if (n <= 1)
        {
            return;
        }

        Console.Write(n + " ");
        FunA(n / 2);
    }
}