namespace exam_blazor_wasm.Models;

public class ApiResponse
{
    public List<ApiUser>? Results { get; set; } = [];
}

public class ApiUser
{
    public ApiLogin Login { get; set; } = new();
    public string Gender { get; set; } = string.Empty;
    public ApiName Name { get; set; } = new();
    public ApiLocation Location { get; set; } = new();
    public string Email { get; set; } = string.Empty;
    public ApiDob Dob { get; set; } = new();
    public ApiRegistered Registered { get; set; } = new();
    public string Phone { get; set; } = string.Empty;
    public ApiPicture Picture { get; set; } = new();
    public string Nat { get; set; } = string.Empty;
}