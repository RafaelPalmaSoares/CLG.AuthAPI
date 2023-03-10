using System.ComponentModel.DataAnnotations.Schema;

namespace CLG.AuthAPI.Application.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }
    }
}
