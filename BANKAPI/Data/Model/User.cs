using System.ComponentModel.DataAnnotations;

namespace BANKAPI.Data.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
