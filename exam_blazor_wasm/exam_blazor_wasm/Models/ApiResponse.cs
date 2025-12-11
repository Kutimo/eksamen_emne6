namespace exam_blazor_wasm.Models;

public class ApiResponse
{
    public List<ApiUser>? Results { get; init; } = [];
}

public class ApiUser
{
    public ApiLogin Login { get; init; } = new();
    public string Gender { get; init; } = string.Empty;
    public ApiName Name { get; init; } = new();
    public ApiLocation Location { get; init; } = new();
    public string Email { get; init; } = string.Empty;
    public ApiDob Dob { get; init; } = new();
    public ApiRegistered Registered { get; init; } = new();
    public string Phone { get; init; } = string.Empty;
    public ApiPicture Picture { get; init; } = new();
    public string Nat { get; init; } = string.Empty;
}