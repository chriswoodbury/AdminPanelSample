using BlazorWebApp.Models;
using BlazorWebApp.Services.IService;

namespace BlazorWebApp.Services
{
    public class AdminDataService : IAdminDataService
    {
        private readonly HttpClient _httpClient;   

        public AdminDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<User>> GetAllUsers()
        { 
            var userList = new List<User>()
            { 
               new User { Id = 1, Name = "August West", Email = "august@west.com", Password = "august123", Role = "Admin"},
               new User { Id = 2, Name = "Pearly Baker", Email = "pearly@baker.com", Password = "pearly123", Role = "Admin"},
               new User { Id = 3, Name = "Chris Allen", Email = "chrisw@mercola.com", Password = "chris123", Role = "Editor"}
            };

            return Task.FromResult(userList);
        }

        public Task<User> GetUserById(int id)
        {
            var userList = new List<User>()
            {
               new User { Id = 1, Name = "August West", Email = "august@west.com", Password = "august123", Role = "Admin"},
               new User { Id = 2, Name = "Pearly Baker", Email = "pearly@baker.com", Password = "pearly123", Role = "Admin"},
               new User { Id = 3, Name = "Chris Allen", Email = "chrisw@mercola.com", Password = "chris123", Role = "Editor"}
            };

            var user = userList.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(user);
        }
    }
}
