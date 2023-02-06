namespace CLG.AuthAPI.Application.Models
{
    public class Jwt
    {
        public string Secret { get; set; }
        public int Expires { get; set; }
    }
}
