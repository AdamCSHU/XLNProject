namespace BlazorApp1.Client.Services.UserService
{
    public interface IUserService
    {
        List<User> Users { get; set; }

        Task GetUsers();

        Task<User> GetSingleUser(int id);

    }
}
