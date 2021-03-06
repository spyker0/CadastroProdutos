﻿using System.Threading;
using System.Threading.Tasks;

namespace CadastroProduto.Domain
{
    public interface IUnitOfWork
    {
        Task<int> SaveAggregateEntitiesAsync(CancellationToken cancellationToken = default);
    }
}
