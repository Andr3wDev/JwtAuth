using JWTApp.Models;
using System.Threading.Tasks;

namespace JWTApp.Services
{
    public interface IUserService
    {
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<string> RegisterAsync(RegisterModel model);
    }
}
