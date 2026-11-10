
using Xunit;

public class LastnameTests
{
    [Fact]
    public void Lastname_WithValidLength_DoesNotThrowException()
    {
        var exception = Record.Exception(() => new Lastname("Sørensen"));
        Assert.Null(exception);
    }

    [Fact]
    public void Lastname_WithTooShortLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Lastname("A"));
    }

    [Fact]
    public void Lastname_WithTooLongLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Lastname("abcdefghijklmnopqrstu"));
    }

    [Fact]
    public void Lastname_WithValidCharacters_DoesNotThrowException()
    {
        var exception = Record.Exception(() => new Lastname("Nielsen"));
        Assert.Null(exception);
    }

    [Fact]
    public void Lastname_WithNumbers_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Lastname("Nielsen2"));
    }

    [Fact]
    public void Lastname_WithSpecialCharacters_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Lastname("Nielsen!"));
    }

    [Fact]
    public void Lastname_WithNull_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Lastname(null!));
    }
}
