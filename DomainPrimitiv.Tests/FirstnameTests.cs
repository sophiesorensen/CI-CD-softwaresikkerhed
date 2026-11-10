
using Xunit;

public class FirstnameTests
{
    [Fact]
    public void Firstname_WithValidLength_DoesNotThrowException()
    {
        var exception = Record.Exception(() => new Firstname("Sophie"));
        Assert.Null(exception);
    }

    [Fact]
    public void Firstname_WithTooShortLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Firstname("A"));
    }

    [Fact]
    public void Firstname_WithTooLongLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Firstname("abcdefghijklmnopqrstu"));
    }

[Fact]
public void Firstname_WithValidCharacters_DoesNotThrowException()
{
    var exception = Record.Exception(() => new Firstname("Søren"));
    Assert.Null(exception);
}

[Fact]
public void Firstname_WithNumbers_ThrowsArgumentException()
{
    Assert.Throws<ArgumentException>(() => new Firstname("Sophie2"));
}

[Fact]
public void Firstname_WithSpecialCharacters_ThrowsArgumentException()
{
    Assert.Throws<ArgumentException>(() => new Firstname("Sophie!"));
}

[Fact]
public void Firstname_WithNull_ThrowsArgumentException()
{
    Assert.Throws<ArgumentException>(() => new Firstname(null));
}

}
