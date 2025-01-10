using static RecursionLibrary.HeadRecursion;

namespace RecursionLibraryTest;

public class HeadRecursionUnitTest : RecursionUnitTest
{
    [Test]
    public void TestFun()
    {
        // act
        Fun(3);

        // assert
        Assert.That(StringWriter.ToString().Trim(),
            Is.EqualTo("1 2 3"));
    }
}