namespace BlazorApp1.Client.Services.UserService
{
    public interface IUserService
    {
        List<xlnuser> Users { get; set; }

        Task GetUsers();

        Task<xlnuser> GetSingleUser(int id);

    }
}
