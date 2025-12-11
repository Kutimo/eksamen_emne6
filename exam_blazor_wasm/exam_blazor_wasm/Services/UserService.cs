using System.Net.Http.Json;
using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Services;

public class UserService(HttpClient httpClient) : IUserService
{
    private const string BaseUrl = "https://randomuser.me/api/";

    public async Task<Result<List<User>>> GetUsersAsync(int count)
    {
        try
        {
            var response = await httpClient.GetAsync($"{BaseUrl}?results={count}");
            if (!response.IsSuccessStatusCode)
                return Result<List<User>>.Failure($"Request failed: {(int)response.StatusCode}");
            var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse>();
            if (apiResponse?.Results == null)
                return Result<List<User>>.Failure("No data received from API.");
            var users = apiResponse.Results.Select(MapToUser).ToList();
            return Result<List<User>>.Success(users);
        }
        catch (HttpRequestException)
        {
            return Result<List<User>>.Failure("Unable to connect. Check your internet connection.");
        }
        catch (Exception)
        {
            return Result<List<User>>.Failure("An unexpected error occurred.");
        }
    }

    private static User MapToUser(ApiUser apiUser)
    {
        return new User
        {
            Id = apiUser.Login.Uuid,
            Title = apiUser.Name.Title,
            FullName = $"{apiUser.Name.First} {apiUser.Name.Last}",
            Gender = apiUser.Gender,
            Email = apiUser.Email,
            Phone = apiUser.Phone,
            Age = apiUser.Dob.Age,
            Nationality = apiUser.Nat,
            RegisteredDate = apiUser.Registered.Date,
            StreetNumber = apiUser.Location.Street.Number,
            StreetName = apiUser.Location.Street.Name,
            City = apiUser.Location.City,
            State = apiUser.Location.State,
            Country = apiUser.Location.Country,
            ThumbnailUrl = apiUser.Picture.Thumbnail,
            LargeImageUrl = apiUser.Picture.Large
        };
    }
}