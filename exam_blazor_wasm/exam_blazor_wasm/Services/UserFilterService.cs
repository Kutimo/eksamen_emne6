using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Services;

public class UserFilterService : IUserFilterService
{
    public IEnumerable<User> FilterUsers(IEnumerable<User> users, string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
            return users;

        return users.Where(u =>
            u.FullName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
            u.Gender.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
            u.Country.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
            u.City.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
            u.State.Contains(searchText, StringComparison.OrdinalIgnoreCase));
    }
}
