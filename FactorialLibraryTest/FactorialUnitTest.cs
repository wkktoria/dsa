using static FactorialLibrary.Factorial;

namespace FactorialLibraryTest;

public class FactorialUnitTest
{
    [Test]
    public void TestFactorialRecursive()
    {
        // arrange
        const int n = 8;
        const int expected = 40320;

        // act
        var result = FactorialRecursive(n);

        // assert
        
        Assert.That(result, Is.EqualTo(expected));
    }
}