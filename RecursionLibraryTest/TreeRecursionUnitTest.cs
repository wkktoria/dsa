using static RecursionLibrary.TreeRecursion;

namespace RecursionLibraryTest;

public class TreeRecursionUnitTest : RecursionUnitTest
{
    [Test]
    public void TestFun()
    {
        // act
        Fun(3);

        // assert
        Assert.That(StringWriter.ToString().Trim(),
            Is.EqualTo("3 2 1 1 2 1 1"));
    }
}