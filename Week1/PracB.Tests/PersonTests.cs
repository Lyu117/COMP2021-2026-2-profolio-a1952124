using PracB;
using Xunit;

namespace PracB.Tests;

public class PersonTests
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("David", "Smith", 20);

        string result = person.FullName();

        Assert.Equal("David Smith", result);
    }

    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("David", "Smith", 18);

        bool result = person.IsAdult();

        Assert.True(result);
    }
}