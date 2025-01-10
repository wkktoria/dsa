using static RecursionLibrary.TailRecursion;

namespace RecursionLibraryTest;

public class TailRecursionUnitTest : RecursionUnitTest
{
    [Test]
    public void TestFun()
    {
        // act
        Fun(3);

        // assert
        Assert.That(StringWriter.ToString().Trim(),
            Is.EqualTo("3 2 1"));
    }
}