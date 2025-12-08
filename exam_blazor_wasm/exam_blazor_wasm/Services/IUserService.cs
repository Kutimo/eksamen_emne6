using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Services;

public interface IUserService
{
    Task<List<User>> GetUsersAsync(int count);
}