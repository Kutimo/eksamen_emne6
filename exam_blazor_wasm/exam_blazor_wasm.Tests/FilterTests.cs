using exam_blazor_wasm.Models;

namespace exam_blazor_wasm.Tests;

public class FilterTests
{
    private readonly List<User> _users =
    [
        new User { FullName = "John Doe", Gender = "male", Country = "USA", City = "New York", State = "NY" },
        new User { FullName = "Jane Smith", Gender = "female", Country = "Canada", City = "Toronto", State = "Ontario" },
        new User { FullName = "Bob Johnson", Gender = "male", Country = "USA", City = "Los Angeles", State = "CA" }
    ];

    [Fact]
    public void Filter_ByName_ReturnsMatchingUsers()
    {
        var searchText = "John";
        var filtered = FilterUsers(_users, searchText);

        Assert.Equal(2, filtered.Count());
        Assert.All(filtered, u => Assert.Contains("John", u.FullName));
    }

    [Fact]
    public void Filter_ByGender_ReturnsMatchingUsers()
    {
        var searchText = "female";
        var filtered = FilterUsers(_users, searchText);

        Assert.Single(filtered);
        Assert.Equal("Jane Smith", filtered.First().FullName);
    }

    [Fact]
    public void Filter_ByCountry_ReturnsMatchingUsers()
    {
        var searchText = "Canada";
        var filtered = FilterUsers(_users, searchText);

        Assert.Single(filtered);
        Assert.Equal("Jane Smith", filtered.First().FullName);
    }

    [Fact]
    public void Filter_EmptySearch_ReturnsAllUsers()
    {
        var searchText = "";
        var filtered = FilterUsers(_users, searchText);

        Assert.Equal(3, filtered.Count());
    }

    private static IEnumerable<User> FilterUsers(List<User> users, string searchText)
    {
        return string.IsNullOrWhiteSpace(searchText)
            ? users
            : users.Where(u =>
                u.FullName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                u.Gender.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                u.Country.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                u.City.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                u.State.Contains(searchText, StringComparison.OrdinalIgnoreCase));
    }
}