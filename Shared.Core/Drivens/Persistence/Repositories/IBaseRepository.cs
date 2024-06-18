using Shared.Core.Domain.Entities;

namespace Shared.Core.Drivens.Persistence.Repositories;

public interface IBaseRepository<out TEntity> where TEntity : BaseEntity
{
    TEntity GetById(string id);

    TEntity GetAll();
    
    // TODO
    // TEntity GetManyWithFilter();
}