using static FibonacciLibrary.Fibonacci;

namespace FibonacciLibraryTest;

public class FibonacciUnitTest
{
    private const int N = 15;
    private const int Expected = 610;

    [Test]
    public void TestFibRecursive()
    {
        // arrange + act
        var result = FibRecursive(N);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }

    [Test]
    public void TestFibMemoization()
    {
        // arrange + act
        var result = FibMemoization(N);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }

    [Test]
    public void TestFibIterative()
    {
        // arrange + act
        var result = FibIterative(N);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }
}