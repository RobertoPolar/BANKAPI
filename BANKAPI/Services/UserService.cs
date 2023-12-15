using BANKAPI.Data;
using BANKAPI.Data.Model;
using BANKAPI.Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace BANKAPI.Services
{
    public class UserService : IUserService
    {
        private readonly BankContext _bankContext;

        public UserService(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public void Create(UserViewModel data)
        {
            User user = new User();
            user.Id = Guid.NewGuid();
            user.Nome = data.Nome;
            user.Email = data.Email;
            user.Senha = data.Senha;

            _bankContext.Users.Add(user);
            _bankContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var user = _bankContext.Users.Find(id);

            if (user != null)
            {
                _bankContext.Users.Remove(user);
                _bankContext.SaveChanges();
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _bankContext.Users.ToListAsync();
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _bankContext.Users.FindAsync(id);
        }

        public bool IsUser(string email, string senha)
        {
            return _bankContext.Users.Any(x => x.Email == email && x.Senha == senha);
        }

        public void Update(User data)
        {
            var user = _bankContext.Users.Find(data.Id);

            if (user != null)
            {
                user.Nome = data.Nome;
                user.Email = data.Email;
                user.Senha = data.Senha;

                _bankContext.Users.Update(user);
                _bankContext.SaveChanges();
            }
        }
    }
}
