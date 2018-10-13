using OCTO.DAL.Entities;
using System;

namespace OCTO.DAL
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class, IEntity
    {

    }
}
