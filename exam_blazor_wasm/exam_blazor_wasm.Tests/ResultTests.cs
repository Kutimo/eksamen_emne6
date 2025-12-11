using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Tests;

public class ResultTests
{
    [Fact]
    public void Success_ReturnsIsSuccessTrue()
    {
        var result = Result<string>.Success("data");

        Assert.True(result.IsSuccess);
        Assert.Equal("data", result.Data);
        Assert.Null(result.ErrorMessage);
    }

    [Fact]
    public void Failure_ReturnsIsSuccessFalse()
    {
        var result = Result<string>.Failure("error");

        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.Equal("error", result.ErrorMessage);
    }
}