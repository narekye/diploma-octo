using System;
using System.Threading.Tasks;

namespace OCTO.DAL.Core
{
    public interface IDatabaseTransaction : IDisposable
    {
        Task BeginTransactionAsync();

        void BeginTransaction();

        void RollbackTransaction();

        void CommitTransaction();

        Task EnsureTransactionAsync();

        void EnsureTransaction();

        Task<int> SaveChangesAsync(bool commit = true);
    }
}
