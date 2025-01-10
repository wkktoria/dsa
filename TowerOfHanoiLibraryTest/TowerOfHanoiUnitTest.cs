using static TowerOfHanoiLibrary.TowerOfHanoi;

namespace TowerOfHanoiLibraryTest;

public class Tests
{
    [Test]
    public void TestToh()
    {
        // arrange
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // act
        Toh(2, 1, 2, 3);

        // assert
        var output = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        Assert.Multiple(() =>
        {
            Assert.That(output[0], Is.EqualTo("Move from 1 to 2"));
            Assert.That(output[1], Is.EqualTo("Move from 1 to 3"));
            Assert.That(output[2], Is.EqualTo("Move from 2 to 3"));
        });
    }

    [Test]
    public void Demo()
    {
        Toh(3, 1, 2, 3);
    }
}