using BANKAPI.Data.Model;
using BANKAPI.Data.ViewModel;

namespace BANKAPI.Services
{
    public class UserService : IUserService
    {
        public void Create(UserViewModel email)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IsUser(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void Update(User username)
        {
            throw new NotImplementedException();
        }
    }
}
