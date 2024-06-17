namespace Manager.Infra.Interfaces{

    public interface IUserRepository : IBaseRepository<User>{
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByEmail(string email);
        Task<List<User>> GetByName(string name);
    }
}