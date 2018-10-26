using System;
using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces.Core
{
    public interface IServiceBase : IDisposable
    {
        bool IsChild { get; }

        bool IsCommitingChanges { get; set; }

        bool IsSavingChanges { get; set; }

        IServiceBase Parent { get; set; }

        void EnsureTransaction();

        void RollbackTransaction();

        Task<int> SaveChangesAsync(bool commit = false);
    }
}
