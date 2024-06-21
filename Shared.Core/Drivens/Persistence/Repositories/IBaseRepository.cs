using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shared.Core.Domain.Entities;

namespace Shared.Core.Drivens.Persistence.Repositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> GetByIdAsync(string id);

    Task<List<TEntity>> GetAllAsync();

    ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity);
}