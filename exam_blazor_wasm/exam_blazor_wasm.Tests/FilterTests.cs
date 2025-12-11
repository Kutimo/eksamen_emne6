using exam_blazor_wasm.Models;
using exam_blazor_wasm.Services;

namespace exam_blazor_wasm.Tests;

public class FilterTests
{
    private readonly IUserFilterService _filterService = new UserFilterService();
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
        var filtered = _filterService.FilterUsers(_users, searchText).ToList();

        Assert.Equal(2, filtered.Count);
        Assert.All(filtered, u => Assert.Contains("John", u.FullName));
    }

    [Fact]
    public void Filter_ByGender_ReturnsMatchingUsers()
    {
        var searchText = "female";
        var filtered = _filterService.FilterUsers(_users, searchText).ToList();

        Assert.Single(filtered);
        Assert.Equal("Jane Smith", filtered.First().FullName);
    }

    [Fact]
    public void Filter_ByCountry_ReturnsMatchingUsers()
    {
        var searchText = "Canada";
        var filtered = _filterService.FilterUsers(_users, searchText).ToList();

        Assert.Single(filtered);
        Assert.Equal("Jane Smith", filtered.First().FullName);
    }

    [Fact]
    public void Filter_EmptySearch_ReturnsAllUsers()
    {
        var searchText = "";
        var filtered = _filterService.FilterUsers(_users, searchText).ToList();

        Assert.Equal(3, filtered.Count);
    }
}