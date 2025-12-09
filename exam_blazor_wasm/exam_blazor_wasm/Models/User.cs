namespace exam_blazor_wasm.Models;

public class User
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Nationality { get; set; } = string.Empty;
    public DateTime RegisteredDate { get; set; }
    public int StreetNumber { get; set; }
    public string StreetName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Postcode { get; set; } = string.Empty;
    public string ThumbnailUrl { get; set; } = string.Empty;
    public string MediumImageUrl { get; set; } = string.Empty;
    public string LargeImageUrl { get; set; } = string.Empty;
}