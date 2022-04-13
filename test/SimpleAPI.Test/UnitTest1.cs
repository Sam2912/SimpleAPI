using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test;

public class UnitTest1
{
    ValueController controller = new ValueController();
    [Fact]
    public void GetReturnsMyName()
    {
        var actionResult = controller.Get();
        Assert.Equal("Laxman", actionResult.Value);
    }
}