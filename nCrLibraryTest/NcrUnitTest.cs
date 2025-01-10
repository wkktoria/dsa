using static nCrLibrary.Ncr;

namespace nCrLibraryTest;

public class NcrUnitTest
{
    private const int N = 8;
    private const int R = 3;
    private const int Expected = 56;

    [Test]
    public void TestNcrRecursive()
    {
        // arrange + act
        var result = NcrRecursive(N, R);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }

    [Test]
    public void TestNcrFactorial()
    {
        // arrange + act
        var result = NcrFactorial(N, R);

        // assert
        Assert.That(result, Is.EqualTo(Expected));
    }
}