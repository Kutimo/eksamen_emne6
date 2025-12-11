namespace exam_blazor_wasm.Models;

public class User
{
    public string Id { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public string Gender { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public int Age { get; init; }
    public string Nationality { get; init; } = string.Empty;
    public DateTime RegisteredDate { get; init; }
    public int StreetNumber { get; init; }
    public string StreetName { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
    public string ThumbnailUrl { get; init; } = string.Empty;
    public string LargeImageUrl { get; init; } = string.Empty;
}