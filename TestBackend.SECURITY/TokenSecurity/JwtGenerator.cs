using TestBackend.APP.Application.Agreements;
using TestBackend.MODEL.Entities;

namespace TestBackend.SECURITY.TokenSecurity
{
    public class JwtGenerator : IJwtGenerator
    {
        public string CreateToken(User user)
        {
            throw new NotImplementedException();
        }
    }
}
