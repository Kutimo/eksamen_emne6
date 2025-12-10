using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Services;

public interface IUserService
{
    Task<Result<List<User>>> GetUsersAsync(int count);
}