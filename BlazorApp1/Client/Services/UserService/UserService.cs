using System.Net.Http.Json;

namespace BlazorApp1.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }
        public List<xlnuser> Users { get; set ; } = new List<xlnuser> ();

        public async Task<xlnuser> GetSingleUser(int id)
        {
            var result = await _http.GetFromJsonAsync<xlnuser>($"api/user/{id}");

          if (result != null)
            {
             return result;
            }
            else
            {
               throw new Exception("NO USER");
            }
                    
          
        }

        public async Task GetUsers()
        {
       
            var result = await _http.GetFromJsonAsync<List<xlnuser>>("api/user");

            if (result != null)
                Users = result;
        
        }
    }
}
