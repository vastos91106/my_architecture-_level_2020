namespace my_architecture__level_2020.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            IBasketRepositories basketRepositories,
            IUserRepositories userRepositories
        )
        {
            this.Basket = basketRepositories;
            this.User = userRepositories;
        }

        public IBasketRepositories Basket { get; }
        public IUserRepositories User { get; }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}