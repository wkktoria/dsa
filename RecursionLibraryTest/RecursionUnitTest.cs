namespace RecursionLibraryTest;

public abstract class RecursionUnitTest
{
    protected StringWriter StringWriter;

    [SetUp]
    public void Setup()
    {
        StringWriter = new StringWriter();
        Console.SetOut(StringWriter);
    }

    [TearDown]
    public void TearDown()
    {
        StringWriter.Dispose();
    }
}