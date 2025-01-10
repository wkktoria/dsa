using static SumOfNLibrary.SumOfN;

namespace SumOfNLibraryTest;

public class SumOfNUnitTest
{
    [Test]
    public void TestSumOfNRecursive()
    {
        // arrange
        const int n = 10;
        const int expected = 55;

        // act
        var result = SumRecursive(n);

        // assert
        Assert.That(result, Is.EqualTo(expected));
    }
}