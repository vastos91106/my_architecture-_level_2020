namespace my_architecture__level_2020.Infrastructure.Data
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDBContext : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}