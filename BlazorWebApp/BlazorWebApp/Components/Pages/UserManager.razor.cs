using BlazorWebApp.Models;
using BlazorWebApp.Services.IService;
using Microsoft.AspNetCore.Components;

namespace BlazorWebApp.Components.Pages
{
    public partial class UserManager : ComponentBase
    {
        [Inject]
        public IAdminDataService AdminDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private User user = new();
        private List<User> users = new();

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            await GetAllUsers();
        }

        private async Task GetAllUsers()
        {
            users = await AdminDataService.GetAllUsers();
        }

        private async Task GetUserById(int id)
        {
            user = await AdminDataService.GetUserById(id);
        }

        private string GetEditUrl(int id) => $"/edituser/{id}";

    }
}
