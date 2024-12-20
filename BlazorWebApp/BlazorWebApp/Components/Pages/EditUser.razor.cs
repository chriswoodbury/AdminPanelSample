using BlazorWebApp.Models;
using BlazorWebApp.Services.IService;
using Microsoft.AspNetCore.Components;

namespace BlazorWebApp.Components.Pages
{
    public partial class EditUser : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IAdminDataService AdminDataService { get; set; }

        User user = new();

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            await GetUser(Id);
        }

        private async Task GetUser(int id)
        {
            user = await AdminDataService.GetUserById(id);
        }

    }
}
