using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Services;

public interface IUserFilterService
{
    IEnumerable<User> FilterUsers(IEnumerable<User> users, string searchText);
}
