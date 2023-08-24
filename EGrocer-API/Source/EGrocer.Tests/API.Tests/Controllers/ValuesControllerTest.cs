using EGrocer.API.Controllers;

namespace EGrocer.Tests.API.Tests.Controllers;

public class ValuesControllerTests
{
    [Fact]
    public void Method_ReturnsExpectedValue()
    {
        // Arrange
        var controller = new ValuesController();

        // Act
        var result = controller.Method();

        // Assert
        Assert.Equal("Surya", result);
    }
}
