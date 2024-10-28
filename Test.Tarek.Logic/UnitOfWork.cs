using Test.Tarek.Database.Data;
using Test.Tarek.Logic.Repos;

namespace Test.Tarek.Logic
{
    public class UnitOfWork
    {
        private UserRepo? _userRepo;
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserRepo? UserRepository
        {
            get
            {
                if (_userRepo == null)
                    _userRepo = new UserRepo(_dbContext);
                return _userRepo;
            }
        }
    }
}
