using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Agreements
{
    public interface IJwtGenerator
    {
        string CreateToken(User user);
    }
}
