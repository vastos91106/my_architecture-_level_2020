namespace my_architecture__level_2020.Infrastructure.Data.Repositories.User
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.Core.User;
    using Domain.Interfaces.User;

    public class UserRepository : IUserRepository
    {
        public UserRepository(
            IDBContext dbContext
        )
        {
            this.dbContext = dbContext;
        }

        private IDBContext dbContext { get; }

        public void Create(User item)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(User item)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}