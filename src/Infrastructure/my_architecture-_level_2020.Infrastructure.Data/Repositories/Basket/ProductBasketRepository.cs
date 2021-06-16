namespace my_architecture__level_2020.Infrastructure.Data.Repositories.Basket
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.Core.Basket;
    using Domain.Interfaces.Basket;

    public class ProductBasketRepository : IProductBasketRepository
    {
        public ProductBasketRepository(
            IDBContext dbContext
        )
        {
            this.dbContext = dbContext;
        }

        private IDBContext dbContext { get; }

        public void Create(ProductBasket item)
        {
            throw new NotImplementedException();
        }

        public Task<ProductBasket> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductBasket> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductBasket> Get(Func<ProductBasket, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductBasket item)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductBasket item)
        {
            throw new NotImplementedException();
        }
    }
}