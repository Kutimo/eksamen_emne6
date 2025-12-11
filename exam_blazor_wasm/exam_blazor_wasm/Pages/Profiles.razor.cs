using Microsoft.AspNetCore.Components;
using exam_blazor_wasm.Models;
using exam_blazor_wasm.Services;

namespace exam_blazor_wasm.Pages;

public partial class Profiles
{
    [Inject] private IUserService UserService { get; set; } = default!;

    private List<User> _users = [];
    private bool _isLoading = true;
    private int _count = 10;
    private string _searchText = string.Empty;
    private string? _errorMessage;
    private User? _selectedUser;
    private bool _isModalOpen;

    private IEnumerable<User> FilteredUsers => string.IsNullOrWhiteSpace(_searchText)
        ? _users
        : _users.Where(u =>
            u.FullName.Contains(_searchText, StringComparison.OrdinalIgnoreCase) ||
            u.Gender.Contains(_searchText, StringComparison.OrdinalIgnoreCase) ||
            u.Country.Contains(_searchText, StringComparison.OrdinalIgnoreCase) ||
            u.City.Contains(_searchText, StringComparison.OrdinalIgnoreCase) ||
            u.State.Contains(_searchText, StringComparison.OrdinalIgnoreCase));

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        _isLoading = true;
        _errorMessage = null;
        var result = await UserService.GetUsersAsync(_count);
        if (result.IsSuccess)
            _users = result.Data ?? [];
        else
            _errorMessage = result.ErrorMessage;
        _isLoading = false;
    }

    private async Task HandleCountChange(int count)
    {
        _count = count;
        await LoadUsers();
    }

    private void HandleSearchChange(string searchText)
    {
        _searchText = searchText;
    }

    private void OpenModal(User user)
    {
        _selectedUser = user;
        _isModalOpen = true;
    }

    private void CloseModal()
    {
        _isModalOpen = false;
        _selectedUser = null;
    }
}