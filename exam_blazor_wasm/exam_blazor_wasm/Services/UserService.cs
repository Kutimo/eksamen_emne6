using System.Net.Http.Json;
using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Services;

public class UserService(HttpClient httpClient) : IUserService
{
    private const string BaseUrl = "https://randomuser.me/api/?results=";

    public async Task<List<User>> GetUsersAsync(int count)
    {
        var response = await httpClient.GetFromJsonAsync<ApiResponse>($"{BaseUrl}{count}");
        
        if (response?.Results == null)
            return [];

        return response.Results.Select(MapToUser).ToList();
    }

    private static User MapToUser(ApiUser apiUser)
    {
        return new User
        {
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
            Postcode = apiUser.Location.Postcode,
            ThumbnailUrl = apiUser.Picture.Thumbnail,
            MediumImageUrl = apiUser.Picture.Medium,
            LargeImageUrl = apiUser.Picture.Large
        };
    }
}