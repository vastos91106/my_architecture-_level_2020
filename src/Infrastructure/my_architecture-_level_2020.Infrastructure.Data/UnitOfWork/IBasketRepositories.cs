namespace my_architecture__level_2020.Infrastructure.Data.UnitOfWork
{
    using Domain.Interfaces.Basket;

    public interface IBasketRepositories
    {
        public IProductBasketRepository ProductBasketRepository { get; }
        
        public IBasketRepository BasketRepository { get; }
    }
}