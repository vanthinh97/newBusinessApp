using newBusinessApp.Entities;

namespace newBusinessApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
