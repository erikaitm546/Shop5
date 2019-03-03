

namespace Shop5.Web.Helpers
{
    using System.Threading.Tasks;
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using Shop5.Web.Models;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<User> GetUserByEmail(string v);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();


    }

}
