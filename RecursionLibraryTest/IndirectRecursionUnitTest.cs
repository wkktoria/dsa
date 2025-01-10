using static RecursionLibrary.IndirectRecursion;

namespace RecursionLibraryTest;

public class IndirectRecursionUnitTest : RecursionUnitTest
{
    [Test]
    public void TestFunA()
    {
        // act
        FunA(3);

        // assert
        Assert.That(StringWriter.ToString().Trim(),
            Is.EqualTo("3 2 1"));
    }

    [Test]
    public void TestFunB()
    {
        // act
        FunB(3);

        // assert
        Assert.That(StringWriter.ToString().Trim(),
            Is.EqualTo("3 1"));
    }
}