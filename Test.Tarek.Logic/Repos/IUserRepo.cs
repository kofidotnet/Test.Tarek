using Test.Tarek.Models.Entities;

namespace Test.Tarek.Logic.Repos
{
    public interface IUserRepo { Task<List<UserModel>> GetUsers(); }
}
