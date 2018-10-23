using System;
using System.Threading.Tasks;

namespace OCTO.DAL.Core
{
    public interface IDatabaseTransaction : IDisposable
    {
        void BeginTransaction();

        void RollbackTransaction();

        void CommitTransaction();

        void EnsureTransaction();

        Task<int> SaveChangesAsync(bool commit = true);
    }
}
