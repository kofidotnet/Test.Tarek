using Test.Tarek.Models.Entities;

namespace Test.Tarek.Logic.Services
{
    public interface IUserService { Task<List<UserModel>> GetUsers(); }
}
