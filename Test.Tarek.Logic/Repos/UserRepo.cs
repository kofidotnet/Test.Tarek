using Microsoft.EntityFrameworkCore;
using Test.Tarek.Database.Data;
using Test.Tarek.Models.Entities;

namespace Test.Tarek.Logic.Repos
{
    public class UserRepo(AppDbContext dbContext) : IUserRepo
    {
        public Task<List<UserModel>> GetUsers()
        {
            return dbContext.Users.ToListAsync();
        }
    }
}
