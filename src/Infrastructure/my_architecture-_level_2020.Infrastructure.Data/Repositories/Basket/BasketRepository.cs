namespace my_architecture__level_2020.Infrastructure.Data.Repositories.Basket
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.Core.Basket;
    using Domain.Interfaces.Basket;

    public class BasketRepository : IBasketRepository
    {
        public BasketRepository(
            IDBContext dbContext
        )
        {
            this.dbContext = dbContext;
        }

        private IDBContext dbContext { get; }

        public void Create(Basket item)
        {
            throw new NotImplementedException();
        }

        public Task<Basket> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Basket> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Basket> Get(Func<Basket, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Basket item)
        {
            throw new NotImplementedException();
        }

        public void Update(Basket item)
        {
            throw new NotImplementedException();
        }
    }
}