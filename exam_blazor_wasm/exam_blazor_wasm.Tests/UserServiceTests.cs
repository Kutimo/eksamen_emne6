using System.Net;
using System.Text.Json;
using Moq;
using Moq.Protected;
using exam_blazor_wasm.Models;
using exam_blazor_wasm.Services;

namespace exam_blazor_wasm.Tests;

public class UserServiceTests
{
    [Fact]
    public async Task GetUsersAsync_ReturnsUsers_WhenApiSucceeds()
    {
        var mockResponse = new ApiResponse
        {
            Results =
            [
                new ApiUser
                {
                    Gender = "male",
                    Name = new ApiName
                        { Title = "Mr", First = "John", Last = "Doe" },
                    Email = "john@example.com",
                    Phone = "123456",
                    Dob = new ApiDob { Age = 30 },
                    Nat = "US",
                    Registered = new ApiRegistered { Date = DateTime.Now },
                    Location = new ApiLocation
                    {
                        Street = new ApiStreet
                            { Number = 123, Name = "Main St" },
                        City = "New York",
                        State = "NY",
                        Country = "USA"
                    },
                    Picture = new ApiPicture
                    {
                        Thumbnail = "thumb.jpg",
                        Large = "large.jpg"
                    },
                    Login = new ApiLogin { Uuid = "123-456" }
                }
            ]
        };

        var httpClient = CreateMockHttpClient(mockResponse);
        var service = new UserService(httpClient);

        var result = await service.GetUsersAsync(1);

        Assert.True(result.IsSuccess);
        Assert.Single(result.Data!);
        Assert.Equal("John Doe", result.Data![0].FullName);
    }

    [Fact]
    public async Task GetUsersAsync_ReturnsFailure_WhenApiReturnsError()
    {
        var httpClient =
            CreateMockHttpClient(HttpStatusCode.InternalServerError);
        var service = new UserService(httpClient);

        var result = await service.GetUsersAsync(10);

        Assert.False(result.IsSuccess);
        Assert.NotNull(result.ErrorMessage);
    }

    private static HttpClient CreateMockHttpClient(ApiResponse response)
    {
        var json = JsonSerializer.Serialize(response);
        var mockHandler = new Mock<HttpMessageHandler>();
        mockHandler.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json)
            });
        return new HttpClient(mockHandler.Object);
    }

    private static HttpClient CreateMockHttpClient(HttpStatusCode statusCode)
    {
        var mockHandler = new Mock<HttpMessageHandler>();
        mockHandler.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage { StatusCode = statusCode });
        return new HttpClient(mockHandler.Object);
    }

    [Fact]
    public async Task GetUsersAsync_ReturnsFailure_WhenNoDataReceived()
    {
        var mockResponse = new ApiResponse { Results = null };
        var httpClient = CreateMockHttpClient(mockResponse);
        var service = new UserService(httpClient);

        var result = await service.GetUsersAsync(10);

        Assert.False(result.IsSuccess);
        Assert.Equal("No data received from API.", result.ErrorMessage);
    }
}