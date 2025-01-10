using static TaylorSeriesLibrary.TaylorSeries;

namespace TaylorSeriesLibraryTest;

public class TaylorSeriesUnitTest
{
    private const int X = 4;
    private const int N = 15;

    [Test]
    public void TestTaylorSeriesRecursive()
    {
        // arrange
        const int expected = 54;

        // act
        var result = (int)TaylorSeriesRecursive(X, N);

        // assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestTaylorSeriesHornersRule()
    {
        // arrange
        const int expected = 54;

        // act
        var result = (int)TaylorSeriesHornersRule(X, N);

        // assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestTaylorSeriesIterative()
    {
        // arrange
        const int expected = 53;

        // act
        var result = (int)TaylorSeriesIterative(X, N);

        // assert
        Assert.That(result, Is.EqualTo(expected));
    }
}