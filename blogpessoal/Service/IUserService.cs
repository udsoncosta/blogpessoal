using blogpessoal.Model;

namespace blogpessoal.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();

        Task<User?> GetById(long id);

        Task<User?> GetByUsuario(string usuario);

        Task<User?> Create(User Usuario);

        Task<User?> Update(User Usuario);

    }
}