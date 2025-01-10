using static PowerLibrary.Power;

namespace PowerLibraryTest;

public class PowerUnitTest
{
    private const int M = 2;
    private const int N = 8;
    private const int Expected = 256;

    [Test]
    public void TestPowRecursive()
    {
        // arrange + act
        var result = PowRecursive(M, N);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }

    [Test]
    public void TestPowRecursiveOptimized()
    {
        // arrange + act
        var result = PowRecursiveOptimized(M, N);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }
}