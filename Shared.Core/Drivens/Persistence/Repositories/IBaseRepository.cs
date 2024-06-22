using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shared.Core.Domain.Entities;

namespace Shared.Core.Drivens.Persistence.Repositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> GetByIdAsync(string id, CancellationToken cancellationToken);

    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);

    ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity, CancellationToken cancellationToken);
}