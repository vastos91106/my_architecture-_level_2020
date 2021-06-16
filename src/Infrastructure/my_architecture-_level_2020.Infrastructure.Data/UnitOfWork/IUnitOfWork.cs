namespace my_architecture__level_2020.Infrastructure.Data.UnitOfWork
{
    using System;

    public interface IUnitOfWork : IDisposable
    {
        public IBasketRepositories Basket { get; }

        public IUserRepositories User { get; }

        public void Save();

        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}