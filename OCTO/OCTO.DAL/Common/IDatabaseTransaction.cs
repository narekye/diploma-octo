using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace OCTO.DAL.Common
{
    public interface IDatabaseTransaction : IDisposable
    {
        IDbContextTransaction Transaction { get; set; }

        void BeginTransaction();

        void RollbackTransaction();

        void CommitTransaction();

        void EnsureTransaction();

        Task<int> SaveChangesAsync(bool commit = true);
    }
}
