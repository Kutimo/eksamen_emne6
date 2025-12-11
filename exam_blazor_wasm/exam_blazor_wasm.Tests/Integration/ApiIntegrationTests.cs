using exam_blazor_wasm.Services;

namespace exam_blazor_wasm.Tests.Integration;

public class IntegrationTests
{
    [Fact]
    public async Task GetUsersAsync_ReturnsRealUsers_FromApi()
    {
        var httpClient = new HttpClient();
        var service = new UserService(httpClient);

        var result = await service.GetUsersAsync(5);

        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        Assert.Equal(5, result.Data.Count);
        Assert.All(result.Data, user =>
        {
            Assert.False(string.IsNullOrEmpty(user.FullName));
            Assert.False(string.IsNullOrEmpty(user.Email));
            Assert.False(string.IsNullOrEmpty(user.Country));
            Assert.False(string.IsNullOrEmpty(user.ThumbnailUrl));
            Assert.True(user.Age > 0);
        });
    }
}