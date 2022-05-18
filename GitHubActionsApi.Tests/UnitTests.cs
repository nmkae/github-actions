using Shouldly;
using Xunit;

namespace GitHubActionsApi.Tests;

public class UnitTests
{
    [Fact]
    public void Test1()
    {
        "true".ShouldBe("true");
    }
}