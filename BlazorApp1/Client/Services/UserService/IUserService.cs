namespace BlazorApp1.Client.Services.UserService
{
    public interface IUserService
    {
        List<xlnuser> Users { get; set; }

        List<Fault> faults { get; set; }

        Task GetFaults();

        Task GetUsers();

        Task<xlnuser> GetSingleUser(int id);

    }
}
