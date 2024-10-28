using Test.Tarek.Logic.Repos;
using Test.Tarek.Models.Entities;

namespace Test.Tarek.Logic.Services
{
    public sealed class UserService(IUserRepo userRepo) : IUserService
    {
        public Task<List<UserModel>> GetUsers()
        {
            return userRepo.GetUsers();
        }
    }
}
