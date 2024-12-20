using BlazorWebApp.Models;

namespace BlazorWebApp.Services.IService
{
    public interface IAdminDataService
    {
        Task<List<User>> GetAllUsers();

        Task<User> GetUserById(int id);
    }
}
