﻿using OCTO.DAL.Core;
using OCTO.DAL.Models;

namespace OCTO.DAL.Repositories.Interfaces
{
    public interface ISalutationRepository : IRepositoryBase<Salutation>, IDatabaseTransaction
    {
    }
}
