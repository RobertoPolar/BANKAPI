using BANKAPI.Data.Model;
using BANKAPI.Data.ViewModel;

namespace BANKAPI.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAll();
        public Task<User?> GetById(Guid id);
        public void Create(UserViewModel email);
        public void Update(User username);
        public void Delete(Guid id);
        public bool IsUser(string email, string senha);
    }
}
