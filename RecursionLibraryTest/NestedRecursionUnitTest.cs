using static RecursionLibrary.NestedRecursion;

namespace RecursionLibraryTest;

public class NestedRecursionUnitTest
{
    [Test]
    public void TestFun()
    {
        // arrange + act
        var resul = Fun(3);

        // assert
        Assert.That(resul, Is.EqualTo(91));
    }
}